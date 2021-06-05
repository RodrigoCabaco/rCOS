using System;
using Cosmos.System;
using Kernel_Funcs;


namespace Kernel_CMD{
	public class Kernel_C{
		public void shutdown(Kernel_F kernel_f){
			kernel_f.stdoutline("Shutting down...");
			System.Threading.Thread.Sleep(1000);
			Cosmos.System.Power.Shutdown();
		}
		public void eval_cmd(string cmd, Kernel_F kernel_f){
			switch (cmd){
				case "shutdown":
					shutdown(kernel_f);
					break;
				case "":
					break;
				default:
					kernel_f.stdoutline("Unkown Command... ");
					break;
			}

		}
	}
}