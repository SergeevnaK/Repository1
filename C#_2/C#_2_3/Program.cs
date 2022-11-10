// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
    if (number >7) 
    {
        Console.Write ("Число не обозначает день недели");
    }
    else
    if (number >5) 
    {
        Console.Write ("Число обозначает выходной день недели");
    }
    else 
    Console.Write ("Число обозначает рабочий день недели");
    