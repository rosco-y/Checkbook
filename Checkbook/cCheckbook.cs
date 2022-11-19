using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Checkbook
{
    internal class cCheckbook
    {
        decimal _balance = 0;
        public bool WritingChecks { get; internal set; } = true;
        public cCheckbook(string amount)
        {
            _balance = decimal.Parse(amount);
        }

        public decimal WriteCheck(string amount)
        {
            decimal checkAmount = decimal.Parse(amount);
            _balance -= checkAmount;
            return _balance;
        }

        internal decimal WriteCheck(decimal amount)
        {
            _balance -= amount;
            return _balance;
        }

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public void WriteBalance()
        {
            Console.WriteLine(FormattedBalance);
        }
        public string FormattedBalance
        {
            get { return string.Format("{0:C}", _balance); }
        }

        public override string ToString()
        {
            return FormattedBalance;
        }
    }
}
