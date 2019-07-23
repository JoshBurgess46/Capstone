using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Pig Latin Translator.");
            bool go = true;
            while (go)
            {
                Console.WriteLine("Enter a phrase!");
                string userInput = Console.ReadLine().ToLower();
                string[] phrase = UserPhrase(userInput);
                Translate(phrase);
                Console.WriteLine();
                go = RunAgain("");
            }
            Console.ReadKey();
        }
        public static void Translate(string[] phrase)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (string item in phrase)
            {
                int instance1 = item.IndexOfAny(vowels);
                if(instance1 == 0)
                {
                    string word1 = Vowels(item);
                    Console.Write(word1);
                }
                else if(instance1 > 0)
                {
                    string word2 = Constanants(item, instance1);
                    Console.Write(word2);
                }
                else
                {
                    Console.Write(item);
                }
            }
        }
        public static string[] UserPhrase(string message)
        {
            return message.Split(' ');
        }
        public static string Vowels(string word)
        {
            return word + "way ";
        }
        public static string Constanants(string word, int index)
        {
            string varName = word.Substring(0, index);
            string wholePhrase = word.Substring(index);
            return wholePhrase + varName + "ay ";
        }
        public static bool RunAgain(string message)
        {
            string userInput = "afdsafs";
            while (userInput != "y" && userInput != "n")
            {
                Console.WriteLine("Run again? y/n");
                userInput = Console.ReadLine().ToLower();
            }
            if (userInput == "y")
            {
                return true;
            }
            else if(userInput =="n")
            {
                Console.WriteLine("Good-Bye!");
                return false;
            }
            else
            {
                return RunAgain("invalid input");
            }
        }
    }
}
