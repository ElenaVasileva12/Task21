// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distanse(int xa, int ya, int xb, int yb, int za, int zb)
{
    double num=Math.Sqrt (Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2)+Math.Pow((zb - za),2));
    return Math.Round(num,2,MidpointRounding.ToZero);
}

Console.WriteLine("Ведите координаты первой точки");
Console.Write("Xa: ");
int x1Coord=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите координаты первой точки");
Console.Write("Ya: ");
int y1Coord=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите координаты второй точки");
Console.Write("Za: ");
int z1Coord=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите координаты второй точки");
Console.Write("Xb: ");
int x2Coord=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите координаты второй точки");
Console.Write("Yb: ");
int y2Coord=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите координаты второй точки");
Console.Write("Zb: ");
int z2Coord=Convert.ToInt32(Console.ReadLine());


Console.WriteLine(Distanse(x1Coord,y1Coord,x2Coord,y2Coord,z1Coord,z2Coord));

//округление Math.Round(d,2,MidpointRounding.ToZero) - 2 знака после запятой