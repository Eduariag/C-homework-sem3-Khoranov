double Distance (double xA, double yA, double zA, double xB, double yB, double zB)
{
double length=Math.Sqrt(Math.Pow(xB-xA,2)+Math.Pow(yB-yA,2)+Math.Pow(zB-zA,2));
return Math.Round(length,2);
}

Console.Write("Input x-coordinate A:   ");
double xA= Convert.ToDouble(Console.ReadLine());

Console.Write("Input y-coordinate A:   ");
double yA= Convert.ToDouble(Console.ReadLine());

Console.Write("Input z-coordinate A:   ");
double zA= Convert.ToDouble(Console.ReadLine());

Console.Write("Input x-coordinate B:   ");
double xB= Convert.ToDouble(Console.ReadLine());

Console.Write("Input y-coordinate B:   ");
double yB= Convert.ToDouble(Console.ReadLine());

Console.Write("Input z-coordinate B:   ");
double zB= Convert.ToDouble(Console.ReadLine());

double distanceAB = Distance (xA, yA, zA, xB, yB, zB);

Console.WriteLine($" Distance A and B is {distanceAB}");


