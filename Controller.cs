using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Программа_для_взлома_шифра_Цезаря
{
    public enum Mode //Варианты действий
    {
        Decrypt = 0,
        Encrypt
    };
    public enum DecryptionMode //Варианты дешифровки
    {
        Without = 0,
        With
    };

    internal class Controller
    {
        private string inputText = ""; //Входной текст 
        private HashSet<string> dictionary { get; set; } //Словарь 90т слов
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
        public string OutputText { get; private set; } //Текст получающийся в результате
        public int Key { get; private set; } //Ключ
        public Mode Mode { get; private set; } //Вариант действия
        public DecryptionMode DecryptionMode { get; private set; } //Вариант дешифровки

        public void LoadDictionary() //Метод импорта словаря
        {
            dictionary = File.ReadLines("Словарь(90т.слов).txt").ToHashSet();
        }
        public void Do(Action<int> proggressCallback) //Метод выполнения действия при нажатии кнопки "Выполнить"
        {

        Algorithm algorithm = new Algorithm();
            if (this.Mode == Mode.Decrypt) //использование шифра Цезаря для расшифровки
            {
                if (this.DecryptionMode == DecryptionMode.With) //с ключом
                {
                    string output = algorithm.DecryptText(this.InputText, this.Key);
                    this.OutputText = output;
                }
                else //без ключа
                {
                    var (output, key) = algorithm.DecryptText(this.InputText, dictionary, proggressCallback);
                    this.Key = key;
                    this.OutputText = output;
                }
            }
            else
            {
                //использование шифра Цезаря для шифрования
                this.OutputText = algorithm.EncryptText(this.InputText, this.Key, proggressCallback);
            }
        }
        public void ReadFromFile(string text) //Метод записи в текстовое поле из файла и очистки результата
        {
            this.InputText = text;
            this.OutputText = string.Empty;
        }
        public void SetMode(Mode mode) //Метод реализующий установку варианта действия
        {
            this.Mode = mode;
        }
        public void SetDecryptionMode(DecryptionMode DecryptionMode) //Метод реализующий установку варианта дешифровки
        {
            this.DecryptionMode = DecryptionMode;
        }
        public void SetKey(int key) //Метод реализующий очистку текстового поля вывода при установке ключа
        {
            this.Key = key;
            this.OutputText = string.Empty;
        }
        public void ClearInput() 
        {
            this.Key = 0;
            this.InputText = string.Empty;
        }
        public void ClearOutput() 
        {
            this.Key = 0;
            this.OutputText = string.Empty;
        }
    }
}
