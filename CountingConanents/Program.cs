using System;

namespace CountingConanents
{
    class Program
    {
        public static string Rev_Special_Chars(string str)
        {

            string[] chars = new string[] { ",", ".", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'", "\"", ";", "_", "(", ")", ":", "|", "[", "]" };

            for (int i = 0; i < chars.Length; i++)
            {
                if (str.Contains(chars[i]))
                {
                    str = str.Replace(chars[i], "");
                }
            }
            return str;
        }
        static void Main(string[] args)
        {

            while (true) 
            {
                string user_String;
                int vow_Count = 0;
                int con_Count = 0;
                

                Console.WriteLine("Please enter a string");
                user_String = Console.ReadLine().ToLower();

                //By adding special characters into the replace method I could makes sure that they're counted too!
                string mod_string = user_String.Replace(" ", string.Empty);
                string final_string = Rev_Special_Chars(mod_string);




                foreach (char v in final_string)
                {
                    if (v == 'a' || v == 'e' || v == 'i' || v == 'o' || v == 'u')
                    {
                        vow_Count++;
                    }
                    else
                    {
                        con_Count++;
                    }

                }

                Console.WriteLine("The number of consonants = " + con_Count);
                Console.WriteLine("Would you like to input another word? Y or N");
                string user_Choice = Console.ReadLine().ToLower();

                if (user_Choice == "n")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
        }
    }
}
