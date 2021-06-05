using System;
using Kernel_Funcs;
namespace Kernel_Startup{
	public class Kernel_S{
		public void init_sys(){
			Kernel_F kernel_f = new Kernel_F();
			kernel_f.stdoutline("rC booted correctly...");
			
		}
	}
}