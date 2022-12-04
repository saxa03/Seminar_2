// написать программу, которая выводит третью цифру заданного числа или сообщает, что ее нет
Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

if (N < 100)
{
   Console.WriteLine("третья цифра отсутствует"); 
}
else{
while (N >= 1000)
{
    N = N / 10;
}


Console.WriteLine($"{N % 10}");
}

