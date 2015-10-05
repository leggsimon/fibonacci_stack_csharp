using System;
using System.Collections.Generic;

namespace fibonacciStack
{
	public class FibonacciStack
	{
		public Stack<int> GetSequence (int maxValue)
		{
			var fibonacciStack = new Stack<int>();

			fibonacciStack.Push (0);
			fibonacciStack.Push (1);

			BuildSequenceUpToValue (fibonacciStack, maxValue);

			return fibonacciStack;
		}

		private Stack<int> BuildSequenceUpToValue(Stack<int> stack, int maxValue)
		{
			for (int i = 0; i < maxValue - 2; i++)
			{
				AddNextNumber (stack);
				if (stack.Peek() > maxValue)
				{
					stack.Pop ();
					break;
				}
			}
			return stack;
		} 

		private Stack<int> AddNextNumber(Stack<int> stack)
		{
			var lastValue = stack.Pop ();
			var secondToLastValue = stack.Pop ();

			stack.Push (secondToLastValue);
			stack.Push (lastValue);
			stack.Push (secondToLastValue + lastValue);

			return stack;
		}
	}
}

