using System;
using System.Linq;
using System.Text.RegularExpressions;



namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tryagain = true;
            while (tryagain == true)
            {
                

                    string[] cats2 = new string[4] { "name", "email", "date", "phone number" };
                    foreach (string cat in cats2)
                    {
                    bool result = false;
                    while (result == false)
                    {
                     result = RegexIndex(cat);

                    }

                    }

               tryagain = Proceed();
            }
        }
            public static bool RegexIndex(string cat)
            {

            Regex nameRX = new Regex(@"^[A-Z][a-z]{1,30}? [A-z]{0,30}$");
            Regex emailRX = new Regex(@"^([A-z0-9]{5,10})+@+([A-z0-9]{5,10})+\.+([A-z]{2,3})$");
            Regex dateRX = new Regex(@"\d{2}\/\d{2}\/\d{4}$");
            Regex numberRX = new Regex(@"^[1-9]{1}[0-9]{2}-[0-9]{3}-[0-9]{4}");
            string[] inputformat = new string[4] { "Start with capital letter. Max length 30",
                "Should contain between 5 and 30 letters, with an @ sign, site addess should contain between 5 and 10 non special characters, domain should contain 2 or 3 characters",
                "Phone number should be in format 111-111-1111. Area codes do not start with 0.",
                "Date should be formatted mm/dd/yyyy"};
            Regex[] currentRX = new Regex[4] { nameRX, emailRX, dateRX, numberRX };
            int i = 0;
            if (cat.Contains("name"))
            {
                i = 0;
            }
            if (cat.Contains("email"))
            {
                i = 1;
            }
            if (cat.Contains("date"))
            {
                i = 2;
            }
            if (cat.Contains("phone"))
            {
                i = 3;
            }
                Console.WriteLine($"Please enter {cat} here: ");
                string word = Console.ReadLine();
                if (Regex.IsMatch(word, $"{ currentRX[i]}"))
                {
                Console.WriteLine($"{cat} is valid!");
                    return true;
                }
                else
                {
                Console.WriteLine($"{word} is not valid for {cat}. Please try again.");
                string details = inputformat[i];
                Console.WriteLine( details);
                    return false;
                }
            }


        public static bool Proceed()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to continue? (y/n) ");
            string proceed = Console.ReadLine().ToLower();
            if (proceed.StartsWith("y"))
            {
                return true;
            }
            if (proceed.StartsWith("n"))
            {
                Console.WriteLine("thank you!");
                Console.WriteLine();
                return false;
            }
            else
            {
                Console.WriteLine("Invalid entry. Please try again");
                return Proceed();
            }
        }



    }
    }
 



