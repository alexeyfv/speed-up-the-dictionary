## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Class1()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             _class1[i].DoWork(i);
;             ^^^^^^^^^^^^^^^^^^^^^
;         return _class1;
;         ^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE3A0E910]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       lea       ecx,[rsi+rsi]
       add       [rax+8],ecx
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+8]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C649F0]
       int       3
; Total bytes of code 72
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Class5()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             _class5[i].DoWork(i);
;             ^^^^^^^^^^^^^^^^^^^^^
;         return _class5;
;         ^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+10]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE39EE9D0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       lea       ecx,[rsi+rsi]
       add       [rax+8],ecx
       add       [rax+0C],ecx
       add       [rax+10],ecx
       add       [rax+14],ecx
       add       [rax+18],ecx
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+10]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C2CA38]
       int       3
; Total bytes of code 84
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Class10()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             _class10[i].DoWork(i);
;             ^^^^^^^^^^^^^^^^^^^^^^
;         return _class10;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE39EEAC0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rax,[rax]
       lea       ecx,[rsi+rsi]
       add       [rax+8],ecx
       add       [rax+0C],ecx
       add       [rax+10],ecx
       add       [rax+14],ecx
       add       [rax+18],ecx
       add       [rax+1C],ecx
       add       [rax+20],ecx
       add       [rax+24],ecx
       add       [rax+28],ecx
       add       [rax+2C],ecx
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C2CD08]
       int       3
; Total bytes of code 99
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Class15()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             _class15[i].DoWork(i);
;             ^^^^^^^^^^^^^^^^^^^^^^
;         return _class15;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+20]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE39EEBB0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rcx,[rax]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE39EE880]; Benchmark.Class15.DoWork(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C2CA38]
       int       3
; Total bytes of code 76
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Class20()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             _class20[i].DoWork(i);
;             ^^^^^^^^^^^^^^^^^^^^^^
;         return _class20;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+28]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE3A1ECA0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rcx,[rax]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A1E970]; Benchmark.Class20.DoWork(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+28]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C5CD08]
       int       3
; Total bytes of code 76
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Class25()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             _class25[i].DoWork(i);
;             ^^^^^^^^^^^^^^^^^^^^^^
;         return _class25;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+30]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE3A0ED90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rcx,[rax]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A0EA60]; Benchmark.Class25.DoWork(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+30]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C4CA38]
       int       3
; Total bytes of code 76
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.ClassCollectionsMarshall1()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Class1 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class1, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWork(i);
;             ^^^^^^^^^^^^^^
;         return _class1;
;         ^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE39EE910]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       mov       rax,[rax]
       lea       ecx,[rsi+rsi]
       add       [rax+8],ecx
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+8]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 58
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.ClassCollectionsMarshall5()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Class5 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class5, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWork(i);
;             ^^^^^^^^^^^^^^
;         return _class5;
;         ^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+10]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE39FE9D0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       mov       rax,[rax]
       lea       ecx,[rsi+rsi]
       add       [rax+8],ecx
       add       [rax+0C],ecx
       add       [rax+10],ecx
       add       [rax+14],ecx
       add       [rax+18],ecx
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+10]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 70
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.ClassCollectionsMarshall10()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Class10 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class10, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWork(i);
;             ^^^^^^^^^^^^^^
;         return _class10;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+18]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A1EAC0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       mov       rax,[rax]
       lea       ecx,[rsi+rsi]
       add       [rax+8],ecx
       add       [rax+0C],ecx
       add       [rax+10],ecx
       add       [rax+14],ecx
       add       [rax+18],ecx
       add       [rax+1C],ecx
       add       [rax+20],ecx
       add       [rax+24],ecx
       add       [rax+28],ecx
       add       [rax+2C],ecx
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 85
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.ClassCollectionsMarshall15()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Class15 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class15, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWork(i);
;             ^^^^^^^^^^^^^^
;         return _class15;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+20]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A0EBB0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       mov       rcx,[rax]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A0E880]; Benchmark.Class15.DoWork(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 62
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.ClassCollectionsMarshall20()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Class20 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class20, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWork(i);
;             ^^^^^^^^^^^^^^
;         return _class20;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+28]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A0ECA0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       mov       rcx,[rax]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A0E970]; Benchmark.Class20.DoWork(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+28]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 62
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.ClassCollectionsMarshall25()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Class25 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class25, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWork(i);
;             ^^^^^^^^^^^^^^
;         return _class25;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+30]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE39FED90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       mov       rcx,[rax]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE39FEA60]; Benchmark.Class25.DoWork(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+30]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 62
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.ClassCollectionsMarshall1NoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Class1 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class1, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^
;         return _class1;
;         ^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A1E910]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       mov       rcx,[rax]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A1E5F8]; Benchmark.Class1.DoWorkNoInlining(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+8]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 62
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.ClassCollectionsMarshall5NoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Class5 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class5, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^
;         return _class5;
;         ^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+10]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A0E9D0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       mov       rcx,[rax]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A0E6B8]; Benchmark.Class5.DoWorkNoInlining(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+10]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 62
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.ClassCollectionsMarshall10NoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Class10 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class10, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^
;         return _class10;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+18]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE39EEAC0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       mov       rcx,[rax]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE39EE7A8]; Benchmark.Class10.DoWorkNoInlining(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 62
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.ClassCollectionsMarshall15NoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Class15 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class15, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^
;         return _class15;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+20]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A0EBB0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       mov       rcx,[rax]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A0E898]; Benchmark.Class15.DoWorkNoInlining(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 62
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.ClassCollectionsMarshall20NoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Class20 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class20, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^
;         return _class20;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+28]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A0ECA0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       mov       rcx,[rax]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A0E988]; Benchmark.Class20.DoWorkNoInlining(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+28]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 62
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.ClassCollectionsMarshall25NoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Class25 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class25, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^
;         return _class25;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+30]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE39EED90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       mov       rcx,[rax]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE39EEA78]; Benchmark.Class25.DoWorkNoInlining(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+30]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 62
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Class1NoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             _class1[i].DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return _class1;
;         ^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+8]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE3A0E910]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rcx,[rax]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A0E5F8]; Benchmark.Class1.DoWorkNoInlining(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+8]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C4CD08]
       int       3
; Total bytes of code 76
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Class5NoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             _class5[i].DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return _class5;
;         ^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+10]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE39EE9D0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rcx,[rax]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE39EE6B8]; Benchmark.Class5.DoWorkNoInlining(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+10]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C2CD08]
       int       3
; Total bytes of code 76
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Class10NoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             _class10[i].DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return _class10;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE39DEAC0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rcx,[rax]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE39DE7A8]; Benchmark.Class10.DoWorkNoInlining(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C1CD08]
       int       3
; Total bytes of code 76
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Class15NoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             _class15[i].DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return _class15;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+20]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE39DEBB0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rcx,[rax]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE39DE898]; Benchmark.Class15.DoWorkNoInlining(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C1CA38]
       int       3
; Total bytes of code 76
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Class20NoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             _class20[i].DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return _class20;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+28]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE39DECA0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rcx,[rax]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE39DE988]; Benchmark.Class20.DoWorkNoInlining(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+28]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C1CA38]
       int       3
; Total bytes of code 76
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Class25NoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             _class25[i].DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         return _class25;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+30]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE39FED90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       rcx,[rax]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE39FEA78]; Benchmark.Class25.DoWorkNoInlining(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+30]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C3CD08]
       int       3
; Total bytes of code 76
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct1()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             var obj = _struct1[i];
;             ^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWork(i);
;             ^^^^^^^^^^^^^^
;             _struct1[i] = obj;
;             ^^^^^^^^^^^^^^^^^^
;         return _struct1;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+38]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE39FE8F8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct1, speed-up-dictionary]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       ecx,[rax]
       lea       r8d,[rcx+rsi*2]
       mov       rcx,[rbx+38]
       cmp       [rcx],cl
       mov       edx,esi
       mov       r9d,1
       call      qword ptr [7FFEE39FE928]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct1, speed-up-dictionary]].TryInsert(Int32, Benchmark.Struct1, System.Collections.Generic.InsertionBehavior)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+38]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C3DEF0]
       int       3
; Total bytes of code 89
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct5()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             var obj = _struct5[i];
;             ^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWork(i);
;             ^^^^^^^^^^^^^^
;             _struct5[i] = obj;
;             ^^^^^^^^^^^^^^^^^^
;         return _struct5;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+40]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE39DE9B8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct5, speed-up-dictionary]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       r8d,[rax]
       mov       ecx,[rax+4]
       mov       edx,[rax+8]
       mov       r9d,[rax+0C]
       mov       eax,[rax+10]
       lea       r10d,[rsi+rsi]
       add       r8d,r10d
       add       ecx,r10d
       add       edx,r10d
       add       r9d,r10d
       add       eax,r10d
       mov       r10,[rbx+40]
       mov       [rsp+20],r8d
       mov       [rsp+24],ecx
       mov       [rsp+28],edx
       mov       [rsp+2C],r9d
       mov       [rsp+30],eax
       cmp       [r10],r10b
       lea       r8,[rsp+20]
       mov       rcx,r10
       mov       edx,esi
       mov       r9d,1
       call      qword ptr [7FFEE39DE9E8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct5, speed-up-dictionary]].TryInsert(Int32, Benchmark.Struct5, System.Collections.Generic.InsertionBehavior)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+40]
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C1CA38]
       int       3
; Total bytes of code 149
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct10()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             var obj = _struct10[i];
;             ^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWork(i);
;             ^^^^^^^^^^^^^^
;             _struct10[i] = obj;
;             ^^^^^^^^^^^^^^^^^^^
;         return _struct10;
;         ^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       near ptr M00_L01
M00_L00:
       mov       rcx,[rbx+48]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE3A1EAA8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct10, speed-up-dictionary]].FindValue(Int32)
       test      rax,rax
       je        near ptr M00_L02
       mov       r8d,[rax]
       mov       ecx,[rax+4]
       mov       edx,[rax+8]
       mov       r9d,[rax+0C]
       mov       r10d,[rax+10]
       mov       r11d,[rax+14]
       mov       edi,[rax+18]
       mov       ebp,[rax+1C]
       mov       r14d,[rax+20]
       mov       eax,[rax+24]
       lea       r15d,[rsi+rsi]
       add       r8d,r15d
       add       ecx,r15d
       add       edx,r15d
       add       r9d,r15d
       add       r10d,r15d
       add       r11d,r15d
       add       edi,r15d
       add       ebp,r15d
       add       r14d,r15d
       add       eax,r15d
       mov       r15,[rbx+48]
       mov       [rsp+20],r8d
       mov       [rsp+24],ecx
       mov       [rsp+28],edx
       mov       [rsp+2C],r9d
       mov       [rsp+30],r10d
       mov       [rsp+34],r11d
       mov       [rsp+38],edi
       mov       [rsp+3C],ebp
       mov       [rsp+40],r14d
       mov       [rsp+44],eax
       cmp       [r15],r15b
       lea       r8,[rsp+20]
       mov       rcx,r15
       mov       edx,esi
       mov       r9d,1
       call      qword ptr [7FFEE3A1EAD8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct10, speed-up-dictionary]].TryInsert(Int32, Benchmark.Struct10, System.Collections.Generic.InsertionBehavior)
       inc       esi
       cmp       esi,[rbx+68]
       jl        near ptr M00_L00
M00_L01:
       mov       rax,[rbx+48]
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C5CA38]
       int       3
; Total bytes of code 229
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct15()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             var obj = _struct15[i];
;             ^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWork(i);
;             ^^^^^^^^^^^^^^
;             _struct15[i] = obj;
;             ^^^^^^^^^^^^^^^^^^^
;         return _struct15;
;         ^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       near ptr M00_L01
M00_L00:
       mov       rcx,[rbx+50]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE3A1EB98]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct15, speed-up-dictionary]].FindValue(Int32)
       test      rax,rax
       je        near ptr M00_L02
       mov       r8d,[rax]
       mov       ecx,[rax+4]
       mov       edx,[rax+8]
       mov       r9d,[rax+0C]
       mov       r10d,[rax+10]
       mov       r11d,[rax+14]
       mov       edi,[rax+18]
       mov       ebp,[rax+1C]
       mov       r14d,[rax+20]
       mov       r15d,[rax+24]
       mov       r13d,[rax+28]
       mov       r12d,[rax+2C]
       mov       [rsp+28],r12d
       mov       r12d,[rax+30]
       mov       [rsp+24],r12d
       mov       r12d,[rax+34]
       mov       eax,[rax+38]
       mov       [rsp+20],eax
       lea       eax,[rsi+rsi]
       add       r8d,eax
       add       ecx,eax
       add       edx,eax
       add       r9d,eax
       add       r10d,eax
       add       r11d,eax
       add       edi,eax
       add       ebp,eax
       add       r14d,eax
       add       r15d,eax
       add       r13d,eax
       mov       [rsp+34],r13d
       mov       r13d,eax
       add       r13d,[rsp+28]
       mov       [rsp+30],r13d
       mov       r13d,eax
       add       r13d,[rsp+24]
       add       r12d,eax
       add       eax,[rsp+20]
       mov       [rsp+2C],eax
       mov       rax,[rbx+50]
       mov       [rsp+38],r8d
       mov       [rsp+3C],ecx
       mov       [rsp+40],edx
       mov       [rsp+44],r9d
       mov       [rsp+48],r10d
       mov       [rsp+4C],r11d
       mov       [rsp+50],edi
       mov       [rsp+54],ebp
       mov       [rsp+58],r14d
       mov       [rsp+5C],r15d
       mov       r8d,[rsp+34]
       mov       [rsp+60],r8d
       mov       r8d,[rsp+30]
       mov       [rsp+64],r8d
       mov       [rsp+68],r13d
       mov       [rsp+6C],r12d
       mov       r8d,[rsp+2C]
       mov       [rsp+70],r8d
       cmp       [rax],al
       lea       r8,[rsp+38]
       mov       rcx,rax
       mov       edx,esi
       mov       r9d,1
       call      qword ptr [7FFEE3A1EBC8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct15, speed-up-dictionary]].TryInsert(Int32, Benchmark.Struct15, System.Collections.Generic.InsertionBehavior)
       inc       esi
       cmp       esi,[rbx+68]
       jl        near ptr M00_L00
M00_L01:
       mov       rax,[rbx+50]
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C5CD08]
       int       3
; Total bytes of code 346
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct20()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             var obj = _struct20[i];
;             ^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWork(i);
;             ^^^^^^^^^^^^^^
;             _struct20[i] = obj;
;             ^^^^^^^^^^^^^^^^^^^
;         return _struct20;
;         ^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,118
       vzeroupper
       xor       eax,eax
       mov       [rsp+0C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0D0],xmm4
       vmovdqa   xmmword ptr [rsp+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+100],xmm4
       mov       [rsp+110],rax
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       near ptr M00_L01
M00_L00:
       mov       rcx,[rbx+58]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE39FEC88]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct20, speed-up-dictionary]].FindValue(Int32)
       test      rax,rax
       je        near ptr M00_L02
       vmovdqu   ymm0,ymmword ptr [rax]
       vmovdqu   ymmword ptr [rsp+78],ymm0
       vmovdqu   ymm0,ymmword ptr [rax+20]
       vmovdqu   ymmword ptr [rsp+98],ymm0
       vmovdqu   xmm0,xmmword ptr [rax+40]
       vmovdqu   xmmword ptr [rsp+0B8],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+78]
       vmovdqu   ymmword ptr [rsp+0C8],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+98]
       vmovdqu   ymmword ptr [rsp+0E8],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0B8]
       vmovdqu   xmmword ptr [rsp+108],xmm0
       lea       rcx,[rsp+0C8]
       mov       edx,esi
       call      qword ptr [7FFEE39FE970]; Benchmark.Struct20.DoWork(Int32)
       mov       rcx,[rbx+58]
       vmovdqu   ymm0,ymmword ptr [rsp+0C8]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0E8]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+108]
       vmovdqu   xmmword ptr [rsp+68],xmm0
       cmp       [rcx],cl
       lea       r8,[rsp+28]
       mov       edx,esi
       mov       r9d,1
       call      qword ptr [7FFEE39FECB8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct20, speed-up-dictionary]].TryInsert(Int32, Benchmark.Struct20, System.Collections.Generic.InsertionBehavior)
       inc       esi
       cmp       esi,[rbx+68]
       jl        near ptr M00_L00
M00_L01:
       mov       rax,[rbx+58]
       add       rsp,118
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C3CD08]
       int       3
; Total bytes of code 317
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct25()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             var obj = _struct25[i];
;             ^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWork(i);
;             ^^^^^^^^^^^^^^
;             _struct25[i] = obj;
;             ^^^^^^^^^^^^^^^^^^^
;         return _struct25;
;         ^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,158
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+150],xmm4
       vmovdqa   xmmword ptr [rsp+rax+160],xmm4
       vmovdqa   xmmword ptr [rsp+rax+170],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+150],rax
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       near ptr M00_L02
M00_L01:
       mov       rcx,[rbx+60]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE3A1ED78]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct25, speed-up-dictionary]].FindValue(Int32)
       test      rax,rax
       je        near ptr M00_L03
       vmovdqu   ymm0,ymmword ptr [rax]
       vmovdqu   ymmword ptr [rsp+88],ymm0
       vmovdqu   ymm0,ymmword ptr [rax+20]
       vmovdqu   ymmword ptr [rsp+0A8],ymm0
       vmovdqu   ymm0,ymmword ptr [rax+40]
       vmovdqu   ymmword ptr [rsp+0C8],ymm0
       mov       ecx,[rax+60]
       mov       [rsp+0E8],ecx
       vmovdqu   ymm0,ymmword ptr [rsp+88]
       vmovdqu   ymmword ptr [rsp+0F0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A8]
       vmovdqu   ymmword ptr [rsp+110],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0C8]
       vmovdqu   ymmword ptr [rsp+130],ymm0
       mov       ecx,[rsp+0E8]
       mov       [rsp+150],ecx
       lea       rcx,[rsp+0F0]
       mov       edx,esi
       call      qword ptr [7FFEE3A1EA60]; Benchmark.Struct25.DoWork(Int32)
       mov       rcx,[rbx+60]
       vmovdqu   ymm0,ymmword ptr [rsp+0F0]
       vmovdqu   ymmword ptr [rsp+20],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+110]
       vmovdqu   ymmword ptr [rsp+40],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+130]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       mov       r8d,[rsp+150]
       mov       [rsp+80],r8d
       cmp       [rcx],cl
       lea       r8,[rsp+20]
       mov       edx,esi
       mov       r9d,1
       call      qword ptr [7FFEE3A1EDA8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct25, speed-up-dictionary]].TryInsert(Int32, Benchmark.Struct25, System.Collections.Generic.InsertionBehavior)
       inc       esi
       cmp       esi,[rbx+68]
       jl        near ptr M00_L01
M00_L02:
       mov       rax,[rbx+60]
       add       rsp,158
       pop       rbx
       pop       rsi
       ret
M00_L03:
       mov       ecx,esi
       call      qword ptr [7FFEE3C5CA38]
       int       3
; Total bytes of code 360
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct1ColllectionsMarshal()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Struct1 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct1, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWork(i);
;             ^^^^^^^^^^^^^^
;         return _struct1;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+38]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A0E8F8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct1, speed-up-dictionary]].FindValue(Int32)
       lea       ecx,[rsi+rsi]
       add       [rax],ecx
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+38]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 54
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct5ColllectionsMarshal()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Struct5 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct5, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWork(i);
;             ^^^^^^^^^^^^^^
;         return _struct5;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+40]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE39EE9B8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct5, speed-up-dictionary]].FindValue(Int32)
       lea       ecx,[rsi+rsi]
       add       [rax],ecx
       add       [rax+4],ecx
       add       [rax+8],ecx
       add       [rax+0C],ecx
       add       [rax+10],ecx
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+40]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 66
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct10ColllectionsMarshal()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Struct10 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct10, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWork(i);
;             ^^^^^^^^^^^^^^
;         return _struct10;
;         ^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+48]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE39FEAA8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct10, speed-up-dictionary]].FindValue(Int32)
       lea       ecx,[rsi+rsi]
       add       [rax],ecx
       add       [rax+4],ecx
       add       [rax+8],ecx
       add       [rax+0C],ecx
       add       [rax+10],ecx
       add       [rax+14],ecx
       add       [rax+18],ecx
       add       [rax+1C],ecx
       add       [rax+20],ecx
       add       [rax+24],ecx
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+48]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 81
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct15ColllectionsMarshal()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Struct15 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct15, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWork(i);
;             ^^^^^^^^^^^^^^
;         return _struct15;
;         ^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+50]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A1EB98]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct15, speed-up-dictionary]].FindValue(Int32)
       lea       ecx,[rsi+rsi]
       add       [rax],ecx
       add       [rax+4],ecx
       add       [rax+8],ecx
       add       [rax+0C],ecx
       add       [rax+10],ecx
       add       [rax+14],ecx
       add       [rax+18],ecx
       add       [rax+1C],ecx
       add       [rax+20],ecx
       add       [rax+24],ecx
       add       [rax+28],ecx
       add       [rax+2C],ecx
       add       [rax+30],ecx
       add       [rax+34],ecx
       add       [rax+38],ecx
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+50]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 96
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct20ColllectionsMarshal()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Struct20 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct20, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWork(i);
;             ^^^^^^^^^^^^^^
;         return _struct20;
;         ^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+58]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE39EEC88]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct20, speed-up-dictionary]].FindValue(Int32)
       mov       rcx,rax
       mov       edx,esi
       call      qword ptr [7FFEE39EE970]; Benchmark.Struct20.DoWork(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct25ColllectionsMarshal()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Struct25 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct25, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWork(i);
;             ^^^^^^^^^^^^^^
;         return _struct25;
;         ^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+60]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A0ED78]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct25, speed-up-dictionary]].FindValue(Int32)
       mov       rcx,rax
       mov       edx,esi
       call      qword ptr [7FFEE3A0EA60]; Benchmark.Struct25.DoWork(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+60]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct1ColllectionsMarshalNoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Struct1 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct1, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^
;         return _struct1;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+38]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A0E8F8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct1, speed-up-dictionary]].FindValue(Int32)
       mov       rcx,rax
       mov       edx,esi
       call      qword ptr [7FFEE3A0E5F8]; Benchmark.Struct1.DoWorkNoInlining(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+38]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct5ColllectionsMarshalNoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Struct5 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct5, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^
;         return _struct5;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+40]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE39FE9B8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct5, speed-up-dictionary]].FindValue(Int32)
       mov       rcx,rax
       mov       edx,esi
       call      qword ptr [7FFEE39FE6B8]; Benchmark.Struct5.DoWorkNoInlining(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+40]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct10ColllectionsMarshalNoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Struct10 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct10, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^
;         return _struct10;
;         ^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+48]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A0EAA8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct10, speed-up-dictionary]].FindValue(Int32)
       mov       rcx,rax
       mov       edx,esi
       call      qword ptr [7FFEE3A0E7A8]; Benchmark.Struct10.DoWorkNoInlining(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+48]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct15ColllectionsMarshalNoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Struct15 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct15, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^
;         return _struct15;
;         ^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+50]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A0EB98]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct15, speed-up-dictionary]].FindValue(Int32)
       mov       rcx,rax
       mov       edx,esi
       call      qword ptr [7FFEE3A0E898]; Benchmark.Struct15.DoWorkNoInlining(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+50]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct20ColllectionsMarshalNoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Struct20 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct20, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^
;         return _struct20;
;         ^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+58]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE3A1EC88]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct20, speed-up-dictionary]].FindValue(Int32)
       mov       rcx,rax
       mov       edx,esi
       call      qword ptr [7FFEE3A1E988]; Benchmark.Struct20.DoWorkNoInlining(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct25ColllectionsMarshalNoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             ref Struct25 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct25, i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^
;         return _struct25;
;         ^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+60]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFEE39FED78]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct25, speed-up-dictionary]].FindValue(Int32)
       mov       rcx,rax
       mov       edx,esi
       call      qword ptr [7FFEE39FEA78]; Benchmark.Struct25.DoWorkNoInlining(Int32)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+60]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct1NoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             var obj = _struct1[i];
;             ^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^
;             _struct1[i] = obj;
;             ^^^^^^^^^^^^^^^^^^
;         return _struct1;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+38]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE39FE8F8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct1, speed-up-dictionary]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       mov       ecx,[rax]
       mov       [rsp+20],ecx
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      qword ptr [7FFEE39FE5F8]; Benchmark.Struct1.DoWorkNoInlining(Int32)
       mov       rcx,[rbx+38]
       mov       r8d,[rsp+20]
       cmp       [rcx],cl
       mov       edx,esi
       mov       r9d,1
       call      qword ptr [7FFEE39FE928]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct1, speed-up-dictionary]].TryInsert(Int32, Benchmark.Struct1, System.Collections.Generic.InsertionBehavior)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+38]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C3DEF0]
       int       3
; Total bytes of code 114
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct5NoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             var obj = _struct5[i];
;             ^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^
;             _struct5[i] = obj;
;             ^^^^^^^^^^^^^^^^^^
;         return _struct5;
;         ^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rbx+40]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE3A1E9B8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct5, speed-up-dictionary]].FindValue(Int32)
       test      rax,rax
       je        short M00_L02
       vmovdqu   xmm0,xmmword ptr [rax]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       ecx,[rax+10]
       mov       [rsp+48],ecx
       vmovdqu   xmm0,xmmword ptr [rsp+38]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       mov       ecx,[rsp+48]
       mov       [rsp+60],ecx
       lea       rcx,[rsp+50]
       mov       edx,esi
       call      qword ptr [7FFEE3A1E6B8]; Benchmark.Struct5.DoWorkNoInlining(Int32)
       mov       rcx,[rbx+40]
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       mov       r8d,[rsp+60]
       mov       [rsp+30],r8d
       cmp       [rcx],cl
       lea       r8,[rsp+20]
       mov       edx,esi
       mov       r9d,1
       call      qword ptr [7FFEE3A1E9E8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct5, speed-up-dictionary]].TryInsert(Int32, Benchmark.Struct5, System.Collections.Generic.InsertionBehavior)
       inc       esi
       cmp       esi,[rbx+68]
       jl        short M00_L00
M00_L01:
       mov       rax,[rbx+40]
       add       rsp,68
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C5CD08]
       int       3
; Total bytes of code 180
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct10NoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             var obj = _struct10[i];
;             ^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^
;             _struct10[i] = obj;
;             ^^^^^^^^^^^^^^^^^^^
;         return _struct10;
;         ^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       vmovdqa   xmmword ptr [rsp+80],xmm4
       xor       eax,eax
       mov       [rsp+90],rax
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       near ptr M00_L01
M00_L00:
       mov       rcx,[rbx+48]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE39EEAA8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct10, speed-up-dictionary]].FindValue(Int32)
       test      rax,rax
       je        near ptr M00_L02
       vmovdqu   ymm0,ymmword ptr [rax]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       mov       rcx,[rax+20]
       mov       [rsp+68],rcx
       vmovdqu   ymm0,ymmword ptr [rsp+48]
       vmovdqu   ymmword ptr [rsp+70],ymm0
       mov       rcx,[rsp+68]
       mov       [rsp+90],rcx
       lea       rcx,[rsp+70]
       mov       edx,esi
       call      qword ptr [7FFEE39EE7A8]; Benchmark.Struct10.DoWorkNoInlining(Int32)
       mov       rcx,[rbx+48]
       vmovdqu   ymm0,ymmword ptr [rsp+70]
       vmovdqu   ymmword ptr [rsp+20],ymm0
       mov       r8,[rsp+90]
       mov       [rsp+40],r8
       cmp       [rcx],cl
       lea       r8,[rsp+20]
       mov       edx,esi
       mov       r9d,1
       call      qword ptr [7FFEE39EEAD8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct10, speed-up-dictionary]].TryInsert(Int32, Benchmark.Struct10, System.Collections.Generic.InsertionBehavior)
       inc       esi
       cmp       esi,[rbx+68]
       jl        near ptr M00_L00
M00_L01:
       mov       rax,[rbx+48]
       add       rsp,98
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C2CD08]
       int       3
; Total bytes of code 220
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct15NoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             var obj = _struct15[i];
;             ^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^
;             _struct15[i] = obj;
;             ^^^^^^^^^^^^^^^^^^^
;         return _struct15;
;         ^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,0E8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0A8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       vmovdqa   xmmword ptr [rsp+0D0],xmm4
       mov       [rsp+0E0],rax
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       near ptr M00_L01
M00_L00:
       mov       rcx,[rbx+50]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE39DEB98]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct15, speed-up-dictionary]].FindValue(Int32)
       test      rax,rax
       je        near ptr M00_L02
       vmovdqu   ymm0,ymmword ptr [rax]
       vmovdqu   ymmword ptr [rsp+68],ymm0
       vmovdqu   ymm0,ymmword ptr [rax+1C]
       vmovdqu   ymmword ptr [rsp+84],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+68]
       vmovdqu   ymmword ptr [rsp+0A8],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+84]
       vmovdqu   ymmword ptr [rsp+0C4],ymm0
       lea       rcx,[rsp+0A8]
       mov       edx,esi
       call      qword ptr [7FFEE39DE898]; Benchmark.Struct15.DoWorkNoInlining(Int32)
       mov       rcx,[rbx+50]
       vmovdqu   ymm0,ymmword ptr [rsp+0A8]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0C4]
       vmovdqu   ymmword ptr [rsp+44],ymm0
       cmp       [rcx],cl
       lea       r8,[rsp+28]
       mov       edx,esi
       mov       r9d,1
       call      qword ptr [7FFEE39DEBC8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct15, speed-up-dictionary]].TryInsert(Int32, Benchmark.Struct15, System.Collections.Generic.InsertionBehavior)
       inc       esi
       cmp       esi,[rbx+68]
       jl        near ptr M00_L00
M00_L01:
       mov       rax,[rbx+50]
       add       rsp,0E8
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C1CD08]
       int       3
; Total bytes of code 261
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct20NoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             var obj = _struct20[i];
;             ^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^
;             _struct20[i] = obj;
;             ^^^^^^^^^^^^^^^^^^^
;         return _struct20;
;         ^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,118
       vzeroupper
       xor       eax,eax
       mov       [rsp+0C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0D0],xmm4
       vmovdqa   xmmword ptr [rsp+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+100],xmm4
       mov       [rsp+110],rax
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       near ptr M00_L01
M00_L00:
       mov       rcx,[rbx+58]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE39EEC88]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct20, speed-up-dictionary]].FindValue(Int32)
       test      rax,rax
       je        near ptr M00_L02
       vmovdqu   ymm0,ymmword ptr [rax]
       vmovdqu   ymmword ptr [rsp+78],ymm0
       vmovdqu   ymm0,ymmword ptr [rax+20]
       vmovdqu   ymmword ptr [rsp+98],ymm0
       vmovdqu   xmm0,xmmword ptr [rax+40]
       vmovdqu   xmmword ptr [rsp+0B8],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+78]
       vmovdqu   ymmword ptr [rsp+0C8],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+98]
       vmovdqu   ymmword ptr [rsp+0E8],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0B8]
       vmovdqu   xmmword ptr [rsp+108],xmm0
       lea       rcx,[rsp+0C8]
       mov       edx,esi
       call      qword ptr [7FFEE39EE988]; Benchmark.Struct20.DoWorkNoInlining(Int32)
       mov       rcx,[rbx+58]
       vmovdqu   ymm0,ymmword ptr [rsp+0C8]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0E8]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+108]
       vmovdqu   xmmword ptr [rsp+68],xmm0
       cmp       [rcx],cl
       lea       r8,[rsp+28]
       mov       edx,esi
       mov       r9d,1
       call      qword ptr [7FFEE39EECB8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct20, speed-up-dictionary]].TryInsert(Int32, Benchmark.Struct20, System.Collections.Generic.InsertionBehavior)
       inc       esi
       cmp       esi,[rbx+68]
       jl        near ptr M00_L00
M00_L01:
       mov       rax,[rbx+58]
       add       rsp,118
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,esi
       call      qword ptr [7FFEE3C2CA38]
       int       3
; Total bytes of code 317
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.DictionaryBenchmark.Struct25NoInlining()
;         for (int i = 0; i < Length; i++)
;              ^^^^^^^^^
;             var obj = _struct25[i];
;             ^^^^^^^^^^^^^^^^^^^^^^^
;             obj.DoWorkNoInlining(i);
;             ^^^^^^^^^^^^^^^^^^^^^^^^
;             _struct25[i] = obj;
;             ^^^^^^^^^^^^^^^^^^^
;         return _struct25;
;         ^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,158
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+150],xmm4
       vmovdqa   xmmword ptr [rsp+rax+160],xmm4
       vmovdqa   xmmword ptr [rsp+rax+170],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+150],rax
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+68],0
       jle       near ptr M00_L02
M00_L01:
       mov       rcx,[rbx+60]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7FFEE39FED78]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct25, speed-up-dictionary]].FindValue(Int32)
       test      rax,rax
       je        near ptr M00_L03
       vmovdqu   ymm0,ymmword ptr [rax]
       vmovdqu   ymmword ptr [rsp+88],ymm0
       vmovdqu   ymm0,ymmword ptr [rax+20]
       vmovdqu   ymmword ptr [rsp+0A8],ymm0
       vmovdqu   ymm0,ymmword ptr [rax+40]
       vmovdqu   ymmword ptr [rsp+0C8],ymm0
       mov       ecx,[rax+60]
       mov       [rsp+0E8],ecx
       vmovdqu   ymm0,ymmword ptr [rsp+88]
       vmovdqu   ymmword ptr [rsp+0F0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A8]
       vmovdqu   ymmword ptr [rsp+110],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0C8]
       vmovdqu   ymmword ptr [rsp+130],ymm0
       mov       ecx,[rsp+0E8]
       mov       [rsp+150],ecx
       lea       rcx,[rsp+0F0]
       mov       edx,esi
       call      qword ptr [7FFEE39FEA78]; Benchmark.Struct25.DoWorkNoInlining(Int32)
       mov       rcx,[rbx+60]
       vmovdqu   ymm0,ymmword ptr [rsp+0F0]
       vmovdqu   ymmword ptr [rsp+20],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+110]
       vmovdqu   ymmword ptr [rsp+40],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+130]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       mov       r8d,[rsp+150]
       mov       [rsp+80],r8d
       cmp       [rcx],cl
       lea       r8,[rsp+20]
       mov       edx,esi
       mov       r9d,1
       call      qword ptr [7FFEE39FEDA8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[Benchmark.Struct25, speed-up-dictionary]].TryInsert(Int32, Benchmark.Struct25, System.Collections.Generic.InsertionBehavior)
       inc       esi
       cmp       esi,[rbx+68]
       jl        near ptr M00_L01
M00_L02:
       mov       rax,[rbx+60]
       add       rsp,158
       pop       rbx
       pop       rsi
       ret
M00_L03:
       mov       ecx,esi
       call      qword ptr [7FFEE3C3CD08]
       int       3
; Total bytes of code 360
```

