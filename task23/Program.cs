//Задача 23
//Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

System.Console.Clear();

void CubeTable(int numberUser)
{
    System.Console.WriteLine("Вот вам таблица кубов");
    int startNumber = 1;
    int result = 1;
    while (startNumber <= numberUser)
    {
        result = Convert.ToInt32(Math.Pow(startNumber,3));
        startNumber++;
        System.Console.WriteLine(result);
    }
}

System.Console.WriteLine("Введите свое число");
int numberUser = int.Parse(System.Console.ReadLine()!);

CubeTable(numberUser);