using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace Benchmark;

[CategoriesColumn]
[MemoryDiagnoser]
[SimpleJob(iterationCount: 10)]
[HardwareCounters(HardwareCounter.BranchInstructions, HardwareCounter.BranchMispredictions, HardwareCounter.CacheMisses)]
[DisassemblyDiagnoser(printSource: true, maxDepth: 0, exportCombinedDisassemblyReport: true)]
public class DictionaryBenchmark
{
    [Params(100_000)]
    public int Length { get; set; }

    Dictionary<int, Class1> _class1 = [];
    Dictionary<int, Class5> _class5 = [];
    Dictionary<int, Class10> _class10 = [];
    Dictionary<int, Class15> _class15 = [];
    Dictionary<int, Class20> _class20 = [];
    Dictionary<int, Class25> _class25 = [];
    Dictionary<int, Struct1> _struct1 = [];
    Dictionary<int, Struct5> _struct5 = [];
    Dictionary<int, Struct10> _struct10 = [];
    Dictionary<int, Struct15> _struct15 = [];
    Dictionary<int, Struct20> _struct20 = [];
    Dictionary<int, Struct25> _struct25 = [];

    [GlobalSetup]
    public void Setup()
    {
        _class1 = new(Length);
        _class5 = new(Length);
        _class10 = new(Length);
        _class15 = new(Length);
        _class20 = new(Length);
        _class25 = new(Length);

        _struct1 = new(Length);
        _struct5 = new(Length);
        _struct10 = new(Length);
        _struct15 = new(Length);
        _struct20 = new(Length);
        _struct25 = new(Length);
        for (var i = 0; i < Length; i++)
        {
            _class1.Add(i, new Class1());
            _class5.Add(i, new Class5());
            _class10.Add(i, new Class10());
            _class15.Add(i, new Class15());
            _class20.Add(i, new Class20());
            _class25.Add(i, new Class25());

            _struct1.Add(i, new Struct1());
            _struct5.Add(i, new Struct5());
            _struct10.Add(i, new Struct10());
            _struct15.Add(i, new Struct15());
            _struct20.Add(i, new Struct20());
            _struct25.Add(i, new Struct25());
        }
    }

    #region Struct

    [Benchmark]
    [BenchmarkCategory("Struct")]
    public Dictionary<int, Struct1> Struct1()
    {
        for (int i = 0; i < Length; i++)
        {
            var obj = _struct1[i];
            obj.DoWork(i);
            _struct1[i] = obj;
        }

        return _struct1;
    }

    [Benchmark]
    [BenchmarkCategory("Struct")]
    public Dictionary<int, Struct5> Struct5()
    {
        for (int i = 0; i < Length; i++)
        {
            var obj = _struct5[i];
            obj.DoWork(i);
            _struct5[i] = obj;
        }

        return _struct5;
    }

    [Benchmark]
    [BenchmarkCategory("Struct")]
    public Dictionary<int, Struct10> Struct10()
    {
        for (int i = 0; i < Length; i++)
        {
            var obj = _struct10[i];
            obj.DoWork(i);
            _struct10[i] = obj;
        }

        return _struct10;
    }

    [Benchmark]
    [BenchmarkCategory("Struct")]
    public Dictionary<int, Struct15> Struct15()
    {
        for (int i = 0; i < Length; i++)
        {
            var obj = _struct15[i];
            obj.DoWork(i);
            _struct15[i] = obj;
        }

        return _struct15;
    }

    [Benchmark]
    [BenchmarkCategory("Struct")]
    public Dictionary<int, Struct20> Struct20()
    {
        for (int i = 0; i < Length; i++)
        {
            var obj = _struct20[i];
            obj.DoWork(i);
            _struct20[i] = obj;
        }

        return _struct20;
    }

    [Benchmark]
    [BenchmarkCategory("Struct")]
    public Dictionary<int, Struct25> Struct25()
    {
        for (int i = 0; i < Length; i++)
        {
            var obj = _struct25[i];
            obj.DoWork(i);
            _struct25[i] = obj;
        }

        return _struct25;
    }

    #endregion

    // #region Struct No Inlining

    // [Benchmark]
    // [BenchmarkCategory("StructNoInlining")]
    // public Dictionary<int, Struct1> Struct1NoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         var obj = _struct1[i];
    //         obj.DoWorkNoInlining(i);
    //         _struct1[i] = obj;
    //     }

    //     return _struct1;
    // }

    // [Benchmark]
    // [BenchmarkCategory("StructNoInlining")]
    // public Dictionary<int, Struct5> Struct5NoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         var obj = _struct5[i];
    //         obj.DoWorkNoInlining(i);
    //         _struct5[i] = obj;
    //     }

    //     return _struct5;
    // }

    // [Benchmark]
    // [BenchmarkCategory("StructNoInlining")]
    // public Dictionary<int, Struct10> Struct10NoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         var obj = _struct10[i];
    //         obj.DoWorkNoInlining(i);
    //         _struct10[i] = obj;
    //     }

    //     return _struct10;
    // }

    // [Benchmark]
    // [BenchmarkCategory("StructNoInlining")]
    // public Dictionary<int, Struct15> Struct15NoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         var obj = _struct15[i];
    //         obj.DoWorkNoInlining(i);
    //         _struct15[i] = obj;
    //     }

    //     return _struct15;
    // }

    // [Benchmark]
    // [BenchmarkCategory("StructNoInlining")]
    // public Dictionary<int, Struct20> Struct20NoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         var obj = _struct20[i];
    //         obj.DoWorkNoInlining(i);
    //         _struct20[i] = obj;
    //     }

    //     return _struct20;
    // }

    // [Benchmark]
    // [BenchmarkCategory("StructNoInlining")]
    // public Dictionary<int, Struct25> Struct25NoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         var obj = _struct25[i];
    //         obj.DoWorkNoInlining(i);
    //         _struct25[i] = obj;
    //     }

    //     return _struct25;
    // }

    // #endregion

    // #region Struct CollectionsMarshall


    // [Benchmark]
    // [BenchmarkCategory("StructCollectionsMarshall")]
    // public Dictionary<int, Struct1> Struct1ColllectionsMarshal()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Struct1 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct1, i);
    //         obj.DoWork(i);
    //     }

    //     return _struct1;
    // }

    // [Benchmark]
    // [BenchmarkCategory("StructCollectionsMarshall")]
    // public Dictionary<int, Struct5> Struct5ColllectionsMarshal()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Struct5 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct5, i);
    //         obj.DoWork(i);
    //     }

    //     return _struct5;
    // }

    // [Benchmark]
    // [BenchmarkCategory("StructCollectionsMarshall")]
    // public Dictionary<int, Struct10> Struct10ColllectionsMarshal()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Struct10 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct10, i);
    //         obj.DoWork(i);
    //     }

    //     return _struct10;
    // }

    // [Benchmark]
    // [BenchmarkCategory("StructCollectionsMarshall")]
    // public Dictionary<int, Struct15> Struct15ColllectionsMarshal()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Struct15 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct15, i);
    //         obj.DoWork(i);
    //     }

    //     return _struct15;
    // }

    // [Benchmark]
    // [BenchmarkCategory("StructCollectionsMarshall")]
    // public Dictionary<int, Struct20> Struct20ColllectionsMarshal()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Struct20 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct20, i);
    //         obj.DoWork(i);
    //     }

    //     return _struct20;
    // }

    // [Benchmark]
    // [BenchmarkCategory("StructCollectionsMarshall")]
    // public Dictionary<int, Struct25> Struct25ColllectionsMarshal()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Struct25 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct25, i);
    //         obj.DoWork(i);
    //     }

    //     return _struct25;
    // }

    // #endregion

    // #region Struct CollectionsMarshall No Inlining


    // [Benchmark]
    // [BenchmarkCategory("StructCollectionsMarshallNoInlining")]
    // public Dictionary<int, Struct1> Struct1ColllectionsMarshalNoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Struct1 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct1, i);
    //         obj.DoWorkNoInlining(i);
    //     }

    //     return _struct1;
    // }

    // [Benchmark]
    // [BenchmarkCategory("StructCollectionsMarshallNoInlining")]
    // public Dictionary<int, Struct5> Struct5ColllectionsMarshalNoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Struct5 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct5, i);
    //         obj.DoWorkNoInlining(i);
    //     }

    //     return _struct5;
    // }

    // [Benchmark]
    // [BenchmarkCategory("StructCollectionsMarshallNoInlining")]
    // public Dictionary<int, Struct10> Struct10ColllectionsMarshalNoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Struct10 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct10, i);
    //         obj.DoWorkNoInlining(i);
    //     }

    //     return _struct10;
    // }

    // [Benchmark]
    // [BenchmarkCategory("StructCollectionsMarshallNoInlining")]
    // public Dictionary<int, Struct15> Struct15ColllectionsMarshalNoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Struct15 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct15, i);
    //         obj.DoWorkNoInlining(i);
    //     }

    //     return _struct15;
    // }

    // [Benchmark]
    // [BenchmarkCategory("StructCollectionsMarshallNoInlining")]
    // public Dictionary<int, Struct20> Struct20ColllectionsMarshalNoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Struct20 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct20, i);
    //         obj.DoWorkNoInlining(i);
    //     }

    //     return _struct20;
    // }

    // [Benchmark]
    // [BenchmarkCategory("StructCollectionsMarshallNoInlining")]
    // public Dictionary<int, Struct25> Struct25ColllectionsMarshalNoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Struct25 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_struct25, i);
    //         obj.DoWorkNoInlining(i);
    //     }

    //     return _struct25;
    // }

    // #endregion

    #region Class

    [Benchmark]
    [BenchmarkCategory("Class")]
    public Dictionary<int, Class1> Class1()
    {
        for (int i = 0; i < Length; i++)
        {
            _class1[i].DoWork(i);
        }

        return _class1;
    }

    [Benchmark]
    [BenchmarkCategory("Class")]
    public Dictionary<int, Class5> Class5()
    {
        for (int i = 0; i < Length; i++)
        {
            _class5[i].DoWork(i);
        }

        return _class5;
    }

    [Benchmark]
    [BenchmarkCategory("Class")]
    public Dictionary<int, Class10> Class10()
    {
        for (int i = 0; i < Length; i++)
        {
            _class10[i].DoWork(i);
        }

        return _class10;
    }

    [Benchmark]
    [BenchmarkCategory("Class")]
    public Dictionary<int, Class15> Class15()
    {
        for (int i = 0; i < Length; i++)
        {
            _class15[i].DoWork(i);
        }

        return _class15;
    }

    [Benchmark]
    [BenchmarkCategory("Class")]
    public Dictionary<int, Class20> Class20()
    {
        for (int i = 0; i < Length; i++)
        {
            _class20[i].DoWork(i);
        }

        return _class20;
    }

    [Benchmark]
    [BenchmarkCategory("Class")]
    public Dictionary<int, Class25> Class25()
    {
        for (int i = 0; i < Length; i++)
        {
            _class25[i].DoWork(i);
        }

        return _class25;
    }

    #endregion

    // #region Class No Inlining

    // [Benchmark]
    // [BenchmarkCategory("ClassNoInlining")]
    // public Dictionary<int, Class1> Class1NoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         _class1[i].DoWorkNoInlining(i);
    //     }

    //     return _class1;
    // }

    // [Benchmark]
    // [BenchmarkCategory("ClassNoInlining")]
    // public Dictionary<int, Class5> Class5NoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         _class5[i].DoWorkNoInlining(i);
    //     }

    //     return _class5;
    // }

    // [Benchmark]
    // [BenchmarkCategory("ClassNoInlining")]
    // public Dictionary<int, Class10> Class10NoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         _class10[i].DoWorkNoInlining(i);
    //     }

    //     return _class10;
    // }

    // [Benchmark]
    // [BenchmarkCategory("ClassNoInlining")]
    // public Dictionary<int, Class15> Class15NoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         _class15[i].DoWorkNoInlining(i);
    //     }

    //     return _class15;
    // }

    // [Benchmark]
    // [BenchmarkCategory("ClassNoInlining")]
    // public Dictionary<int, Class20> Class20NoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         _class20[i].DoWorkNoInlining(i);
    //     }

    //     return _class20;
    // }

    // [Benchmark]
    // [BenchmarkCategory("ClassNoInlining")]
    // public Dictionary<int, Class25> Class25NoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         _class25[i].DoWorkNoInlining(i);
    //     }

    //     return _class25;
    // }

    // #endregion

    // #region Class CollectionsMarshall

    // [Benchmark]
    // [BenchmarkCategory("ClassCollectionsMarshall")]
    // public Dictionary<int, Class1> ClassCollectionsMarshall1()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Class1 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class1, i);
    //         obj.DoWork(i);
    //     }

    //     return _class1;
    // }

    // [Benchmark]
    // [BenchmarkCategory("ClassCollectionsMarshall")]
    // public Dictionary<int, Class5> ClassCollectionsMarshall5()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Class5 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class5, i);
    //         obj.DoWork(i);
    //     }

    //     return _class5;
    // }

    // [Benchmark]
    // [BenchmarkCategory("ClassCollectionsMarshall")]
    // public Dictionary<int, Class10> ClassCollectionsMarshall10()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Class10 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class10, i);
    //         obj.DoWork(i);
    //     }

    //     return _class10;
    // }

    // [Benchmark]
    // [BenchmarkCategory("ClassCollectionsMarshall")]
    // public Dictionary<int, Class15> ClassCollectionsMarshall15()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Class15 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class15, i);
    //         obj.DoWork(i);
    //     }

    //     return _class15;
    // }

    // [Benchmark]
    // [BenchmarkCategory("ClassCollectionsMarshall")]
    // public Dictionary<int, Class20> ClassCollectionsMarshall20()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Class20 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class20, i);
    //         obj.DoWork(i);
    //     }

    //     return _class20;
    // }

    // [Benchmark]
    // [BenchmarkCategory("ClassCollectionsMarshall")]
    // public Dictionary<int, Class25> ClassCollectionsMarshall25()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Class25 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class25, i);
    //         obj.DoWork(i);
    //     }

    //     return _class25;
    // }

    // #endregion

    // #region Class CollectionsMarshall No Inlining


    // [Benchmark]
    // [BenchmarkCategory("ClassCollectionsMarshallNoInlining")]
    // public Dictionary<int, Class1> ClassCollectionsMarshall1NoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Class1 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class1, i);
    //         obj.DoWorkNoInlining(i);
    //     }

    //     return _class1;
    // }

    // [Benchmark]
    // [BenchmarkCategory("ClassCollectionsMarshallNoInlining")]
    // public Dictionary<int, Class5> ClassCollectionsMarshall5NoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Class5 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class5, i);
    //         obj.DoWorkNoInlining(i);
    //     }

    //     return _class5;
    // }

    // [Benchmark]
    // [BenchmarkCategory("ClassCollectionsMarshallNoInlining")]
    // public Dictionary<int, Class10> ClassCollectionsMarshall10NoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Class10 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class10, i);
    //         obj.DoWorkNoInlining(i);
    //     }

    //     return _class10;
    // }

    // [Benchmark]
    // [BenchmarkCategory("ClassCollectionsMarshallNoInlining")]
    // public Dictionary<int, Class15> ClassCollectionsMarshall15NoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Class15 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class15, i);
    //         obj.DoWorkNoInlining(i);
    //     }

    //     return _class15;
    // }

    // [Benchmark]
    // [BenchmarkCategory("ClassCollectionsMarshallNoInlining")]
    // public Dictionary<int, Class20> ClassCollectionsMarshall20NoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Class20 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class20, i);
    //         obj.DoWorkNoInlining(i);
    //     }

    //     return _class20;
    // }

    // [Benchmark]
    // [BenchmarkCategory("ClassCollectionsMarshallNoInlining")]
    // public Dictionary<int, Class25> ClassCollectionsMarshall25NoInlining()
    // {
    //     for (int i = 0; i < Length; i++)
    //     {
    //         ref Class25 obj = ref CollectionsMarshal.GetValueRefOrNullRef(_class25, i);
    //         obj.DoWorkNoInlining(i);
    //     }

    //     return _class25;
    // }

    // #endregion

}