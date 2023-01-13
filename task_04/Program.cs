// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
System.Console.WriteLine("input first number ");
int num_1 = System.Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("input second number ");
int num_2 = System.Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("input third number ");
int num_3 = System.Convert.ToInt32(System.Console.ReadLine());

int max = num_1;

if (num_2 > max) {
    max = num_2;
}

if (num_3 > max) {
    max = num_3;
}

System.Console.WriteLine($"max: {max}");
