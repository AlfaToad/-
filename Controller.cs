using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Программа_для_взлома_шифра_Цезаря
{
    public enum Mode
    {
        Decrypt = 0,
        Encrypt
    };
    internal class Controller
    {
        private string inputText;
        private HashSet<string> dictionary { get; set; }
        public Controller()
        {
            dictionary = new HashSet<string>();
        }
        public string InputText
        {
            get => inputText;
            set
            {
                inputText = value;
                this.OutputText = string.Empty;
            }
        }
        public string OutputText { get; private set; }
        public int Key { get; private set; }
        public Mode Mode { get; private set; }

        public void LoadDictionary()
        {
            dictionary = File.ReadLines("Словарь(90т.слов).txt").ToHashSet();
        }
        public void Do(Action<int> proggressCallback)
        {

        Algorithm algorithm = new Algorithm();
            if (this.Mode == Mode.Decrypt)
            {
                //using Caesar cipher to decrypt
                var (output, key) = algorithm.DecryptText(this.InputText, dictionary, proggressCallback);
                this.Key = key;
                this.OutputText = output;
            }
            else
            {
                //using Caesar cipher to encrypt
                this.OutputText = algorithm.EncryptText(this.InputText, this.Key, proggressCallback);
            }
        }
        public void ReadFromFile(string text)
        {
            //read text from file 
            this.InputText = text;
            this.OutputText = string.Empty;

        }
        public void SetMode(Mode mode)
        {
            this.Mode = mode;
            this.InputText = string.Empty;
            this.OutputText = string.Empty;
        }
        public void SetKey(int key)
        {
            this.Key = key;
            this.OutputText = string.Empty;
        }

    }
}
