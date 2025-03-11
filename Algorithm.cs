using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Программа_для_взлома_шифра_Цезаря
{
    internal class Algorithm
    {
        public string DecryptText(string input, int key)
        {
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string alphabetUp = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (alphabet.Contains(input[i]))
                {
                    output += alphabet[alphabet.LastIndexOf(input[i]) - key];
                }
                else if (alphabetUp.Contains(input[i]))
                {
                    output += alphabetUp[alphabetUp.LastIndexOf(input[i]) - key];
                }
                else
                {
                    output += input[i];
                }
            }
            return output;
        }
        public string EncryptText(string input, int key)
        {
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string alphabetUp = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (alphabet.Contains(input[i]))
                {
                    output += alphabet[alphabet.IndexOf(input[i]) + key];
                }
                else if (alphabetUp.Contains(input[i]))
                {
                    output += alphabetUp[alphabetUp.IndexOf(input[i]) + key];
                }
                else
                {
                    output += input[i];
                }
            }
            return output;
        }
    }
}
