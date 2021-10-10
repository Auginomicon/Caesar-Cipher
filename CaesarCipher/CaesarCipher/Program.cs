using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            // Save the alphabet into a string variable
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // Display title
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("                     Caesaer Cipher!                     ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

            bool isRunning = true;
            
            while (isRunning)
            {
                Console.WriteLine("What would you like to do? 1.Encode 2.Decode 3.Quit");
                string userInput = Console.ReadLine();

                int.TryParse(userInput, out int n);

                switch (n)
                {
                    case 1:
                        {
                            while (true)
                            {
                                Console.WriteLine("Please input a valid sentence for encoding! (no numbers or unique characters)");
                                userInput = Console.ReadLine();

                                if (!Regex.IsMatch(userInput, @"^[a-zA-Z\s*]+$"))
                                {
                                    Console.WriteLine("This is not a valid sentence");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    string encodedSentence = "";
                                    userInput = userInput.ToUpper();
                                    for (int i = 0; i < userInput.Length; i++)
                                    {
                                        int alphabetIndex = alphabet.IndexOf(userInput[i]);
                                        if (alphabetIndex <= 22 && !Char.IsWhiteSpace(userInput[i]))
                                        {
                                            encodedSentence += alphabet[alphabetIndex + 3];
                                        }
                                        else if (alphabetIndex == 23 && !Char.IsWhiteSpace(userInput[i]))
                                        {
                                            encodedSentence += alphabet[0];
                                        }
                                        else if (alphabetIndex == 24 && !Char.IsWhiteSpace(userInput[i]))
                                        {
                                            encodedSentence += alphabet[1];
                                        }
                                        else if (alphabetIndex == 25 && !Char.IsWhiteSpace(userInput[i]))
                                        {
                                            encodedSentence += alphabet[2];
                                        }
                                        else
                                        {
                                            encodedSentence += " ";
                                        }
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("Encoded Message: "+ encodedSentence.ToLower());                                 
                                }

                                Console.WriteLine("Press enter to encode another. Press N or n to go back to the menu.");
                                userInput = Console.ReadLine();
                                Console.WriteLine();
                                if (userInput.ToLower() == "n")
                                {
                                    break;
                                }
                            }                
                            break;
                        }
                    case 2:
                        {
                            while (true)
                            {
                                Console.WriteLine("Please input a valid sentence for decoding! (no numbers or unique characters)");
                                userInput = Console.ReadLine();

                                if (!Regex.IsMatch(userInput, @"^[a-zA-Z\s*]+$"))
                                {
                                    Console.WriteLine("This is not a valid sentence");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    string encodedSentence = "";
                                    userInput = userInput.ToUpper();
                                    for (int i = 0; i < userInput.Length; i++)
                                    {
                                        int alphabetIndex = alphabet.IndexOf(userInput[i]);
                                        if (alphabetIndex >= 3 && !Char.IsWhiteSpace(userInput[i]))
                                        {
                                            encodedSentence += alphabet[alphabetIndex - 3];
                                        }
                                        else if (alphabetIndex == 2 && !Char.IsWhiteSpace(userInput[i]))
                                        {
                                            encodedSentence += alphabet[25];
                                        }
                                        else if (alphabetIndex == 1 && !Char.IsWhiteSpace(userInput[i]))
                                        {
                                            encodedSentence += alphabet[24];
                                        }
                                        else if (alphabetIndex == 0 && !Char.IsWhiteSpace(userInput[i]))
                                        {
                                            encodedSentence += alphabet[23];
                                        }
                                        else
                                        {
                                            encodedSentence += " ";
                                        }
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("Encoded Message: " + encodedSentence.ToLower());
                                }

                                Console.WriteLine("Press enter to decode another. Press N or n to go back to the menu.");
                                userInput = Console.ReadLine();
                                Console.WriteLine();
                                if (userInput.ToLower() == "n")
                                {
                                    break;
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            isRunning = false;
                            Console.WriteLine("Thank you for using this program.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please put a valid input");
                            break;
                        }
                }
            }
        }
        public static void Method()
        {

        }
    }
}
