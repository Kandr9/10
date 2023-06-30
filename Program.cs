// №10

System.Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
 int x=num%100;
if (num / 100 >= 1 && num/1000 <1)

    System.Console.Write( x / 10);
    else 
    System.Console.Write("ВВедёное число не трёхзначное");