Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number;
int rev = 0;
bool FindPolindrom(int num)
{
    while (temp != 0)
    {
        rev = (rev * 10) + (temp % 10);
        temp = temp / 10;
    }
    return rev == number;
}
if (FindPolindrom(temp) == true)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
