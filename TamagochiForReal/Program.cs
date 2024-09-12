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
    
}