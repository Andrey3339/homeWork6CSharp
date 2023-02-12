double TriangleArea(double[] tops)
{
    double s1 = Math.Sqrt(Math.Pow(tops[0] - tops[2], 2) + Math.Pow(tops[1] - tops[3], 2));
    Console.WriteLine(s1);    
    double s2 = Math.Sqrt(Math.Pow(tops[2] - tops[4], 2) + Math.Pow(tops[3] - tops[5], 2));
    Console.WriteLine(s2);
    double s3 = Math.Sqrt(Math.Pow(tops[4] - tops[0], 2) + Math.Pow(tops[5] - tops[1], 2));
    Console.WriteLine(s3);
    double p = (s1 + s2 + s3) / 2;
    Console.WriteLine(p);
    double s = Math.Sqrt(p * (p - s1) * (p - s2) * (p - s3));
    Console.WriteLine(s);
    return s;
}
Console.Clear();
Console.Write("Введите координаты вершин треугольника x1, y1, x2, y2, x3, y3: ");
double[] tops = Console.ReadLine().Split().Select(x => double.Parse(x)).ToArray();
Console.WriteLine("Площадь треугольника равна " + TriangleArea(tops));







