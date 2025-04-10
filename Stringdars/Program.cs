public class program
{


    public static void Main(string[] args)
    {
        Console.Write("matn krit:");
      string name = Console.ReadLine();
        char C = Convert.ToChar(Console.ReadLine());

        int summa = 0;

        for (int i = 0; i < name.Length; i++) {

            if (name[i] == C)
            {
                summa++;

            }

           

        }

        Console.WriteLine(summa);




    }

}