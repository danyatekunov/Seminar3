Console.WriteLine("Введите координату X1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y2");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z2");
int z2 = Convert.ToInt32(Console.ReadLine());

void DistanceCalc(){
int a = (x1-x2);
int b = (y1-y2);
int c = (z1-z2);

double distance = Math.Sqrt(a * a + b * b + c * c);

Console.WriteLine($"Расстояние между точками равно {distance}");

}
DistanceCalc();