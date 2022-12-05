/* Напишите программу, которая найдет точку пересечения 2х прямых, заданных уравнением
y=k1*x+b1
y=k2*x+b2
значения k1,k2,b1,b2 задаются пользователем*/

double k1 = ReadIn("Enter the number (k1) in the formula (y=k1*x+b1): ");
double b1 = ReadIn("Enter the number (b1) in the formula (y=k1*x+b1): ");
double k2 = ReadIn("Enter the number (k2) in the formula (y=k2*x+b2): ");
double b2 = ReadIn("Enter the number (b2) in the formula (y=k2*x+b2): ");

if (k1==k2)
{
    if (b1==0 && b2<0)
    {
        Console.WriteLine($"Line y={k1}x is parallel to the line y={k2}x-{-b2}");
    }
    else if (b1==0 && b2>0)
    {
        Console.WriteLine($"Line y={k1}x is parallel to the line y={k2}x+{b2}");
    }
    if (b2==0 && b1<0)
    {
        Console.WriteLine($"Line y={k1}x-{-b1} is parallel to the line y={k2}x");
    }
    else if (b2==0 && b1>0)
    {
        Console.WriteLine($"Line y={k1}x+{b1} is parallel to the line y={k2}x");
    }  
    else if (b1<0 && b2<0)
    {
        Console.WriteLine($"Line y={k1}x-{-b1} is parallel to the line y={k2}x-{-b2}");
    } 
    else if (b1<0 && b2>0)
    {
        Console.WriteLine($"Line y={k1}x-{-b1} is parallel to the line y={k2}x+{b2}");
    }
    else if (b1>0 && b2<0)
    {
        Console.WriteLine($"Line y={k1}x+{b1} is parallel to the line y={k2}x-{-b2}");
    }
    else if (b1>0 && b2>0)
    {
        Console.WriteLine($"Line y={k1}x+{b1} is parallel to the line y={k2}x+{b2}");
    }
}

double x0 = (b2-b1)/(k1-k2);
double y0 = k1*x0+b1;

if (b1==0 && b2<0)
    {
        Console.WriteLine($"Line y={k1}x cross the line y={k2}x-{-b2} at the point ({x0},{y0}).");
    }
    else if (b1==0 && b2>0)
    {
        Console.WriteLine($"Line y={k1}x cross the line y={k2}x+{b2} at the point ({x0},{y0}).");
    }
    if (b2==0 && b1<0)
    {
        Console.WriteLine($"Line y={k1}x-{-b1} cross the line y={k2}x at the point ({x0},{y0}).");
    }
    else if (b2==0 && b1>0)
    {
        Console.WriteLine($"Line y={k1}x+{b1} cross the line y={k2}x at the point ({x0},{y0}).");
    }  
    else if (b1<0 && b2<0)
    {
        Console.WriteLine($"Line y={k1}x-{-b1} cross the line y={k2}x-{-b2} at the point ({x0},{y0}).");
    } 
    else if (b1<0 && b2>0)
    {
        Console.WriteLine($"Line y={k1}x-{-b1} cross the line y={k2}x+{b2} at the point ({x0},{y0}).");
    }
    else if (b1>0 && b2<0)
    {
        Console.WriteLine($"Line y={k1}x+{b1} cross the line y={k2}x-{-b2} at the point ({x0},{y0}).");
    }
    else if (b1>0 && b2>0)
    {
        Console.WriteLine($"Line y={k1}x+{b1} cross the line y={k2}x+{b2} at the point ({x0},{y0}).");
    }

int ReadIn (string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}
