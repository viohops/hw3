// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// System.Console.Write("Введите число: ");
// string a = Console.ReadLine();
// char[] arr = a.ToCharArray();
// Array.Reverse(arr);
// string b = new string(arr);

// if(a == b){
//     System.Console.WriteLine("Число является палиндромом");
// }
// else{
//     System.Console.WriteLine("Не является палиндромом");
// }




// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// int InputNumber(string str)
// {
//     System.Console.WriteLine(str);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int x1 = InputNumber("Введите координату Х1: ");
// int y1 = InputNumber("Введите координату Y1: ");
// int z1 = InputNumber("Введите координату Z1: ");

// int x2 = InputNumber("Введите координату Х2: ");
// int y2 = InputNumber("Введите координату Y2: ");
// int z2 = InputNumber("Введите координату Z2: ");

// System.Console.WriteLine(Math.Round(Math.Pow(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2),0.5),2));




// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(" ");
for(int i = 1; i<=a; i++){
    System.Console.Write(Math.Pow(i, 3) + " ");
    
}