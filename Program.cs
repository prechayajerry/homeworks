using System;
namespace workshopweek4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input Password : ");
            int password = int.Parse(Console.ReadLine());
            Console.Write("Please input Agency : ");
            string agency = Console.ReadLine();

            int pass_6 = password / 100000;
            int pass5 = password % 100000;
            int pass_5 = pass5 / 10000;
            int pass4 = password % 10000;
            int pass_4 = pass4 / 1000;
            int pass3 = password % 1000;
            int pass_3 = pass3 / 100;
            int pass2 = pass4 % 100;
            int pass_2 = pass2 / 10;
            int pass_1 = password % 10;

            if (agency == "CIA")
            {
                if (pass_4 >= 6 && pass_4 != 8)
                {
                    if (pass_2 != 1 && pass_2 != 3 && pass_2 != 5)
                    {
                        if (pass_1 % 3 == 0)
                        {
                            Console.Write("True");
                        }
                        else
                        {
                            Console.Write("Flase");
                        }
                    }
                    else
                    {
                        Console.Write("Flase");
                    }
                }
                else
                {
                    Console.Write("Flase");
                }
            }

            else if (agency == "FBI")
            {
                if (pass_6 == 4 || pass_6 == 5 || pass_6 == 6 || pass_6 == 7)
                {
                    if (pass_3 % 2 == 0 && pass_3 != 6)
                    {
                        if (pass_5 % 2 != 0)
                        {
                            Console.Write("True");
                        }
                        else
                        {
                            Console.Write("Flase");
                        }
                    }
                    else
                    {
                        Console.Write("Flase");
                    }
                }
                else
                {
                    Console.Write("Flase");
                }
            }

            else if (agency == "NSA")
            {

                if (pass_1 != 4 && pass_1 != 7 && pass_1 != 8)
                {
                    if (pass_3 == 3 || pass_3 == 9)
                    {
                        if (pass_1 == 7 || pass_2 == 7 || pass_3 == 7 || pass_4 == 7 || pass_5 == 7 || pass_6 == 7)
                        {
                            Console.Write("True");
                        }
                        else
                        {
                            Console.Write("Flase");
                        }
                    }
                    else
                    {
                        Console.Write("Flase");
                    }
                }
                else
                {
                    Console.Write("Flase");
                }
            }
            else
            {
                Console.Write("Flase");
            }
        }
    }
}

