/*Пользователь вводит М чисел.
Посчитаете сколько чисел больше 0 ввел ползователь.*/

Console.WriteLine("Enter the numbers separated by commas:");
string? M = Console.ReadLine()??string.Empty;

M = M.Replace(","," ").Replace("."," ").Replace(";"," ").Replace("/"," ");//убрали знаки

string[] columnNumber = M.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
/*написали каждый знак в новой строке и убрали пустые строки, можно вывести посмотреть
foreach (string s in columnNumber)
{
    Console.WriteLine(s);
}
*/

int[] numbers = new int[columnNumber.Length];

for (int i=0;i<numbers.Length;i++)
{
    numbers[i]= Convert.ToInt32(columnNumber[i]);//записали числовой массив
}

int positiveNumbers=0;
for (int i=0; i<numbers.Length; i++)
{
    if(numbers[i]>0)
        positiveNumbers++;
}
Console.Write($"You entered {positiveNumbers} positive numbers");