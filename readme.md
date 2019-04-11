# Concurrent-Stacks
Study about perfomance of stacks with different kind of locks in multithreaded environment.
Done on local machine and server.

Benchmarks done by great tools BenchmarkDotNet, see version below.
To install it just use nuget and find BenchmarkDotNet. Enjoy!


BenchmarkDotNet=v0.11.5,  OS=Windows 7 SP1 (6.1.7601.0)
Intel Core i5-4570S CPU 2.90GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
Frequency=2825644 Hz, Resolution=353.9016 ns, Timer=TSC
  [Host]     : .NET Framework 4.7.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3133.0
  DefaultJob : .NET Framework 4.7.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3133.0


```
|                                       Method |      Mean |     Error |    StdDev |    Median |
|--------------------------------------------- |----------:|----------:|----------:|----------:|
|                LockStack push with 2 threads | 40.077 ms | 0.6223 ms | 0.5197 ms | 39.945 ms |
|             MonitorStack push with 2 threads |  8.219 ms | 0.2199 ms | 0.6379 ms |  8.027 ms |
|            LockFreeStack push with 2 threads |  7.898 ms | 0.2812 ms | 0.7650 ms |  7.603 ms |
|   ConcurrentStackWrapper push with 2 threads |  7.566 ms | 0.1611 ms | 0.2736 ms |  7.551 ms |
|                LockStack push with 4 threads | 87.030 ms | 1.7393 ms | 3.7441 ms | 87.074 ms |
|             MonitorStack push with 4 threads | 15.994 ms | 0.7839 ms | 2.1591 ms | 15.304 ms |
|            LockFreeStack push with 4 threads | 17.351 ms | 1.4354 ms | 4.0719 ms | 15.721 ms |
|   ConcurrentStackWrapper push with 4 threads | 15.104 ms | 0.2997 ms | 0.7682 ms | 14.919 ms |

|                                          Method |       Mean |     Error |     StdDev |     Median |
|------------------------------------------------ |-----------:|----------:|-----------:|-----------:|
|                LockStack pushpop with 2 threads |  75.278 ms | 1.2552 ms |  1.1127 ms |  75.299 ms |
|             MonitorStack pushpop with 2 threads |   8.202 ms | 0.2347 ms |  0.6345 ms |   8.008 ms |
|            LockFreeStack pushpop with 2 threads |  12.656 ms | 1.2790 ms |  3.7106 ms |  13.258 ms |
|   ConcurrentStackWrapper pushpop with 2 threads |   9.078 ms | 0.4784 ms |  1.3954 ms |   9.486 ms |
|                LockStack pushpop with 4 threads | 167.367 ms | 5.0810 ms | 14.7409 ms | 167.866 ms |
|             MonitorStack pushpop with 4 threads |  13.295 ms | 0.4308 ms |  1.2221 ms |  12.802 ms |
|            LockFreeStack pushpop with 4 threads |  13.696 ms | 0.7189 ms |  2.1197 ms |  12.492 ms |
|   ConcurrentStackWrapper pushpop with 4 threads |  12.409 ms | 0.2227 ms |  0.2083 ms |  12.414 ms |