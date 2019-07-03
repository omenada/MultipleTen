using System;

namespace tenmultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int result;
          

            Console.WriteLine("\n" + "Digit your number" + "\n");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("\n" + "Result =" + "\n");

                for (int i = 1; i <= 10; i++)

                {
                    result = n * i;
                    Console.WriteLine(i + " X " + n + " = " + result);

                }

                Continue();
            
            
        }

        static void Continue( )
        {
            string flag;

            Console.WriteLine("\n" + "Do you want to write another number? (Y)YES or (N)Exit " + "\n");
            flag = Console.ReadLine();

            if (flag == "N")
            {
                System.Environment.Exit(0);
            }
            else
            {
                Main(null);
            }

        }
    }
}





        
    

