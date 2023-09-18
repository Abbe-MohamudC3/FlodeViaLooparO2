namespace FlodeViaLooparO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
       

            while (true)
            {
                ShowMainMeny();
                Console.WriteLine("## Gör ett val från menyn: ## ");

                switch (Console.ReadLine())
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        YoungOrRetired();
                        break;
                    case "2":
                        GruppPrise();
                        break;
                    case "3":
                       RepeatTenTimes();
                        break;
                    case "4":
                       PrintThirdWord(); 
                        break;
                    default:
                        Console.WriteLine("Gör ett giltigt val: ");
                        break;
                }
            }
        }

       

        private static void ShowMainMeny()
        {
            Console.WriteLine("###################");
            Console.WriteLine("#### Main Menu ####");
            Console.WriteLine("###################");
            Console.WriteLine("0. Avsluta");
            Console.WriteLine("1. Pris för en person");
            Console.WriteLine("2. Pris för ett sällskap");
            Console.WriteLine("3. Upprepa tio gånger");
            Console.WriteLine("4. Det tredje ordet");
            
            
        }

        // Ungdom eller pensionär, Case 1 
        // Programmet tar en persons ålder och berättar sedan pridet för den individen 
        private static void YoungOrRetired()
        {
            bool success = false;

            while (!success)
            {
                Console.WriteLine("Skriv din ålder");
                success = int.TryParse(Console.ReadLine(), out int age);

                if (!success)
                {
                    Console.WriteLine("Var vänlig ange giltigt värde: ");
                    continue;
                }
                if (age < 20)
                {
                    Console.WriteLine("Ungdomspris: 80kr");
                }
                else if (age > 64)
                {
                    Console.WriteLine("Pensionärspris:90kr");
                }
                else
                {
                    Console.WriteLine("Standardprid: 120kr");
                }

        
            }
            

            
        }
        
        // Pris för att sällskap, Case 2
        // Programmet tar en flera åldrar och anger sedan totala priset
        private static void GruppPrise()
        {
            throw new NotImplementedException();
        }


        // Upprepa 10 gånger, Case "3"
        private static void RepeatTenTimes()
        {
            Console.WriteLine("Skriv en text den ska upprepas 10 gånger");
            Console.WriteLine("Skriv din text? ");

            string text = Console.ReadLine();

            for (int i = 0; i <= 25; i++)
            {
                Console.Write(text);
            }
        }

        // Det tredje ordet, Case 4 
        // Programmet tar en sträng och skriver ut det tredje ordet om tre ord eller fler har skrivits
        private static void PrintThirdWord()
        {
            Console.WriteLine("Skriv text med minst tre ord: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            if (words.Length < 3)
            {
                Console.WriteLine("Skriv 3 ord eller mer");
            }

            else
            {
                string tredjeOrdet = words[2]; 
                Console.WriteLine($"Det tredje ordet är: {tredjeOrdet}");
            }
        }

         
       
    }
}