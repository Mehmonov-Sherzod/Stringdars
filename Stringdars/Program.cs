public class program
{


    public static void Main(string[] args)
    {
        Console.Write("matn krit:");
        string name = Console.ReadLine();

        bool str = false;

       

        for (int i = 0; i <= name.Length -5; i++)
        {

            if (name.Substring(i , 5) == "hello") str = true;
           


        }

        Console .WriteLine(str);


    }

}