using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task21._01
{
    internal class BankAccount
    {
        public string AccountNumber = "88005553535";
        public string FIO = "Елин Константин Юрьевич";
        public string AccountType = "Дебетовый";
        public string Sum = "3000";

        internal void PrintInfo()
        {
            Console.WriteLine($"Номер счёта: {AccountNumber}\n" +
                $"ФИО: {FIO}\n" +
                $"Тип счета: {AccountType}\n" +
                $"Сумма на счету: {Sum}"
                );
        }
    }
}
