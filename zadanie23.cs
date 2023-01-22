Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());

void CubeCalc()
{

    for (int i = 1; i <= x; i++)
    {

        Console.WriteLine($"{i * i * i} ");
    }
}
CubeCalc();