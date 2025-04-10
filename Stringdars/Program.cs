public class program
{


    public static void Main(string[] args)
    {
        Console.Write("matn krit:");
        string name = Console.ReadLine();


        string[] str = name.Split(" ");

        string strt = " ";


        Console.Write(" ");
        foreach (string st in str)
        {

            Console.WriteLine(st);

            if (st.Length > strt.Length)
            {

                strt = st;
            }



        }


        Console.WriteLine(" eng kattasi:");
        Console.Write(strt);



    }

}