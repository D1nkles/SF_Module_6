class Bus
{
    public int? Load;
    public void PrintStatus()
    {
        if (Load > 0) 
        {
            Console.WriteLine($"В автобусе {Load} пассажиров.");
        }
        else 
        {
            Console.WriteLine("В автобус пуст.");
        }
    }
}

class Program 
{
    static void Main(string[] args) 
    {
        var bus = new Bus() { Load = 5 };
        bus.PrintStatus();
    }
}