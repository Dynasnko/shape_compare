using shape;

Shape mycircle1 = new Circle(500);
Shape myTrianble01 = new Triangle(30,10.2);
Shape myTrapeZoidHigh = new TrapeZoid(4.2, 5.2, 100);
Shape Large = mycircle1;


Console.WriteLine("圓形:" + mycircle1.area.ToString());
Console.WriteLine("三角形:" + myTrianble01.area.ToString());
Console.WriteLine("梯形"+myTrapeZoidHigh.area.ToString());

if (myTrianble01.CompareTo(Large)>0)
    Large=myTrianble01;

if (myTrapeZoidHigh.CompareTo(Large) > 0)
    Large=myTrapeZoidHigh;

Console.WriteLine(Large);