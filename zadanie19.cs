Console.WriteLine("Введите пятизначное число");
int x = Convert.ToInt32(Console.ReadLine());


while (x < 10000 || x > 99999)
{
    Console.WriteLine("Ваше число не является пятизначным!");
    return;
}



int z = x / 10000; //первая цифра
int r = x % 10;//пятая цифра



while (x >= 10000)
{

    x /= 1000; //вторая цифра

}

int y = x % 10;

while (x >= 10000)
{

    x /= 10; //четвертая цифра

}

int c = x % 10;



void PalyndromeCheck(int z, int r, int y, int c)
{



    if (z == r && y == c)
    {
        Console.WriteLine("Ваше число является палиндромом!");

    }

    else
        Console.WriteLine("Ваше число не является палиндромом!");

}
PalyndromeCheck(z, r, y, c);

