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
Console.WriteLine(plompier.ToString());
Console.WriteLine();

IceCream sundae = new Sundae();
sundae = new RaspberrySyrup(sundae);
sundae = new Nuts(sundae);
Console.WriteLine(sundae.ToString());
Console.WriteLine();

IceCream mic = new MilkIceCream();
mic = new ChocolateChips(mic);
mic = new RaspberrySyrup(mic);
mic = new Nuts(mic);
Console.WriteLine(mic.ToString());
Console.WriteLine();
#endregion

#region Паттерн "Декоратор" модернизированная реализация 
DecorIceCream order = new DecorMilkIceCream();
order = order.AddDecor(new DecorNuts());
order = order.AddDecor(new DecorRaspberrySyrup());
Console.WriteLine(order.ToString());
Console.WriteLine();

DecorIceCream order2 = new DecorSundae();
order2 = order2.AddDecor(new DecorChocolateChips());
order2 = order2.AddDecor(new DecorRaspberrySyrup());
order2 = order2.AddDecor(new DecorNuts());
Console.WriteLine(order2.ToString());
Console.WriteLine();
#endregion

#region Паттерн "Наблюдатель" 
VideoCreator vc = new VideoCreator();
Viewer v1 = new Viewer("Vanya128", vc);
Viewer v2 = new Viewer("Alex32", vc);
Viewer v3 = new Viewer("Dmitry64", vc);
vc.MakeVideo();
v1.StopView();
v2.StopView();
v3.StopView();
Console.WriteLine();
#endregion