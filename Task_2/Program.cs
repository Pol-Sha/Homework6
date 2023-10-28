// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
using System.Drawing;

double ReadInt(string msg) // объявление функции со строковым параметром
{
    Console.WriteLine(msg);// пишет в консоль парметр msg
    string numb = Console.ReadLine();// функция считывания строки из терминала
    double number; // вводим переменную 
    number = double.Parse(numb);// как результат преобразования строик в число
    return number; // возврат из функции
}
double b1 = ReadInt("Введите значение b1: ");
double k1 = ReadInt("Введите значение k1: ");
double b2 = ReadInt("Введите значение b2: ");
double k2 = ReadInt("Введите значение k2: ");
if (k1!=k2 && b2!=0 && b1!=0)
    {
    double x = (b2-b1)/(k1-k2);
    double y = (k1*x)+b1;
    Console.WriteLine("Точка пересечения имеет координаты: (" + String.Format("{0:F2}", x) + ", " + String.Format("{0:F2}",y) + ")");
    }
    else
    {
    Console.WriteLine(" Данные прямые не пересекаются ");
    }
    




// Console.WriteLine($"Точка пересечения двух прямых : ( {x} ; {y} )");
//     double point =
// Console.Write("Введите значение b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение b2: ");
// double b2= Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());
//double b1 = ReadInt (Console.Write("Введите значение b1: "));
// Console.Write("Введите значение k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение b2: ");
// double b2= Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());



