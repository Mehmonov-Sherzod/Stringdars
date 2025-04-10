public class program
{


    public static void Main(string[] args)
    {
        Console.Write("matn krit:");
        string name = Console.ReadLine();


        string[] str = name.Split(new char[] { ' '});

     int summa = str.Length ;


        Console.Write(summa);




    }

}