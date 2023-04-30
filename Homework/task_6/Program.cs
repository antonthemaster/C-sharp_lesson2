string user_input = Console.ReadLine();
if(user_input.Length > 1){
    Console.Write($"{user_input} -> {user_input[1]}");
}
else{
    Console.WriteLine("nope");
}
