using System;
using System.Linq;

namespace AplicandoSOLIDNaPratica.OCP_OpenClosedPrinciple
{
    public abstract class Account
    {
        public string NumberTransaction { get; set; }

        public abstract string Debit(decimal value);
        public abstract string Deposit(decimal value);

        public string CodeTransaction()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVXYZ0123456789";
            var random = new Random();
            NumberTransaction = new string(Enumerable.Repeat(chars, 15).Select(s => s[random.Next(s.Length)]).ToArray());
            return NumberTransaction;
        }
    }
}
