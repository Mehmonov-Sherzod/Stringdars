public class program
{


    public static void Main(string[] args)
    {

      string name = Console.ReadLine();

        string str = " ";

        for (int i = 0; i < name.Length; i++) {

            if (name[i] == ' ')
            {


            }

            else
            {

                str += name[i];
            }


        }

        Console.WriteLine(str);




    }

}