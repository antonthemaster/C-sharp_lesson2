int number = new Random().Next(100, 1000);
int new_number = number / 100 * 10 + number % 100;

Console.WriteLine($"{number} -> {new_number}");
