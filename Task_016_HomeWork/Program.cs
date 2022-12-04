// написать программу ,которая принимает на вход цифру, обозначающую день недели и
//проверяет, является ли этот день выходным (6 или 7)
Console.Clear();

Console.Write("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine());

    if (num == 7 || num == 6)
 {
    Console.WriteLine("Выходной");
 }
    else
 {
    Console.WriteLine("Рабочий");
 }
 