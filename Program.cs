// 10
Console.Clear();
int n =  new Random().Next(0, 1000); // [0, 999]
int n1 = n / 100; // 987 / 100 = 9
int n2 = n % 10; // 987 % 10 = 7
Console.WriteLine($"Число: {n}");
Console.WriteLine($"Новое Число: {n1 * 100 + n2}");