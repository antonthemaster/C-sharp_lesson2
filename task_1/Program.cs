int number = new Random().Next(10, 100);
int digit = number % 10;
int decade = (number - digit) / 10;

Console.WriteLine(number);
Console.WriteLine(decade);
Console.WriteLine(digit);

if(decade > digit){
    Console.WriteLine($"The biggest digit is:{decade}");
}
else if(digit > decade){
    Console.WriteLine($"The biggest digit is:{digit}");
}
else{
    Console.WriteLine("Our digits are equal.");
}
