using System;
namespace Kernel_Funcs{
	public class Kernel_F{
		public void stdout(string line = ""){
			Console.Write(line);
		}
		public void stdoutline(string line = ""){
			Console.WriteLine(line);
		}
		public string stdin(string before_input = ""){
			Console.Write(before_input);
			return Console.ReadLine();
		}
	}
}