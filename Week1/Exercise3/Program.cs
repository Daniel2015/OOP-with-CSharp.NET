/*
Problem No. 3
A company wants to transmit data over the telephone, but they are concerned that
their phones may be tapped. All their data is transmitted as four-digit Integers.
They have asked you to write a program that encrypts their data so that it may be
transmitted more securely. Your program should read a four-digit Integer entered
by the user and encrypt it as follows: Replace each digit by (the sum of that digit plus 7) modulo 10.
Then swap the first digit with the third, and swap the second digit with the fourth.
Print the encrypted Integer. Write a method that inputs an encrypted four-digit Integer
and another method that decrypts it to form the original number.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Exercise3
    {

        public static int EncryptInteger(int data) //Method to encrypt the given Integer
        {
            int digit1; //Declaring first digit of the four-digit Integer to be encrypted
            int digit2; //Declaring second digit of the four-digit Integer to be encrypted
            int digit3; //Declaring third digit of the four-digit Integer to be encrypted
            int digit4; //Declaring fourth digit of the four-digit Integer to be encrypted
            int digitHolder; // Temporary holder to swap the digits
            int encryptedInteger; //Storing the Integer after encryption

            digit1 = data / 1000; //First digit of entered Integer
            digit2 = (data / 100) % 10; //Second digit of entered Integer
            digit3 = (data / 10) % 10; //Third digit of entered Integer
            digit4 = data % 10; //Fourth digit of entered Integer

            //First step of encryption: (the sum of the given digit plus 7) modulo 10
            digit1 = (digit1 + 7) % 10;
            digit2 = (digit2 + 7) % 10;
            digit3 = (digit3 + 7) % 10;
            digit4 = (digit4 + 7) % 10;

            //Swap first with third digit and second with fourth digit
            digitHolder = digit1;
            digit1 = digit3;
            digit3 = digitHolder;
            digitHolder = digit2;
            digit2 = digit4;
            digit4 = digitHolder;

            //Form the encrypted Integer from the four digits
            encryptedInteger = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;

            return encryptedInteger; //Return encrypted Integer
        }

        public static int DecryptInteger(int encryptedInteger) //Method to decrypt an encrypted Integer
        {
            int EncryptedDigit1; //Declaring first digit of the encrypted four-digit Integer
            int EncryptedDigit2; //Declaring second digit of the encrypted four-digit Integer
            int EncryptedDigit3; //Declaring third digit of the encrypted four-digit Integer
            int EncryptedDigit4; //Declaring fourth digit of the encrypted four-digit Integer
            int digitHolder; // Temporary holder to swap the digits
            int decryptedInteger; //Storing the Integer after decryption

            EncryptedDigit1 = encryptedInteger / 1000; //First digit of entered Integer
            EncryptedDigit2 = (encryptedInteger / 100) % 10; //Second digit of entered Integer
            EncryptedDigit3 = (encryptedInteger / 10) % 10; //Third digit of entered Integer
            EncryptedDigit4 = encryptedInteger % 10; //Fourth digit of entered Integer

            //Swap first with third digit and second with fourth digit
            digitHolder = EncryptedDigit1;
            EncryptedDigit1 = EncryptedDigit3;
            EncryptedDigit3 = digitHolder;
            digitHolder = EncryptedDigit2;
            EncryptedDigit2 = EncryptedDigit4;
            EncryptedDigit4 = digitHolder;

            //Revert the operations via reverseModulus() to get the original digits
            EncryptedDigit1 = reverseModulus(EncryptedDigit1, 7, 10);
            EncryptedDigit2 = reverseModulus(EncryptedDigit2, 7, 10);
            EncryptedDigit3 = reverseModulus(EncryptedDigit3, 7, 10);
            EncryptedDigit4 = reverseModulus(EncryptedDigit4, 7, 10);

            //Form the decrypted(original) Integer from the four digits
            decryptedInteger = EncryptedDigit1 * 1000 + EncryptedDigit2 * 100 + EncryptedDigit3 * 10 + EncryptedDigit4;

            return decryptedInteger; //Return encrypted Integer
        }

        //Method to find X in equatation NUMBER = (X + ADDEND) % MODULUS
        public static int reverseModulus(int number, int addend, int modulus)
        {
            if (number >= addend)
            {
                return number - addend;
            }
            else
            {
                return number + modulus - addend;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter four-digit Integer: "); //Message prompting to enter Integer to be encry
            int data = Convert.ToInt32(Console.ReadLine()); // Store the four-digit Integer in a variable
            int encryptedInteger = EncryptInteger(data);

            //Print the Integer as a String to avoid eventual loss from leading zeros
            Console.WriteLine("Encrypted Integer: " + encryptedInteger.ToString("D4"));

            int decryptedInteger = DecryptInteger(encryptedInteger);

            //Print the Integer as a String to avoid eventual loss from leading zeros
            Console.WriteLine("Decrypted Integer: " + decryptedInteger.ToString("D4"));
        }
    }
}
