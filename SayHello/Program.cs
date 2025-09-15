class Program
{
    static void Main()
    {
        SayHello(Console.ReadLine());

        void SayHello(string name)
        {
            Console.WriteLine("Hej " + name + " välkommen till programmet!");
        }
    }
}
