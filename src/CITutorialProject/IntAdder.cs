using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITutorialProject
{
	public class IntAdder
	{
		public readonly int IntOne;

		public readonly int IntTwo;

		public IntAdder(int one, int two)
		{
			IntOne = one;
			IntTwo = two;
		}

		public int Add()
		{
			return IntOne - IntTwo;
		}
	}
}
