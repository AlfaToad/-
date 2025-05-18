using System;
using System.Linq;


namespace Программа_для_взлома_шифра_Цезаря
{
    internal class Algorithm
    {
        const string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        const string alphabetUp = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        public string DecryptText(string input, int key) //Базовый метод дешифровки с известным ключем
        {
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
        public string EncryptText(string input, int key, Action<int> proggressCallback) //Метод шифрования
        {
            proggressCallback(0); //added progress bar
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
                proggressCallback(i);   //added progress bar
            }
            proggressCallback(input.Length);    //added progress bar
            return output;
        }
    }
}
