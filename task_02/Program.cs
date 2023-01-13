// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
System.Console.WriteLine("input first number: ");
int num_1 = System.Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("input second number: ");
int num_2 = System.Convert.ToInt32(System.Console.ReadLine());

if (num_1 > num_2) {
    System.Console.WriteLine($"max: {num_1}");            
}
else if (num_1 == num_2) {
    System.Console.WriteLine($"first number: {num_1} = second number: {num_2}");
}
else {
    System.Console.WriteLine($"max: {num_2}");
}
