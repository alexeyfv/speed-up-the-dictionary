using System.Runtime.CompilerServices;

namespace Benchmark;

public class Class1
{
    public int IntProp1 { get; set; }

    public void DoWork(int i)
    {
        IntProp1 += i + i;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoWorkNoInlining(int i)
    {
        IntProp1 += i + i;
    }
}

public class Class5
{
    public int IntProp1 { get; set; }
    public int IntProp2 { get; set; }
    public int IntProp3 { get; set; }
    public int IntProp4 { get; set; }
    public int IntProp5 { get; set; }

    public void DoWork(int i)
    {
        IntProp1 += i + i;
        IntProp2 += i + i;
        IntProp3 += i + i;
        IntProp4 += i + i;
        IntProp5 += i + i;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoWorkNoInlining(int i)
    {
        IntProp1 += i + i;
        IntProp2 += i + i;
        IntProp3 += i + i;
        IntProp4 += i + i;
        IntProp5 += i + i;
    }
}

public class Class10
{
    public int IntProp1 { get; set; }
    public int IntProp2 { get; set; }
    public int IntProp3 { get; set; }
    public int IntProp4 { get; set; }
    public int IntProp5 { get; set; }
    public int IntProp6 { get; set; }
    public int IntProp7 { get; set; }
    public int IntProp8 { get; set; }
    public int IntProp9 { get; set; }
    public int IntProp10 { get; set; }

    public void DoWork(int i)
    {
        IntProp1 += i + i;
        IntProp2 += i + i;
        IntProp3 += i + i;
        IntProp4 += i + i;
        IntProp5 += i + i;
        IntProp6 += i + i;
        IntProp7 += i + i;
        IntProp8 += i + i;
        IntProp9 += i + i;
        IntProp10 += i + i;
    }

    
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoWorkNoInlining(int i)
    {
        IntProp1 += i + i;
        IntProp2 += i + i;
        IntProp3 += i + i;
        IntProp4 += i + i;
        IntProp5 += i + i;
        IntProp6 += i + i;
        IntProp7 += i + i;
        IntProp8 += i + i;
        IntProp9 += i + i;
        IntProp10 += i + i;
    }
}

public class Class15
{
    public int IntProp1 { get; set; }
    public int IntProp2 { get; set; }
    public int IntProp3 { get; set; }
    public int IntProp4 { get; set; }
    public int IntProp5 { get; set; }
    public int IntProp6 { get; set; }
    public int IntProp7 { get; set; }
    public int IntProp8 { get; set; }
    public int IntProp9 { get; set; }
    public int IntProp10 { get; set; }
    public int IntProp11 { get; set; }
    public int IntProp12 { get; set; }
    public int IntProp13 { get; set; }
    public int IntProp14 { get; set; }
    public int IntProp15 { get; set; }

    public void DoWork(int i)
    {
        IntProp1 += i + i;
        IntProp2 += i + i;
        IntProp3 += i + i;
        IntProp4 += i + i;
        IntProp5 += i + i;
        IntProp6 += i + i;
        IntProp7 += i + i;
        IntProp8 += i + i;
        IntProp9 += i + i;
        IntProp10 += i + i;
        IntProp11 += i + i;
        IntProp12 += i + i;
        IntProp13 += i + i;
        IntProp14 += i + i;
        IntProp15 += i + i;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoWorkNoInlining(int i)
    {
        IntProp1 += i + i;
        IntProp2 += i + i;
        IntProp3 += i + i;
        IntProp4 += i + i;
        IntProp5 += i + i;
        IntProp6 += i + i;
        IntProp7 += i + i;
        IntProp8 += i + i;
        IntProp9 += i + i;
        IntProp10 += i + i;
        IntProp11 += i + i;
        IntProp12 += i + i;
        IntProp13 += i + i;
        IntProp14 += i + i;
        IntProp15 += i + i;
    }
}

public class Class20
{
    public int IntProp1 { get; set; }
    public int IntProp2 { get; set; }
    public int IntProp3 { get; set; }
    public int IntProp4 { get; set; }
    public int IntProp5 { get; set; }
    public int IntProp6 { get; set; }
    public int IntProp7 { get; set; }
    public int IntProp8 { get; set; }
    public int IntProp9 { get; set; }
    public int IntProp10 { get; set; }
    public int IntProp11 { get; set; }
    public int IntProp12 { get; set; }
    public int IntProp13 { get; set; }
    public int IntProp14 { get; set; }
    public int IntProp15 { get; set; }
    public int IntProp16 { get; set; }
    public int IntProp17 { get; set; }
    public int IntProp18 { get; set; }
    public int IntProp19 { get; set; }
    public int IntProp20 { get; set; }

    public void DoWork(int i)
    {
        IntProp1 += i + i;
        IntProp2 += i + i;
        IntProp3 += i + i;
        IntProp4 += i + i;
        IntProp5 += i + i;
        IntProp6 += i + i;
        IntProp7 += i + i;
        IntProp8 += i + i;
        IntProp9 += i + i;
        IntProp10 += i + i;
        IntProp11 += i + i;
        IntProp12 += i + i;
        IntProp13 += i + i;
        IntProp14 += i + i;
        IntProp15 += i + i;
        IntProp16 += i + i;
        IntProp17 += i + i;
        IntProp18 += i + i;
        IntProp19 += i + i;
        IntProp20 += i + i;
    }
    
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoWorkNoInlining(int i)
    {
        IntProp1 += i + i;
        IntProp2 += i + i;
        IntProp3 += i + i;
        IntProp4 += i + i;
        IntProp5 += i + i;
        IntProp6 += i + i;
        IntProp7 += i + i;
        IntProp8 += i + i;
        IntProp9 += i + i;
        IntProp10 += i + i;
        IntProp11 += i + i;
        IntProp12 += i + i;
        IntProp13 += i + i;
        IntProp14 += i + i;
        IntProp15 += i + i;
        IntProp16 += i + i;
        IntProp17 += i + i;
        IntProp18 += i + i;
        IntProp19 += i + i;
        IntProp20 += i + i;
    }
}

public class Class25
{
    public int IntProp1 { get; set; }
    public int IntProp2 { get; set; }
    public int IntProp3 { get; set; }
    public int IntProp4 { get; set; }
    public int IntProp5 { get; set; }
    public int IntProp6 { get; set; }
    public int IntProp7 { get; set; }
    public int IntProp8 { get; set; }
    public int IntProp9 { get; set; }
    public int IntProp10 { get; set; }
    public int IntProp11 { get; set; }
    public int IntProp12 { get; set; }
    public int IntProp13 { get; set; }
    public int IntProp14 { get; set; }
    public int IntProp15 { get; set; }
    public int IntProp16 { get; set; }
    public int IntProp17 { get; set; }
    public int IntProp18 { get; set; }
    public int IntProp19 { get; set; }
    public int IntProp20 { get; set; }
    public int IntProp21 { get; set; }
    public int IntProp22 { get; set; }
    public int IntProp23 { get; set; }
    public int IntProp24 { get; set; }
    public int IntProp25 { get; set; }

    public void DoWork(int i)
    {
        IntProp1 += i + i;
        IntProp2 += i + i;
        IntProp3 += i + i;
        IntProp4 += i + i;
        IntProp5 += i + i;
        IntProp6 += i + i;
        IntProp7 += i + i;
        IntProp8 += i + i;
        IntProp9 += i + i;
        IntProp10 += i + i;
        IntProp11 += i + i;
        IntProp12 += i + i;
        IntProp13 += i + i;
        IntProp14 += i + i;
        IntProp15 += i + i;
        IntProp16 += i + i;
        IntProp17 += i + i;
        IntProp18 += i + i;
        IntProp19 += i + i;
        IntProp20 += i + i;
        IntProp21 += i + i;
        IntProp22 += i + i;
        IntProp23 += i + i;
        IntProp24 += i + i;
        IntProp25 += i + i;
    }
    
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoWorkNoInlining(int i)
    {
        IntProp1 += i + i;
        IntProp2 += i + i;
        IntProp3 += i + i;
        IntProp4 += i + i;
        IntProp5 += i + i;
        IntProp6 += i + i;
        IntProp7 += i + i;
        IntProp8 += i + i;
        IntProp9 += i + i;
        IntProp10 += i + i;
        IntProp11 += i + i;
        IntProp12 += i + i;
        IntProp13 += i + i;
        IntProp14 += i + i;
        IntProp15 += i + i;
        IntProp16 += i + i;
        IntProp17 += i + i;
        IntProp18 += i + i;
        IntProp19 += i + i;
        IntProp20 += i + i;
        IntProp21 += i + i;
        IntProp22 += i + i;
        IntProp23 += i + i;
        IntProp24 += i + i;
        IntProp25 += i + i;
    }
}
