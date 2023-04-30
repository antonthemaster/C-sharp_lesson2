Console.Write("Enter fisrt digit: ");
int fst_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second digit: ");
int scd_num = Convert.ToInt32(Console.ReadLine());

if(scd_num == fst_num * fst_num){
    Console.WriteLine("Yes");
}
else if(fst_num == scd_num * scd_num){
    Console.WriteLine("Yes");
}
else{
    Console.WriteLine("No");
}
