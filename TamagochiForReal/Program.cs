
System.Console.WriteLine("Welcome to Tamagotchi!");
System.Console.WriteLine("Enter a name for your Tamagotchi!:\n");

Tamagotchi NewTama = new Tamagotchi();
while(true)
{
    NewTama.name = Console.ReadLine();
    if(string.IsNullOrWhiteSpace(NewTama.name))
    {
        System.Console.WriteLine("\nYour Tamagotchi name can't be empty!\n");
        continue;
    }
    else
    {
        break;
    }
}


System.Console.WriteLine($"\nSo! {NewTama.name} is it? Please take care IT carefully!!");
Thread.Sleep(3000);

while(NewTama.GetAlive() == true)
{
    Console.Clear();
    System.Console.WriteLine($"Here you can see {NewTama.name}:\n");
    NewTama.PrintStat();
    System.Console.WriteLine("\nWhat you want to do?\n");
    System.Console.WriteLine("________________________________________");
    System.Console.WriteLine($"\n[1] to Teach [{NewTama.name}] a word.");
    System.Console.WriteLine($"[2] to Play with [{NewTama.name}]. This will reduce [{NewTama.name}]'s tediousness.");
    System.Console.WriteLine($"[3] to Feed [{NewTama.name}]. Don't let it starving.");
    System.Console.WriteLine($"[4] to Do nothing. Leave it be.\n");

    string Command = Console.ReadLine();

    if (Command == "1")
    {
        System.Console.WriteLine($"\n[{NewTama.name}] made an interesting face. It seems exicted to learn a word!");
        System.Console.Write($"What are you going to teach[{NewTama.name}]?:  ");
        string wordToTeach = Console.ReadLine();
        NewTama.Teach(wordToTeach);
    }
    if (Command == "2")
    {
        NewTama.Hi();
    }
    if (Command == "3")
    {
        NewTama.Feed();
    }
    else
    {
        System.Console.WriteLine("You didn't do anything...");
    }

    NewTama.Tick();
    System.Console.WriteLine("\n[Enter] to continue\n");
    Console.ReadLine();


}

Console.WriteLine($"{NewTama.name} is tired of its owner and passed away without leaving traces...");
Console.WriteLine("Press ENTER to quit");
Console.ReadLine();