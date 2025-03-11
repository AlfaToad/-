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

        public void Do()
        {
        Algorithm algorithm = new Algorithm();
            if (this.Mode == Mode.Decrypt)
            {
                //using Caesar cipher to decrypt
                this.OutputText = algorithm.DecryptText(this.InputText, this.Key);
            }
            else
            {
                //using Caesar cipher to encrypt
                this.OutputText = algorithm.EncryptText(this.InputText, this.Key);
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
