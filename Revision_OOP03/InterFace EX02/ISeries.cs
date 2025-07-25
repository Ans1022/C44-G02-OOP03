using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.InterFace_EX02
{
    internal interface ISeries
    {
        int Current { get; set; } //Signature Of Properties
        void Next();
        void Reset();
    }
}
