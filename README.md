# BiEntropy
This library provides a pure .NET implementation of the BiEntropy algorithm as presented in [BiEntropy - The Apprxoimate Entropy of a Finite Binary String](https://arxiv.org/abs/1305.0954) by
Grenville J. Croll.

## Introduction
The follow is a quick introduction to the BiEntropy algorithm and why it provides a better measurement of entropy in a binary string compared to the Shannon Entropy equations.  All the below information
is contained in the linked article above and provides more details.

The BiEntropy algorithm is based upon a weighted average of the Shannon Entropies of all but the last binary derivative of the string.  \
Shannon's Entropy of a binary string

<a href="https://www.codecogs.com/eqnedit.php?latex=s=s_{1},...,s_{n}" target="_blank"><img src="https://latex.codecogs.com/gif.latex?s=s_{1},...,s_{n}" title="s=s_{1},...,s_{n}" /></a>

where:

<a href="https://www.codecogs.com/eqnedit.php?latex=P(s_{i}=1)=p" target="_blank"><img src="https://latex.codecogs.com/gif.latex?P(s_{i}=1)=p" title="P(s_{i}=1)=p" /></a>

is defined as:

<img src="https://latex.codecogs.com/gif.latex?H(p)=-log_{2}p-(1-p)log_{2}(1-p)" title="H(p)=-log_{2}p-(1-p)log_{2}(1-p)" />

If string which is all 1's or 0's, i.e. ```p = 0``` or ```p = 1```, ```H(p) = 0```.  If ```p = 0.5```, ```H(p) = 1``` which indicates maximum variety.  However, if the string is periodic 
(e.g. ```01010101```) ```p = 0.5, H(p) = 1```.  This indicates that the Shannon Entropy equation completely ignores the periodic nature of the binary string.

## BiEntropy Algorithm
For the BiEntropy algorithm, we will define the first binary derivative algorithm for a binary string ```s```:

<img src="https://latex.codecogs.com/gif.latex?d_{1}(s)" title="d_{1}(s)" />

which is the binary string of length ```n - 1``` formed by XORing adjacent pairs of digits.  The *k*th derivative of ```s``` as ```d_k(s)``` as the binary derivative of ```d_(k-1)(s)``` which means 
there are ```n - 1``` binary derivaties of ```s```.  We will also define the function ```p(k)``` as the fraction of 1's  in ```d_k(s)```.  Using these two functions, we can describe the basic 
BiEntropy algorithm, which is valid when the length of the binary string is less than, or equal to, 32-bits (i.e. ```n <= 32```), as:

<img src="https://latex.codecogs.com/gif.latex?BiEn(s)&space;=&space;\left(&space;\frac{1}{2^{n-1}-1}\right&space;)&space;\left&space;(&space;\sum_{k=0}^{n-2}((-p(k)\log_{2}&space;p(k)-(1-p(k))\log_{2}(1-p(k))))2^{k}&space;\right&space;)" title="BiEn(s) = \left( \frac{1}{2^{n-1}-1}\right ) \left ( \sum_{k=0}^{n-2}((-p(k)\log_{2} p(k)-(1-p(k))\log_{2}(1-p(k))))2^{k} \right )" />

For binary strings longer than 32-bits (i.e. ```n > 32```) the following algorithm is used:

<img src="https://latex.codecogs.com/gif.latex?Tres&space;BiEn(s)=&space;\left(&space;\frac{1}{\sum_{k=0}^{n-2}\log_{2}(k&plus;2)}\right&space;)&space;\left&space;(&space;\sum_{k=0}^{n-2}(-p(k)\log_{2}p(k)-(1-p(k))\log_{2}(1-p(k)))\log_{2}(k&plus;2)&space;\right&space;)" title="Tres BiEn(s)= \left( \frac{1}{\sum_{k=0}^{n-2}\log_{2}(k+2)}\right ) \left ( \sum_{k=0}^{n-2}(-p(k)\log_{2}p(k)-(1-p(k))\log_{2}(1-p(k)))\log_{2}(k+2) \right )" />

## Usage
The library contains two static classes; ```BiEntropy``` and ```TresBiEntropy``` each which has a ```Calculate``` method.  The ```Calculate``` method has various overloads for numeric/floating data types (e.g. byte, long, double, decimal) as well as
string data (i.e. char and string).  All the numeric overloads accept three parameters.  The value to calculate the entropy of, the ```precision``` (number of decimal places for the returned result), and a boolean called ```useConstantIfAvailable```.
The library has precalculated values for 2-bit, 4-bit, and 8-bit binary strings for the BiEntropy algorithm and 8-bit binary strings for the TresBiEntropy method.  When the boolean is ```true```, instead of the method calculating the value, it will
do a lookup instead, thereby saving time and resources.

>>**NOTE:** If ```BiEntropy.Calculate``` is called with a binary string that contains more than 32-bits, it will automatically forward the call to the ```TresBiEntropy.Calculate``` method.

Both classes also contain the methods ```EnableCache()```/```DisableCache()```.  Since the algorithm runs in exponential time, that is O(n^2), the classes can use a special memory cache which will store binary strings and their *k*-th derivative.
This can help reduce the calculation time at the expense of using more memory.  The properties of the cache can be controlled through settings in the app.config file.  Specifically:

```xml
  <appSettings>
    <add key="slidingExpirationSeconds" value ="600" />
    <add key="absoluteExpirationSeconds" value ="3600"/>
  </appSettings>
```

The ```slidingExpirationSeconds``` indicates for how many seconds an entry is kept in the cache.  If the same entry is access within this sliding time period, the expiration time is extended by this amount again.  The ```absoluteExpirationSeconds```
indicates after how much time, regardless if the entry was still accessed again, the entry is removed from the cache.  Depending on feedback and user's experiences, exactly how this cache is implemented and used may change in the future.

## Unit Tests
The unit tests included in the solution covers all the test vectors provided in the original paper.  The units tests have been designed to ensure that the values calculated by the library are within
0.1% of the test vectors when rounded to two decimal places, although in most cases the values (when rounded) are exactly the same as the values in the paper.

## Benchmarks
The original paper reports that "The BiEntropy algorithm evaluates the order and disorder of a binary string of length *n* in O(*n*^2) time using O(*n*) memory.".  The [BechmarkDotnet](https://github.com/dotnet/BenchmarkDotNet) library was used
in order to determine how closely this library came to matching this ideal run time.  The following table indicates the ideal time and actual run time for various *n*-length binary strings:

|n|O(*n*^2)|Lib|
|-|--------|---|
|8|64|
|16|256|
|32|1024|
|64|4096|
|128|16384|
|256|65536|
|512|262144|
|1024|1048576|
|2048|4194304|
|4096|16777216|

For these benchmarks, the ```TresBiEntropy.Calculate()```  method was used, since any binary string with ```n > 32``` would automatically be forwarded to this method anyways.  Also, caching was enabled to get the best performance possible.  The
following is the ideal vs. actual times graphed against each other:



## Versions
**1.0.0** - Initial Release
- Full implementation of the BiEntropy and Tres BiEntropy algorithms
- Extension methods for easier useage
- Full unit testing of all test vectors

This project uses [SemVer](http://semver.org) for versioning.

## Authors
- Dominick Marciano Jr.

## License
Copyright (c) 2019 Dominick Marciano Jr., Sci-Med Coding.  All rights reserved