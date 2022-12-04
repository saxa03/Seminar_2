// напишите программу, которая выводит трехзначное число и удаляет вторую цифру этого числа
Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine($"Число {num}");
int num1 = num / 100 ;
Console.Write($"{num1}");
int num2 = num % 10 ;
Console.WriteLine($"{num2}");
// второй вариант с выводом
//Console.WriteLine($"{num} -> {num / 100}{num % 10}");