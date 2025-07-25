using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.InterFace
{
    internal interface IMyType
    {
        // What Can Write Inside InterFace ?
        //1.Signature Of Properties
        //2.Signature Of methods [ Name , parameter , Return Type]
        //3. Default Implemented methods [Fully Implemented methods ]

        ///1.Signature Of Methods
        ///
        void Myfun();

        ///2.Signature Of Properties
        ///
        double salary { get; set; }

        ///3. Default Implemented methods
        ///
        void Print()
        {
            Console.WriteLine("Default Implemented methods [Fully Implemented methods ]");
        }



    }
}
