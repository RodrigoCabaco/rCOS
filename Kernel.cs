using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Kernel_Startup;
using Kernel_CMD;
using Kernel_Funcs;

namespace rCOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Kernel_S kernel_s = new Kernel_S();
            Kernel_F kernel_f = new Kernel_F();
            kernel_s.init_sys();
        }

        protected override void Run()
        {
            Kernel_S kernel_s = new Kernel_S();
            Kernel_F kernel_f = new Kernel_F();
            Kernel_C kernel_c = new Kernel_C();
            kernel_c.eval_cmd(kernel_f.stdin(">> "), kernel_f);

        }
    }
}
