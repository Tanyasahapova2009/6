Console.WriteLine("Выберите задание:");
Console.WriteLine("Задача 1. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.WriteLine("Задание 2. точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
int n = Convert.ToInt32(Console.ReadLine());
switch (n)
{
    case 1:
      Task1();
      break;
    case 2:
     Task2();
     break;
   
      default:
      break;
}
void Task1()
{
   Console.WriteLine("Введите числа через пробел");
   String[] arraystr = Console.ReadLine().Split(' ');
   int[] array = new int[arraystr.Length];
   for (int i=0; i < arraystr.Length; i++) array[i] = Convert.ToInt32(arraystr[i]);
   Console.WriteLine(NPN(array));
}

int NPN (int[] array)

{
    int a = array.Length;
    int sum=0;
    for (int i=0; i<a; i++)
    {
        if (array[i] > 0)
        {
            sum ++;
        }
    }
    return sum;
}

void Task2()
{
  Console.WriteLine("k1");
  int k1 = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("b1");
  int b1 = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("k2");
  int k2 = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("b2");
  int b2 = Convert.ToInt32(Console.ReadLine());
   
  float a = b2*k1;
  float c = k2*b1;
   float y = ((a-c)/(k1-k2));
   float x = ((y-b1)/k1);
   Console.WriteLine($"Прямые пересекаются в точке с координатами х={x}, y={y}");
}

