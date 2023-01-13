// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
System.Console.WriteLine("input number ");
int num = System.Convert.ToInt32(System.Console.ReadLine());

if (num % 2 == 0) {
    System.Console.WriteLine($"{num} - even");
}
else {
    System.Console.WriteLine($"{num} - odd");
}
