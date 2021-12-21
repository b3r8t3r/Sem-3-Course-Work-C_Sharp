﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_3_Course_Work_C_Sharp
{
    internal class Viginer_95
    {
        private string Message; //Переменная, содержащая в себе принимаемое/передаваемое сообщение

        private string Key; //Ключ для шифрования/дешифрования сообщения

        public string Get_Message() //Возвращение значения сообщения
        {
            return Message;
        }

        public string Get_Key() //Возвращение значения ключа
        {
            return Key;
        }

        public void Set_Message(string _message)    //Установка значения сообщения
        {
            Message = _message;
        }

        public void Set_Key(string _key)    //Возвращение значения ключа
        {
            Key = _key;
        }

        //Шшифровка сообщения
        public string Encrypt()
        {
            StringBuilder sb = new StringBuilder(Message);  //Объект, используемый для переопределения Message
            int keyLen = Key.Length;    //Переменная, отвечающая за длину ключа

            for (int i = 0, shift, edited_char; i < Message.Length; i++)
            {
                shift = Key[i % keyLen] - ' ';  //Переменная, отвечающая за сдвиг символа по символу ключа

                edited_char = Message[i] + shift;   //Переменная, содержащая в себе измененный символ
                if (edited_char > 126) edited_char -= 95;

                sb[i] = (Convert.ToChar(edited_char));
            }

            return Message = sb.ToString();
        }

        //Дешифровка сообщения
        public string Decrypt()
        {
            StringBuilder sb = new StringBuilder(Message);  //Объект, используемый для переопределения Message
            int keyLen = Key.Length;    //Переменная, отвечающая за длину ключа

            for (int i = 0, shift, edited_char; i < Message.Length; i++)
            {
                shift = Key[i % keyLen] - ' ';  //Переменная, отвечающая за сдвиг символа по символу ключа

                edited_char = Message[i] - shift;   //Переменная, содержащая в себе измененный символ
                if (edited_char < 32) edited_char += 95;

                sb[i] = (Convert.ToChar(edited_char));
            }

            return Message = sb.ToString();
        }
    }
}
