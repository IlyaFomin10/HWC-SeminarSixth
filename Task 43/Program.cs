// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[] CrossLines (double k1, double k2, double b1, double b2)
{
    double[] arr = new double[2];
    arr[0] = (b2 - b1) / (k1 - k2);
    arr[1] = k1 * arr[0] + b1;
    return arr;
}
Console.WriteLine("Введите значения переменных, чтобы найти пересечение двух прямых в вашем уравнении - (y = k1 * x + b1, y = k2 * x + b2)");
Console.WriteLine("Начните вводить попорядку, вначале k1, затем k2, b1, b2:");
int k1 = int.Parse(Console.ReadLine());
int k2 = int.Parse(Console.ReadLine());
int b1 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());
double[] xy = CrossLines(k1, k2, b1, b2);
Console.WriteLine($"Точка пересечения двух прямых равна ({Math.Round(xy[0], 2)}, {Math.Round(xy[1],2)})");