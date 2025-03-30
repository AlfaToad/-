using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Программа_для_взлома_шифра_Цезаря
{
    internal class Algorithm
    {
        const string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        const string alphabetUp = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private bool CheckingTranslation(string outputText, HashSet<string> dictionary)
        {
            var charsToRemove = new string[] { "(", ")", "[", "]", "\'", "\"", "<", ">" };
            foreach (var c in charsToRemove)
            {
                outputText = outputText.Replace(c, " ");
            }
            string[] splitedText = outputText.Split(' ', '.', ',', '!', '?', ':', ';');

            while (splitedText.Length > 0)
            {
                string maxWord = MaxWord(splitedText);
                if (dictionary.Contains(maxWord.ToLower())) //added .ToLower()
                {
                    return true;
                }
                else if (false) { /*поиск слова-формы по частотному анализу по усмотрению*/}
                else
                {
                    splitedText = splitedText.Where(w => w != maxWord).ToArray();
                }
            }
            return false;

        }
        public string MaxWord(string[] text)
        {
            string max = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Length > max.Length) max = text[i];
            }
            return max;
        }

        public (string output, int key) DecryptText(string input, HashSet<string> dictionary, Action<int> proggressCallback)
        {
            Dictionary<int, (double delta, string output)> deltas = new Dictionary<int, (double delta, string output)>(); //using tuple

            string output;
            var lettersChansePattern = new Dictionary<string, double>()
            {
                {"а", 0.07998},{"б", 0.01592},{"в", 0.04533},{"г", 0.01687},{"д", 0.02977},
                {"е", 0.08483},{"ё", 0.00013},{"ж", 0.0094},{"з", 0.01641},{"и", 0.07367},
                {"й", 0.01208},{"к", 0.03486},{"л", 0.04343},{"м", 0.03203},{"н", 0.067},
                {"о", 0.10983},{"п", 0.02804},{"р", 0.04746},{"с", 0.05473},{"т", 0.06318},
                {"у", 0.02615},{"ф", 0.00267},{"х", 0.00966},{"ц", 0.00486},{"ч", 0.0145},
                {"ш", 0.00718},{"щ", 0.00361},{"ъ", 0.00037},{"ы", 0.01898},{"ь", 0.01735},
                {"э", 0.00331},{"ю", 0.00639},{"я", 0.02001}
            };
            var lettersChanse = new Dictionary<string, double>()
            {
                {"а", 0},{"б", 0},{"в", 0},{"г", 0},{"д", 0},
                {"е", 0},{"ё", 0},{"ж", 0},{"з", 0},{"и", 0},
                {"й", 0},{"к", 0},{"л", 0},{"м", 0},{"н", 0},
                {"о", 0},{"п", 0},{"р", 0},{"с", 0},{"т", 0},
                {"у", 0},{"ф", 0},{"х", 0},{"ц", 0},{"ч", 0},
                {"ш", 0},{"щ", 0},{"ъ", 0},{"ы", 0},{"ь", 0},
                {"э", 0},{"ю", 0},{"я", 0}
            };

            proggressCallback(0);
            //file acsess for debuging
            using (StreamWriter writer = new StreamWriter("chanses.txt", false))
            {
                for (int j = 1; j < 34; j++)
                {
                    output = DecryptText(input, j);
                    int sum_letters = 0;
                    for (int i = 0; i < output.Length; i++)
                    {
                        if (alphabet.Contains(output[i]) || alphabetUp.Contains(output[i]))
                        {
                            lettersChanse[Convert.ToString(output[i]).ToLower()]++;
                            sum_letters++;  // подсчёт букв
                        }
                    }

                    double delta = 0;
                    for (int i = 0; i < 33; i++)
                    {
                        lettersChanse[alphabet[i].ToString()] = lettersChanse[alphabet[i].ToString()] / sum_letters;
                        delta += Math.Abs(lettersChansePattern[alphabet[i].ToString()] - lettersChanse[alphabet[i].ToString()]);

                    }
                    deltas.Add(j, (delta, output));
                    proggressCallback(j);
                    //debug code 
                    writer.WriteLine($"delta = {delta}"); 
                    writer.WriteLine($"//////////////////////////////////////////////////////////////////////////");
                }
            }

            KeyValuePair<int, (double delta, string output)> minItem = new KeyValuePair<int, (double delta, string output)>(0, (double.MaxValue, input));
            foreach (var item in deltas)
            {
                if (item.Value.delta < minItem.Value.delta && CheckingTranslation(item.Value.output, dictionary)) minItem = item;
            }
            proggressCallback(33);
            return (minItem.Value.output, minItem.Key);
        }

        public string DecryptText(string input, int key)
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
        public string EncryptText(string input, int key, Action<int> proggressCallback)
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
