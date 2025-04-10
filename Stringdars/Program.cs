public class program
{


    public static void Main(string[] args)
    {
        Console.Write("matn krit:");
      string name = Console.ReadLine();


        string[] str = name.Split();

        

        for (int i = 0; i < str.Length; i++) {


            Console.WriteLine(str[i]);



        }





    }

}