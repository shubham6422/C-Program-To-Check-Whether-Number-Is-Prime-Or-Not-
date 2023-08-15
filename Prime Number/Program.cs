// See https://aka.ms/new-console-template for more informationConsol

public class calculation
{
    static void calculate(int num)
    {
        if (num == 0)
        {
            Console.WriteLine("Number is Zero");
        }
        else
        {
            int result = num % 2;

            if (result == 0)
            {
                Console.WriteLine("Number Is Prime");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("If you want to exit type y");
                string ans = Console.ReadLine();
                ans.ToLower();
                if (ans=="y") 
                { 
                    Environment.Exit(0);    
                }
                else
                {
                    Main();
                }

                

            }
            else
            {
                Console.WriteLine("Number Is Not Prime");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("If you want to exit type y");
                string ans = Console.ReadLine();
                ans.ToLower();
                if (ans == "y")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Main();
                }
            }
        }

    }

    static void Main()
    {
        Console.WriteLine("Enter A Number to Check Prime Or Not?");
        int num = Convert.ToInt32(Console.ReadLine());
        calculate(num);
    }


}




