Console.Write("Enter fisrt digit: ");
int fst_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second digit: ");
int scd_num = Convert.ToInt32(Console.ReadLine());

if(fst_num % scd_num == 0){
    Console.WriteLine("Hunky, funny word, haha!");
}
else if(scd_num % fst_num == 0){
    Console.WriteLine("Hunky, funny word, haha!");
}
else{
    Console.WriteLine("\nBoth digits wrong..");
    Console.WriteLine($"Modulo 1: {fst_num % scd_num}");
    Console.WriteLine($"Modulo 2: {scd_num % fst_num}");
}
