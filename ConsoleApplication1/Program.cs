using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			Class1 c1 = new Class1();
			c1.Execute();
			Class2 c2 = new Class2();
			c2.Execute();
			Class3 c3 = new Class3();
			c3.Execute();
		}
	}
}
