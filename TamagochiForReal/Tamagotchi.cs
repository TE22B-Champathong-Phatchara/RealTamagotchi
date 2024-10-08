using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

public class Tamagotchi
{
    private int Hunger;
    private int Boredome;

    private int Affiliation;

    private List<string> words = new List<string> {"hai!", "HaLlo!"};
    private List<string> play = new List<string> {"You both played ball together.", "You both played a video game.", "You both had a fun time together."};
    private bool isAlive = true;
    public string name;

    public bool SongIsReady = false;

    private int EatCoolDown = 0;

    private void NoEat()
    {
        EatCoolDown--;
        if(EatCoolDown <= 0)
        {
            System.Console.WriteLine($"{name} is ready to eat!");
            EatCoolDown = 0;
        }
    }
    public void Feed()
    {
    
        List<string> Meals = new List<string> {"Ramen", "Pizza", "Sallad"};
        int RandomMeal = Random.Shared.Next(Meals.Count);

        if (EatCoolDown == 0)
        {
            System.Console.WriteLine($"Today's meal is {Meals[RandomMeal]}!");
            if (Meals.Count == 1)
            {
                Hunger = Hunger - Random.Shared.Next(5, 10);
            }
            if (Meals.Count == 2)
            {
                Hunger = Hunger - Random.Shared.Next(10,25);
            }
            if (Meals.Count == 3)
            {
                Hunger = Hunger - Random.Shared.Next(3,8);
            }

            if (Hunger > 0)
            {
                Hunger = 0;
            }
            EatCoolDown = 2;


            System.Console.WriteLine($"\n{name} ate {Meals[RandomMeal]}!\n");
        }
        else if (EatCoolDown == 2)
        {
            System.Console.WriteLine($"\n{name} don't want to eat anymore! Let's do something else.\n");
        }
        

    }
    public void Hi()
    {
        int LetsPlay = Random.Shared.Next(play.Count);
        System.Console.WriteLine(play[LetsPlay]);
        System.Console.WriteLine($"You feel a bond with [{name}]");
        System.Console.WriteLine($"\n[{name}] want to say something!");
        Affiliation = Affiliation + Random.Shared.Next(10,30);
        if (Affiliation > 100)
        {
            Affiliation = 100;
        }
        Thread.Sleep(1000);
        int WordToSay = Random.Shared.Next(words.Count);
        Console.WriteLine($"'{words[WordToSay]}' said [{name}]!");
        NoEat();
        ReduceBoredom();
    }
    public void Teach(string wordToTeach)
    {
        Console.WriteLine($" [{name}] learns: {wordToTeach}!");
        words.Add(wordToTeach);
        NoEat();
    }
    public void Tick()
    {
        Boredome = Boredome + Random.Shared.Next(9,13);
        Hunger = Hunger + Random.Shared.Next(7,12);
        

        if (Boredome > 100 || Hunger > 100)
        {
            isAlive = false;
        }
    }
    public void PrintStat()
    {
        System.Console.WriteLine($"Name: [{name}] | Hunger: [{Hunger}] | Boredom : [{Boredome}] | Volcabulary: [{words.Count}] | Affiliation: [{Affiliation}]");
    }
    public bool GetAlive()
    {
        return isAlive;
    }
    private void ReduceBoredom()
    {
        int R = Random.Shared.Next(15,25);
        if (R > Boredome)
        {
            Boredome = R - Boredome;
        }
        else if (R < Boredome)
        {
            Boredome = Boredome - R;
        }

        if(Boredome < 0)
        {
            Boredome = 0;
        }
        if (Boredome <= 20)
        {
            System.Console.WriteLine($"\n{name} is felling happy right now!\n");
        }
        else if (Boredome > 20 && Boredome <= 50)
        {
            System.Console.WriteLine($"\n{name} wants to do somthing...\n");
        }
        else if (Boredome > 50 && Boredome <= 90)
        {
            System.Console.WriteLine($"\n{name} is really boring right now. If you don't do something IT will actually die of tediousness!!!\n");
        }
        
    }
    public void SingASong()
    {
        
        if(Affiliation >= 90)
        {
            SongIsReady = true;
            System.Console.WriteLine($"[5] to Let [{name}] sing a song.");
        }
    }
    public void AREuSURE()
    {
        string Command = Console.ReadLine().ToLower();

        while(true)
        {
            if (Command.Contains('y'))
            {
                Console.Clear();
                System.Console.WriteLine($"[{name}] picked up the microphone!\n");
                while(true)
                {
                    System.Console.WriteLine("Shikanokonokonokokoshitantan");
                    Console.ReadLine();
                }
            }
            else
            {
                break;
            }
        }
    }

}
