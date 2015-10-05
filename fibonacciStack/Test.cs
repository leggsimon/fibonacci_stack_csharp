using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace fibonacciStack
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void FibonacciStack_ShouldReturnFirst6Integers ()
		{
			var fibonacci = new FibonacciStack ();
			var value = 6;
			var expected = 5;

			var sequence = fibonacci.GetSequence (value);
			var actual = sequence.Pop ();

			Assert.AreEqual(expected, actual);
		}

		[Test ()]
		public void FibonacciStack_ShouldReturnUpToValue ()
		{
			var fibonacci = new FibonacciStack ();
			var value = 15;
			var expected = 13;

			var sequence = fibonacci.GetSequence (value);
			var actual = sequence.Pop ();

			Assert.AreEqual(expected, actual);
		}
	}
}

