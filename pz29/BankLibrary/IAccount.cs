using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    internal interface IAccount
    {
        public void Put(decimal sum); //метод пополнения счета
        public decimal Withdraw(decimal sum); //метод снятия со счета
    }
}
