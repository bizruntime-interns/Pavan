using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Box> Boxes = new List<Box>();
        Boxes.Add(new Box(4, 20, 14));
        Boxes.Add(new Box(12, 12, 12));
        Boxes.Add(new Box(8, 20, 10));
        Boxes.Add(new Box(6, 10, 2));
        Boxes.Add(new Box(2, 8, 4));
        Boxes.Add(new Box(2, 6, 8));
        Boxes.Add(new Box(4, 12, 20));

        Boxes.Sort(new BoxLengthFirst());

        Console.WriteLine("H - L - W");
        Console.WriteLine("==========");
        foreach (Box bx in Boxes)
        {
            Console.WriteLine("{0}\t{1}\t{2}",
                bx.Height.ToString(), bx.Length.ToString(),
                bx.Width.ToString());
        }

        Console.WriteLine();
        Console.WriteLine("H - L - W");
        Console.WriteLine("==========");

        Comparer<Box> defComp = Comparer<Box>.Default;

        Boxes.Sort();

        foreach (Box bx in Boxes)
        {
            Console.WriteLine("{0}\t{1}\t{2}",
                bx.Height.ToString(), bx.Length.ToString(),
                bx.Width.ToString());
        }
        BoxLengthFirst LengthFirst = new BoxLengthFirst();

        Comparer<Box> bc = (Comparer<Box>)LengthFirst;

        Box BoxA = new Box(2, 6, 8);
        Box BoxB = new Box(10, 12, 14);
        int x = LengthFirst.Compare(BoxA, BoxB);
        Console.WriteLine();
        Console.WriteLine(x.ToString());
    }
}

public class BoxLengthFirst : Comparer<Box>
{
    public override int Compare(Box x, Box y)
    {
        if (x.Length.CompareTo(y.Length) != 0)
        {
            return x.Length.CompareTo(y.Length);
        }
        else if (x.Height.CompareTo(y.Height) != 0)
        {
            return x.Height.CompareTo(y.Height);
        }
        else if (x.Width.CompareTo(y.Width) != 0)
        {
            return x.Width.CompareTo(y.Width);
        }
        else
        {
            return 0;
        }
    }
}
public class BoxComp : IComparer<Box>
{ 
    public int Compare(Box x, Box y)
    {
        if (x.Height.CompareTo(y.Height) != 0)
        {
            return x.Height.CompareTo(y.Height);
        }
        else if (x.Length.CompareTo(y.Length) != 0)
        {
            return x.Length.CompareTo(y.Length);
        }
        else if (x.Width.CompareTo(y.Width) != 0)
        {
            return x.Width.CompareTo(y.Width);
        }
        else
        {
            return 0;
        }
    }
}

public class Box : IComparable<Box>
{
    public Box(int h, int l, int w)
    {
        this.Height = h;
        this.Length = l;
        this.Width = w;
    }
    public int Height { get; private set; }
    public int Length { get; private set; }
    public int Width { get; private set; }

    public int CompareTo(Box other)
    {

        if (this.Height.CompareTo(other.Height) != 0)
        {
            return this.Height.CompareTo(other.Height);
        }
        else if (this.Length.CompareTo(other.Length) != 0)
        {
            return this.Length.CompareTo(other.Length);
        }
        else if (this.Width.CompareTo(other.Width) != 0)
        {
            return this.Width.CompareTo(other.Width);
        }
        else
        {
            return 0;
        }
    }
}