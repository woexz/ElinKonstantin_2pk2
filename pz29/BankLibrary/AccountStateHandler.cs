﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public delegate void AccountStateHandler(object sender, AccountEventArgs e);
    public class AccountEventArgs
    {
        public string Message
        {
            get { return Message; }
            set { Message = value; }
        }   //автосвойство сообщения (Message)
        public decimal Sum
        {
            get { return Sum; }
            private set { Sum = value; }
        }   //автосвойство суммы (Sum), на которую изменился счет
        public AccountEventArgs(string message, decimal sum) 
        {
            Message = message;
            Sum = sum;
        }
        // определите конструктор класса, инициирующий Message и Sum
    }
}
