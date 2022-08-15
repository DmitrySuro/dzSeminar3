//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.Clear();

double DistanceBetweenTwoPoints(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double differenceX = Math.Abs(xA - xB);
    double differenceY = Math.Abs(yA - yB);
    double differenceZ = Math.Abs(zA - zB);
    double result = Math.Sqrt(differenceX * differenceX + differenceY * differenceY + differenceZ * differenceZ);
return result;
}



System.Console.WriteLine("Введите координату по оси х точки А ");
double xA = double.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите координату по оси y точки А ");
double yA = double.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите координату по оси z точки А ");
double zA = double.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите координату по оси х точки B ");
double xB = double.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите координату по оси y точки B ");
double yB = double.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите координату по оси z точки B ");
double zB = double.Parse(System.Console.ReadLine()!);

double distance = DistanceBetweenTwoPoints(xA,yA,zA,xB,yB,zB);

System.Console.WriteLine($"Расстояние между точками = {distance:f2}");