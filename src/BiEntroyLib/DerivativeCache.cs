using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SMC.Numerics.BiEntropy
{
    public class DerivativeCache <TItem>
    {
        private readonly MemoryCacheEntryOptions entryOptions;

        private MemoryCache _cache = new MemoryCache(new MemoryCacheOptions());
        private ConcurrentDictionary<int, SemaphoreSlim> _locks = new ConcurrentDictionary<int, SemaphoreSlim>();
                
        public DerivativeCache(int slidingExpiration, int absoluteExpiration)
        {
            entryOptions = new MemoryCacheEntryOptions().SetPriority(CacheItemPriority.High).SetSlidingExpiration(TimeSpan.FromSeconds(slidingExpiration)).SetAbsoluteExpiration(TimeSpan.FromSeconds(absoluteExpiration));
        }

        public async Task<TItem> GetOrCreate(MultiKey key, Func<BitArray, int, TItem> createItem)
        {

            var hash = key.GetHashCode();
            if (!_cache.TryGetValue(hash, out TItem cacheEntry))
            {
                var itemLock = _locks.GetOrAdd(hash, k => new SemaphoreSlim(1, 1));
                await itemLock.WaitAsync();

                try
                {
                    if (!_cache.TryGetValue(hash, out cacheEntry))
                    {
                        cacheEntry = createItem(key.Key1, key.Key2);
                        _cache.Set(hash, cacheEntry, entryOptions);
                    }
                }
                finally
                {
                    itemLock.Release();
                }
            }

            return cacheEntry;
        }
    }
}