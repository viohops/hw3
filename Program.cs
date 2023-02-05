// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.Write("Введите число: ");
string a = Console.ReadLine();
char[] arr = a.ToCharArray();
Array.Reverse(arr);
string b = new string(arr);

if(a == b){
    System.Console.WriteLine("Число является палиндромом");
}
else{
    System.Console.WriteLine("Не является палиндромом");
}