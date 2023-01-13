// Напишите программу, которая на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
System.Console.WriteLine("input number ");
int num = System.Convert.ToInt32(System.Console.ReadLine());

int i = 0;
while (i < num - 1) {
    i += 2;
    System.Console.Write($"{i},");
}
