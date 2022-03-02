using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF1HF0013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // hexSpeak karakterek
            string hexSpeakChars = " ABCDEFIO";

            // bekért szám átalakítása hex-é
            int number = int.Parse(Console.ReadLine());
            string hexNumber = number.ToString("X");
            string answer = string.Empty;

            // hexNumber bejárása
            int counter = 0;
            bool hexSpeak = true;
            while (counter < hexNumber.Length && hexSpeak)
            {
                if (hexNumber[counter] == '0')
                    answer += 'O';
                else if (hexNumber[counter] == '1')
                    answer += 'I';
                else if (hexSpeakChars.Contains(hexNumber[counter]))
                    answer += hexNumber[counter];
                else
                {
                    answer = "error";
                    hexSpeak = false;
                }
                counter++;
            }

            // kimeneti érték
            Console.WriteLine(answer);
        }
    }
}
