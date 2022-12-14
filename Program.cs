//Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
/*
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
*/


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cubes (int number)
{
    int counter=1;
    while(counter<=number)
    {
        Console.Write($"{Math.Pow(counter, 3)}");
        if (counter !=number) Console.Write(" , ");
        counter++;
    }
}
Console.Write("Input  int number:   ");
int num=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The cubes of numbers:  ");
Cubes (num);
*/

//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
/*
Console.WriteLine("Input number:  ");
string number=Console.ReadLine();
int len= number.Length;

if(len==5)
{
    if(number [0] == number [4] && number [1] == number [3])
    {
        Console.WriteLine ($"{number} is Polindrom");
    }
    else
    {
         Console.WriteLine ($"{number} isn't Polindrom");
    }
}
else
{
    Console.WriteLine($"Mistake: {number} isn't five-digit");
}
*/
