// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X # 0 и Y # 0 и выдыет номер четверти плоскости, в которой находится эта точка.

/*
void Funkt(int x, int  y) 
{
    if (x >0 && y >0)
       Console.WriteLine(" This point on 1st quater");
    else if (x <0 && y > 0)
       Console.WriteLine(" This point on 2nd quater");
    else if (x < 0 && y < 0)
       Console.WriteLine(" This point on 3nd quater");
    else if (x > 0 && y < 0)
       Console.WriteLine(" This point on 4st quater");  
    else Console.WriteLine("its impossible in this task!");   
}
Console.WriteLine("Imput your x number: ");  
int xCoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Imput your y number: ");  
int yCoord = Convert.ToInt32(Console.ReadLine());

Funkt(xCoord, yCoord);
*/
// Напишите программуу, которая по заданному номеру четверти,
// показывает диапозон возможных координат точек в этой четверти (x и Y).

/*
void PossibleValue( int n)
{
    if (n == 1 )
      Console.WriteLine(" 1st quater x > 0 && y > 0");
    if (n == 2 )
      Console.WriteLine(" 2nd quater x < 0 && y > 0" ); 
    if (n == 3 )
      Console.WriteLine(" 3nd quater x < 0 && y < 0" ); 
    else Console.WriteLine("4th quater x >0 && y >0");  
}

Console.WriteLine("Input your number of quater: ");  
int numQater = Convert.ToInt32(Console.ReadLine());

if(numQater >=1 && numQater <= 4)
    PossibleValue(numQater);
else Console.WriteLine ( "its not number of quater!");    
*/
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.

/*
                 |y
        .A       |
   I             |            .B     II 
    _____________|_________________x             
                 |
                 |
                 |
   III           |               IV

   //Math.Sqrt(num);
   //A(x1,y1); B (x2,y2);
*/
  /* 
   double LongLine(int x1, int y1, int x2, int y2)
   {
    int x = x2- x1; 
    int y = y2- y1; 
    double lenghtAB = Math.Sqrt(x*x+y*y);
    return lenghtAB;
   }
   Console.WriteLine("Input x coordinat pf A:");
   int xA = Convert.ToInt32(Console.ReadLine());

   Console.WriteLine("Input x coordinat pf A:");
   int yA = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Input x coordinat pf B:");
   int xB = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Input x coordinat pf B:");
   int yB = Convert.ToInt32(Console.ReadLine());

Double dist = LongLine(xA, yA, xB, yB);
Console.WriteLine($"Distance AB is {dist}");
*/

//Напишите программу, которая принимает на вход число (N) 
// и выдает таблицу квадратов чисел от 1 до N.
//5 -> 1,4,9,16,25.
//2 - > 1,4

/*
void Qurd(int num)
{
     int current = 1;
     while (current <= num)
     {
        int res = current * current;
        Console.Write($"{res},_");
        current ++;
     }
     Console.WriteLine($"\b\b.");
} 

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >=1)
{
          Console.Write($"{number} -> ");
          Qurd (number);
}
else Console.WriteLine("Impossible number! ");
*/

//Zadacha
// Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

// не знаю как решить 

//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

//Math.Sqrt(num);
   //A(x1,y1); B (x2,y2); C (z1,z2)
/*
   double LongLine(int x1, int y1, int x2, int y2, int z1, int z2)
   {
    int x = x2 - x1; 
    int y = y2 - y1; 
    int z = z2 - z1;
    double lenghtAB = Math.Sqrt(x*x+y*y+z*z);
    return lenghtAB;
   }
   Console.WriteLine("Input x coordinat pf A:");
   int xA = Convert.ToInt32(Console.ReadLine());

   Console.WriteLine("Input x coordinat pf A:");
   int yA = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Input x coordinat pf B:");
   int xB = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Input x coordinat pf B:");
   int yB = Convert.ToInt32(Console.ReadLine());

   Console.WriteLine("Input x coordinat pf C:");
   int zA = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Input x coordinat pf C:");
   int zB = Convert.ToInt32(Console.ReadLine());

Double dist = LongLine(xA, yA, xB, yB, zA, zB);
Console.WriteLine($"Distance AB is {dist}");
*/

//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
/*
void Qurd(int num)
{
     int current = 1;
     while (current <= num)
     {
        int res = current * current *current;
        Console.Write($"{res},");
        current ++;
     }
    
} 

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >=1)
{
          Console.Write($"{number} -> ");
          Qurd (number);
}
else Console.WriteLine("Impossible number! ");
*/