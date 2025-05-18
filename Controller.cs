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

    internal class Controller
    {
        private string inputText; //Входной текст 
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

        public void LoadDictionary() //Метод импорта словаря
        {
            dictionary = File.ReadLines("Словарь(90т.слов).txt").ToHashSet();
        }
        public void Do(Action<int> proggressCallback) //Метод выполнения действия при нажатии кнопки "Выполнить"
        {

            Algorithm algorithm = new Algorithm();
            if (this.Mode == Mode.Decrypt) //using Caesar cipher to decrypt
            {
                string output = algorithm.DecryptText(this.InputText, this.Key);
                this.OutputText = output;
            }
            else
            {
                //using Caesar cipher to encrypt
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
