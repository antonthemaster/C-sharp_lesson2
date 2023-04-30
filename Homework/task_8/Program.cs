string user_input = Console.ReadLine();
if(Convert.ToInt32(user_input) < 1 | Convert.ToInt32(user_input) > 7){
    if(user_input == "6" | user_input == "7"){
    Console.WriteLine("That's it. It's a day off.");
    }
    else{
        Console.WriteLine("Not a day off.");
    }
}
else{
    Console.WriteLine("Out of range.");
}



