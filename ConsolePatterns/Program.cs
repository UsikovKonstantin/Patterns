using ClassLibraryPatterns;

#region Паттерн "Стратегия"
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
#endregion

#region Паттерн "Декоратор" стандартная реализация
IceCream plompier = new Plombier();
plompier = new ChocolateChips(plompier);
Console.WriteLine(plompier.Description);
Console.WriteLine();

IceCream sundae = new Sundae();
sundae = new RaspberrySyrup(sundae);
sundae = new Nuts(sundae);
Console.WriteLine(sundae.Description);
Console.WriteLine();

IceCream mic = new MilkIceCream();
mic = new ChocolateChips(mic);
mic = new RaspberrySyrup(mic);
mic = new Nuts(mic);
Console.WriteLine(mic.Description);
Console.WriteLine();
#endregion