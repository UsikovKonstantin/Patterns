using ClassLibraryPatterns;

BallPointPen bpp = new BallPointPen();
Console.WriteLine(bpp.Display());
Console.WriteLine(bpp.PerformWrite());
Console.WriteLine();

GelPen gp = new GelPen();
Console.WriteLine(gp.Display());
Console.WriteLine(gp.PerformWrite());
Console.WriteLine();

FountainPen fp = new FountainPen();
Console.WriteLine(fp.Display());
Console.WriteLine(fp.PerformWrite());
Console.WriteLine();

CapillaryPen cp = new CapillaryPen();
Console.WriteLine(cp.Display());
Console.WriteLine(cp.PerformWrite());
Console.WriteLine();