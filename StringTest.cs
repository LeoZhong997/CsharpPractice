using System;

namespace StringApplication
{
    public class StringTest
    {
        static void Main1(string[] args)
        {
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";

            string fullname = fname + lname;
            Console.WriteLine("Full name: {0}", fullname);

            char[] letters = {'H', 'e', 'l', 'l', 'o'};
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);

            string[] sarray = {"Hello", "From", "Tutorials", "Point"};
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            DateTime waiting = new DateTime(2020, 9, 28, 17, 58, 10);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Chat Message: {0}", chat);

            string str1 = "This is test";
            string str2 = "This is text";
            string str3 = str2.Substring(3);
            Console.WriteLine(str3);

            if(String.Compare(str1, str2) == 0)
            {
                Console.WriteLine("{0} and {1} is equal.", str1, str2);
            }
            else
            {
                Console.WriteLine("{0} and {1} is not equal.", str1, str2);
            }

            string[] strarr = new string[]{"Down the way nights are dark",
                "And the sun shines daily on the mountain top",
                "I took a trip on a sailing ship",
                "And when I reached Jamaica",
                "I made a stop"};
            string str4 = String.Join("\n", strarr);
            Console.WriteLine(str4);

            Console.ReadLine();
        }
    }
}