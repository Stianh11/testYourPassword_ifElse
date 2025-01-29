namespace testYourPassword;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        int length = password.Length;

        if(length<4)
        {
            Console.WriteLine("that's not even a password, are you stupid?");
        }
        else if(length<=8)
        {
            Console.WriteLine("That's weak bro!");
        }
        else if(length<=16)
        {
            Console.WriteLine("that's allright");
        }
        else if(length<=30)
        {
            Console.WriteLine("that's strong mæn!");
        }
        else Console.WriteLine("Fucking Legend!");
    }
}
