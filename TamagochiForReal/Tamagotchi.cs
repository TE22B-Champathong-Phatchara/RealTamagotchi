public class Tamagotchi
{
    private int Hunger;
    private int Boredome;
    private List<string> words;
    private bool isAlive = true;
    private Random generator;
    public string name;



    public void Feed()
    {

    }
    public void Hi()
    {

    }
    public void Teach(string word)
    {

    }
    public void Tick()
    {
        Boredome = Boredome + Random.Shared.Next(12,20);
        Hunger = Hunger + Random.Shared.Next(7,15);

        if (Boredome > 100 || Hunger > 100)
        {
            isAlive = false;
        }
    }
    public void PrintStat()
    {

    }
    public bool GetAlive()
    {
        return true;
    }
    private void ReduceBoredom()
    {
        Boredome = Boredome - Random.Shared.Next(10,25);
        
        if (Boredome <= 20)
        {
            System.Console.WriteLine($"\n{name} is felling happy right now!\n");
        }
        else if (Boredome > 20 && Boredome <= 50)
        {
            System.Console.WriteLine($"\n{name} wants to do somthing...\n");
        }
        else if (Boredome > 50 && Boredome <= 90)
        {}
    }
}
