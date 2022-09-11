// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
int Prompt(string message)
{
    Console.Write(message);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int GivesCube(int number)
{
    int num = 0;
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine(i + "\t" + i * i * i);
    }
    return num;
}
int number = Prompt("Введите число > ");
GivesCube(number);