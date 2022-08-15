//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

System.Console.Clear();

int CheckPalindromNumber(int numberUser)
{
    int firstNumber = numberUser / 10000;
    int fifthNumber = numberUser % 10;
    int secondNumber = (numberUser / 1000) % 10;
    int fourthNumber = (numberUser / 10) % 10;

    if (firstNumber == fifthNumber && secondNumber == fourthNumber)
        System.Console.WriteLine("Ваше число полиндром");
    else
        System.Console.WriteLine("Ваше число не полиндром");
    return numberUser;
}

System.Console.WriteLine("Введите пятизначное число");
int numberUser = int.Parse(System.Console.ReadLine()!);

System.Console.WriteLine(CheckPalindromNumber(numberUser));