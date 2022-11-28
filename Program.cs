//Напишите программу, которая принимает на вход число(А)
//и выдает сумму чисел от 1 до А

/*void metFindSum(int a)
{
    int summa = 0;
    for(int current = 1; current <= a; current++)
    {
        summa += current; // summa = summa + current
    }
    Console.WriteLine($"Summa of elements from 1 to {a} is {summa}");
}

Console.WriteLine("Input your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());
metFindSum(user_num);
*/
//int /double, bool/ Met2(){...return a;}
/*
int MetFindSum2(int a)
{
    int summa = 0;
    for (int current = 1; current <= a; current++)
    {
        summa += current;
    }
    return summa;
}
Console.WriteLine("Input your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());
int result = MetFindSum2(user_num);
Console.WriteLine($"Summ of elements from 1 to {user_num} is {result}");
*/

//Программа которая принимает на вход число и выдает количество цифр в числе.

/*int CountOfDigit(int number)
{
    int current = 1;
    while (number >= 10)
    {
        current++;
        number = number/10;
    }
    return current;
}
Console.WriteLine("Input number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

int count_digit;
int user_num1 = (-1) * user_num;
if (user_num >= 0)
    count_digit = CountOfDigit(user_num);
else    
    //user_num *= (-1);  //+= *= -= обозначение нашего числа user_num *(-1)...
    count_digit = CountOfDigit(user_num1);
Console.WriteLine($"Entered number {user_num} -> {count_digit}");
*/

//Программа, которая принимает на вход число N и выдает произведение чисел от 1 до N

/*void Factorial(int n)
{
    int multi = 1;
    for(int cur = 1; cur <= n; cur++)
    {
        multi *= cur;
    }
    Console.WriteLine($"{n} -> {multi}");
}
Console.WriteLine("input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    while (number < 0)
    {
        Console.WriteLine("input Positive int number");
        number = Convert.ToInt32(Console.ReadLine());
    }
    
}
Factorial(number);
*/

//напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.

/*int [] CreatNewArray(int size, int min, int max)
{
    int [] array = new int[size]; // int(1) тип данных массива []array - имя массива new int(размер массива)
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1); 
    return array;
}
void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.Write("input count of elements: ");
int count_of_elem = Convert.ToInt32(Console.ReadLine());

Console.Write("input max value of elements: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.Write("input min value of elements: ");
int minValue = Convert.ToInt32(Console.ReadLine());

int [] array1 = CreatNewArray(count_of_elem, minValue, maxValue);
ShowArray(array1);

//ShowArray(CreatNewArray(count_of_elem));
*/

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*
void digit (int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

Console.Write("input number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("input number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
//int result = digit; Что дальше?
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*
int summNumber(int a)
{
    int sum = 0;
    while (a > 0)
    {
        sum = sum + a % 10;
        a = a / 10;
    }
    return sum;    
}
Console.WriteLine("Input your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());
int result = summNumber(user_num);
Console.WriteLine($"Summ of elements from 1 to {user_num} is {result}");
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
/*
int [] CreatArray(int size)
{
    int [] array = new int[size]; 
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(size +1);    
    return array;
}
void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.Write("input count of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array1 = CreatArray(size);
ShowArray(array1);

*/
