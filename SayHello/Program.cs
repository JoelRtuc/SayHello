class Program
{
    static void Main()
    {
        Console.WriteLine("Skriv ditt namn: ");
        SayHello(Console.ReadLine());

        void SayHello(string name)
        {
            Console.WriteLine("Hej " + name + " välkommen till programmet!");

        }
    }
}
