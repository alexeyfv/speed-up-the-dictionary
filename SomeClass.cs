using System.Runtime.CompilerServices;

namespace Benchmark;

public class Class1
{
    public long Prop1 { get; set; }

    public void DoWork(int i)
    {
        Prop1 += i + i;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoWorkNoInlining(int i)
    {
        Prop1 += i + i;
    }
}

public class Class5
{
    public long Prop1 { get; set; }
    public long Prop2 { get; set; }
    public long Prop3 { get; set; }
    public long Prop4 { get; set; }
    public long Prop5 { get; set; }

    public void DoWork(int i)
    {
        Prop1 += i + i;
        Prop2 += i + i;
        Prop3 += i + i;
        Prop4 += i + i;
        Prop5 += i + i;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoWorkNoInlining(int i)
    {
        Prop1 += i + i;
        Prop2 += i + i;
        Prop3 += i + i;
        Prop4 += i + i;
        Prop5 += i + i;
    }
}

public class Class10
{
    public long Prop1 { get; set; }
    public long Prop2 { get; set; }
    public long Prop3 { get; set; }
    public long Prop4 { get; set; }
    public long Prop5 { get; set; }
    public long Prop6 { get; set; }
    public long Prop7 { get; set; }
    public long Prop8 { get; set; }
    public long Prop9 { get; set; }
    public long Prop10 { get; set; }

    public void DoWork(int i)
    {
        Prop1 += i + i;
        Prop2 += i + i;
        Prop3 += i + i;
        Prop4 += i + i;
        Prop5 += i + i;
        Prop6 += i + i;
        Prop7 += i + i;
        Prop8 += i + i;
        Prop9 += i + i;
        Prop10 += i + i;
    }

    
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoWorkNoInlining(int i)
    {
        Prop1 += i + i;
        Prop2 += i + i;
        Prop3 += i + i;
        Prop4 += i + i;
        Prop5 += i + i;
        Prop6 += i + i;
        Prop7 += i + i;
        Prop8 += i + i;
        Prop9 += i + i;
        Prop10 += i + i;
    }
}

public class Class15
{
    public long Prop1 { get; set; }
    public long Prop2 { get; set; }
    public long Prop3 { get; set; }
    public long Prop4 { get; set; }
    public long Prop5 { get; set; }
    public long Prop6 { get; set; }
    public long Prop7 { get; set; }
    public long Prop8 { get; set; }
    public long Prop9 { get; set; }
    public long Prop10 { get; set; }
    public long Prop11 { get; set; }
    public long Prop12 { get; set; }
    public long Prop13 { get; set; }
    public long Prop14 { get; set; }
    public long Prop15 { get; set; }

    public void DoWork(int i)
    {
        Prop1 += i + i;
        Prop2 += i + i;
        Prop3 += i + i;
        Prop4 += i + i;
        Prop5 += i + i;
        Prop6 += i + i;
        Prop7 += i + i;
        Prop8 += i + i;
        Prop9 += i + i;
        Prop10 += i + i;
        Prop11 += i + i;
        Prop12 += i + i;
        Prop13 += i + i;
        Prop14 += i + i;
        Prop15 += i + i;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoWorkNoInlining(int i)
    {
        Prop1 += i + i;
        Prop2 += i + i;
        Prop3 += i + i;
        Prop4 += i + i;
        Prop5 += i + i;
        Prop6 += i + i;
        Prop7 += i + i;
        Prop8 += i + i;
        Prop9 += i + i;
        Prop10 += i + i;
        Prop11 += i + i;
        Prop12 += i + i;
        Prop13 += i + i;
        Prop14 += i + i;
        Prop15 += i + i;
    }
}

public class Class20
{
    public long Prop1 { get; set; }
    public long Prop2 { get; set; }
    public long Prop3 { get; set; }
    public long Prop4 { get; set; }
    public long Prop5 { get; set; }
    public long Prop6 { get; set; }
    public long Prop7 { get; set; }
    public long Prop8 { get; set; }
    public long Prop9 { get; set; }
    public long Prop10 { get; set; }
    public long Prop11 { get; set; }
    public long Prop12 { get; set; }
    public long Prop13 { get; set; }
    public long Prop14 { get; set; }
    public long Prop15 { get; set; }
    public long Prop16 { get; set; }
    public long Prop17 { get; set; }
    public long Prop18 { get; set; }
    public long Prop19 { get; set; }
    public long Prop20 { get; set; }

    public void DoWork(int i)
    {
        Prop1 += i + i;
        Prop2 += i + i;
        Prop3 += i + i;
        Prop4 += i + i;
        Prop5 += i + i;
        Prop6 += i + i;
        Prop7 += i + i;
        Prop8 += i + i;
        Prop9 += i + i;
        Prop10 += i + i;
        Prop11 += i + i;
        Prop12 += i + i;
        Prop13 += i + i;
        Prop14 += i + i;
        Prop15 += i + i;
        Prop16 += i + i;
        Prop17 += i + i;
        Prop18 += i + i;
        Prop19 += i + i;
        Prop20 += i + i;
    }
    
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoWorkNoInlining(int i)
    {
        Prop1 += i + i;
        Prop2 += i + i;
        Prop3 += i + i;
        Prop4 += i + i;
        Prop5 += i + i;
        Prop6 += i + i;
        Prop7 += i + i;
        Prop8 += i + i;
        Prop9 += i + i;
        Prop10 += i + i;
        Prop11 += i + i;
        Prop12 += i + i;
        Prop13 += i + i;
        Prop14 += i + i;
        Prop15 += i + i;
        Prop16 += i + i;
        Prop17 += i + i;
        Prop18 += i + i;
        Prop19 += i + i;
        Prop20 += i + i;
    }
}

public class Class25
{
    public long Prop1 { get; set; }
    public long Prop2 { get; set; }
    public long Prop3 { get; set; }
    public long Prop4 { get; set; }
    public long Prop5 { get; set; }
    public long Prop6 { get; set; }
    public long Prop7 { get; set; }
    public long Prop8 { get; set; }
    public long Prop9 { get; set; }
    public long Prop10 { get; set; }
    public long Prop11 { get; set; }
    public long Prop12 { get; set; }
    public long Prop13 { get; set; }
    public long Prop14 { get; set; }
    public long Prop15 { get; set; }
    public long Prop16 { get; set; }
    public long Prop17 { get; set; }
    public long Prop18 { get; set; }
    public long Prop19 { get; set; }
    public long Prop20 { get; set; }
    public long Prop21 { get; set; }
    public long Prop22 { get; set; }
    public long Prop23 { get; set; }
    public long Prop24 { get; set; }
    public long Prop25 { get; set; }

    public void DoWork(int i)
    {
        Prop1 += i + i;
        Prop2 += i + i;
        Prop3 += i + i;
        Prop4 += i + i;
        Prop5 += i + i;
        Prop6 += i + i;
        Prop7 += i + i;
        Prop8 += i + i;
        Prop9 += i + i;
        Prop10 += i + i;
        Prop11 += i + i;
        Prop12 += i + i;
        Prop13 += i + i;
        Prop14 += i + i;
        Prop15 += i + i;
        Prop16 += i + i;
        Prop17 += i + i;
        Prop18 += i + i;
        Prop19 += i + i;
        Prop20 += i + i;
        Prop21 += i + i;
        Prop22 += i + i;
        Prop23 += i + i;
        Prop24 += i + i;
        Prop25 += i + i;
    }
    
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoWorkNoInlining(int i)
    {
        Prop1 += i + i;
        Prop2 += i + i;
        Prop3 += i + i;
        Prop4 += i + i;
        Prop5 += i + i;
        Prop6 += i + i;
        Prop7 += i + i;
        Prop8 += i + i;
        Prop9 += i + i;
        Prop10 += i + i;
        Prop11 += i + i;
        Prop12 += i + i;
        Prop13 += i + i;
        Prop14 += i + i;
        Prop15 += i + i;
        Prop16 += i + i;
        Prop17 += i + i;
        Prop18 += i + i;
        Prop19 += i + i;
        Prop20 += i + i;
        Prop21 += i + i;
        Prop22 += i + i;
        Prop23 += i + i;
        Prop24 += i + i;
        Prop25 += i + i;
    }
}
