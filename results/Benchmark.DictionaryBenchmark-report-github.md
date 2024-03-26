```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22631.3296)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method                                | Categories                          | Length | Mean       | Error    | StdDev   | Code Size | Allocated |
|-------------------------------------- |------------------------------------ |------- |-----------:|---------:|---------:|----------:|----------:|
| Class1                                | Class                               | 100000 | 1,965.8 μs |  5.86 μs |  5.48 μs |      72 B |       2 B |
| Class5                                | Class                               | 100000 | 2,129.9 μs |  3.43 μs |  2.86 μs |      84 B |       2 B |
| Class10                               | Class                               | 100000 | 2,564.8 μs | 10.76 μs |  8.98 μs |      99 B |       2 B |
| Class15                               | Class                               | 100000 | 3,906.2 μs |  4.08 μs |  3.81 μs |      76 B |       3 B |
| Class20                               | Class                               | 100000 | 4,388.8 μs |  2.37 μs |  2.22 μs |      76 B |       3 B |
| Class25                               | Class                               | 100000 | 4,664.4 μs |  4.73 μs |  4.42 μs |      76 B |       3 B |
| ClassCollectionsMarshall1             | ClassCollectionsMarshall            | 100000 | 1,894.8 μs |  2.52 μs |  2.36 μs |      58 B |       2 B |
| ClassCollectionsMarshall5             | ClassCollectionsMarshall            | 100000 | 2,116.2 μs |  4.29 μs |  3.35 μs |      70 B |       2 B |
| ClassCollectionsMarshall10            | ClassCollectionsMarshall            | 100000 | 2,569.4 μs |  2.36 μs |  1.84 μs |      85 B |       2 B |
| ClassCollectionsMarshall15            | ClassCollectionsMarshall            | 100000 | 3,770.6 μs |  4.28 μs |  3.58 μs |      62 B |       2 B |
| ClassCollectionsMarshall20            | ClassCollectionsMarshall            | 100000 | 4,188.3 μs | 32.02 μs | 28.39 μs |      62 B |       3 B |
| ClassCollectionsMarshall25            | ClassCollectionsMarshall            | 100000 | 4,691.6 μs |  5.27 μs |  4.67 μs |      62 B |       3 B |
| ClassCollectionsMarshall1NoInlining   | ClassCollectionsMarshallNoInlining  | 100000 | 1,927.9 μs |  9.36 μs |  8.30 μs |      62 B |       2 B |
| ClassCollectionsMarshall5NoInlining   | ClassCollectionsMarshallNoInlining  | 100000 | 2,608.4 μs | 11.49 μs | 10.18 μs |      62 B |       2 B |
| ClassCollectionsMarshall10NoInlining  | ClassCollectionsMarshallNoInlining  | 100000 | 2,859.6 μs |  3.16 μs |  2.47 μs |      62 B |       2 B |
| ClassCollectionsMarshall15NoInlining  | ClassCollectionsMarshallNoInlining  | 100000 | 3,824.1 μs |  7.08 μs |  5.92 μs |      62 B |       2 B |
| ClassCollectionsMarshall20NoInlining  | ClassCollectionsMarshallNoInlining  | 100000 | 4,160.8 μs | 14.92 μs | 13.23 μs |      62 B |       3 B |
| ClassCollectionsMarshall25NoInlining  | ClassCollectionsMarshallNoInlining  | 100000 | 4,669.4 μs | 11.98 μs | 10.00 μs |      62 B |       3 B |
| Class1NoInlining                      | ClassNoInlining                     | 100000 | 1,922.6 μs |  1.97 μs |  1.75 μs |      76 B |       2 B |
| Class5NoInlining                      | ClassNoInlining                     | 100000 | 2,579.2 μs | 24.97 μs | 23.36 μs |      76 B |       2 B |
| Class10NoInlining                     | ClassNoInlining                     | 100000 | 3,086.8 μs |  3.21 μs |  2.68 μs |      76 B |       2 B |
| Class15NoInlining                     | ClassNoInlining                     | 100000 | 3,930.5 μs |  9.01 μs |  7.53 μs |      76 B |       3 B |
| Class20NoInlining                     | ClassNoInlining                     | 100000 | 4,410.6 μs |  3.82 μs |  3.57 μs |      76 B |       3 B |
| Class25NoInlining                     | ClassNoInlining                     | 100000 | 4,756.2 μs |  3.84 μs |  3.40 μs |      76 B |       3 B |
| Struct1                               | Struct                              | 100000 | 1,293.2 μs | 24.72 μs | 23.12 μs |      89 B |       1 B |
| Struct5                               | Struct                              | 100000 | 1,502.9 μs | 27.21 μs | 25.45 μs |     149 B |       1 B |
| Struct10                              | Struct                              | 100000 | 1,577.0 μs |  6.96 μs |  6.51 μs |     229 B |       1 B |
| Struct15                              | Struct                              | 100000 | 2,439.7 μs | 16.20 μs | 15.15 μs |     346 B |       2 B |
| Struct20                              | Struct                              | 100000 | 3,087.8 μs | 32.46 μs | 27.11 μs |     317 B |       2 B |
| Struct25                              | Struct                              | 100000 | 3,415.5 μs | 27.10 μs | 25.35 μs |     360 B |       2 B |
| Struct1ColllectionsMarshal            | StructCollectionsMarshall           | 100000 |   867.3 μs |  6.38 μs |  5.96 μs |      54 B |         - |
| Struct5ColllectionsMarshal            | StructCollectionsMarshall           | 100000 |   825.4 μs |  0.94 μs |  0.88 μs |      66 B |         - |
| Struct10ColllectionsMarshal           | StructCollectionsMarshall           | 100000 | 1,132.3 μs |  3.42 μs |  3.20 μs |      81 B |       1 B |
| Struct15ColllectionsMarshal           | StructCollectionsMarshall           | 100000 | 1,257.4 μs |  1.16 μs |  0.97 μs |      96 B |       1 B |
| Struct20ColllectionsMarshal           | StructCollectionsMarshall           | 100000 | 1,539.7 μs | 22.26 μs | 20.82 μs |      60 B |       1 B |
| Struct25ColllectionsMarshal           | StructCollectionsMarshall           | 100000 | 1,706.0 μs |  4.31 μs |  3.60 μs |      60 B |       1 B |
| Struct1ColllectionsMarshalNoInlining  | StructCollectionsMarshallNoInlining | 100000 |   772.4 μs |  1.49 μs |  1.40 μs |      60 B |         - |
| Struct5ColllectionsMarshalNoInlining  | StructCollectionsMarshallNoInlining | 100000 |   922.0 μs |  1.57 μs |  1.47 μs |      60 B |         - |
| Struct10ColllectionsMarshalNoInlining | StructCollectionsMarshallNoInlining | 100000 | 1,179.4 μs |  1.32 μs |  1.17 μs |      60 B |       1 B |
| Struct15ColllectionsMarshalNoInlining | StructCollectionsMarshallNoInlining | 100000 | 1,328.8 μs |  7.39 μs |  6.55 μs |      60 B |       1 B |
| Struct20ColllectionsMarshalNoInlining | StructCollectionsMarshallNoInlining | 100000 | 1,541.5 μs |  5.28 μs |  4.68 μs |      60 B |       1 B |
| Struct25ColllectionsMarshalNoInlining | StructCollectionsMarshallNoInlining | 100000 | 1,738.5 μs |  1.71 μs |  1.51 μs |      60 B |       1 B |
| Struct1NoInlining                     | StructNoInlining                    | 100000 | 1,268.5 μs | 25.01 μs | 44.45 μs |     114 B |       1 B |
| Struct5NoInlining                     | StructNoInlining                    | 100000 | 1,825.5 μs |  3.43 μs |  2.86 μs |     180 B |       1 B |
| Struct10NoInlining                    | StructNoInlining                    | 100000 | 2,261.0 μs |  4.70 μs |  3.92 μs |     220 B |       2 B |
| Struct15NoInlining                    | StructNoInlining                    | 100000 | 3,142.6 μs |  7.57 μs |  6.71 μs |     261 B |       2 B |
| Struct20NoInlining                    | StructNoInlining                    | 100000 | 3,122.1 μs |  3.64 μs |  3.23 μs |     317 B |       2 B |
| Struct25NoInlining                    | StructNoInlining                    | 100000 | 3,402.6 μs | 26.94 μs | 25.20 μs |     360 B |       2 B |
