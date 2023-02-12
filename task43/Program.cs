void IntersPoint(double b1, double k1, double b2, double k2)
{
  double x;
  double y;
  if (k1 == k2)  
    {
        Console.WriteLine("Прямые паралленьны или совпадают.");
        return;
    }
   else
   {
        x = (b2 - b1) / (k1 -k2);
        y = k1 * x + b1;
        Console.WriteLine($"Координаты пересечения двух прямых x  = {x} y = {y}");
   }
}
Console.Clear();
Console.WriteLine("Введите коэффициенты двух уравнений: y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите коэффициент b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

IntersPoint(b1, k1, b2, k2);
