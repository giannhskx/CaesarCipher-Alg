using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
                                           'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
                                           'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("write a message to encrypt: ");
            string userInputMessage = Console.ReadLine();
            char[] secretMessage = userInputMessage.ToCharArray();

            char[] encryptedMessage = new char[secretMessage.Length];
            for (int i = 0; i < secretMessage.Length; i++)
            {
                if (!char.IsLetter(secretMessage[i]))
                {
                    encryptedMessage[i] = secretMessage[i];
                    continue;
                }
                int index = Array.IndexOf(alphabet, secretMessage[i]);
                Console.WriteLine(index);
                int plusThree = (index + 3) % alphabet.Length;
                Console.WriteLine(plusThree);
                encryptedMessage[i] = alphabet[plusThree];

            }
            string messageString = String.Join("", encryptedMessage);
            Console.WriteLine(messageString);

        }
    }
}

