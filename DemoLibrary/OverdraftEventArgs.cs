using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class OverdraftEventArgs : EventArgs
    {
        public decimal AmountOverdrafted { get; set; }
        public string MoreInfo { get; set; }

        //public OverdraftEventArgs(decimal amountOverdrafted, string moreInfo)
        //{
        //    AmountOverdrafted = amountOverdrafted;
        //    MoreInfo = moreInfo;
        //}
    }
}
