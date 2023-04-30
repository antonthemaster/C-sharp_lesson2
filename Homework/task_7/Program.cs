string user_input = Console.ReadLine();
if(user_input.Length > 2){
    Console.Write($"{user_input} -> {user_input[2]}");
}
else{
    Console.WriteLine($"{user_input} -> There's no third digit.");
}
