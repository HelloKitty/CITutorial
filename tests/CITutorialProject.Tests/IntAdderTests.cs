using CITutorialProject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITutorialProject.Tests
{
	[TestFixture]
	public static class IntAdderTests
	{
		[Test]
		[TestCase(2, 3)]
		[TestCase(0, 3)]
		[TestCase(1, 14)]
		[TestCase(-5, 7)]
		public static void Test_Adder_Method_Adds_Two_Ints(int one, int two)
		{
			//arrange
			IntAdder adder = new IntAdder(one, two);

			//assert
			Assert.AreEqual(one + two, adder.Add());
		}
	}
}
