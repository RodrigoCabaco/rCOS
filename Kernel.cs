using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Kernel_Startup;
using Kernel_Funcs;

namespace rCOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
    
        }

        protected override void Run()
        {
            Kernel_S kernel_s = new Kernel_S();
            kernel_s.init_sys();
            Kernel_F kernel_f = new Kernel_F();
            kernel_f.stdin(">> ");
        }
    }
}
