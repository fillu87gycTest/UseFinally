using System;

/*
 * Receiving 0
 * Div by Zero
 * Leave try
 * 
 * Receiving 1
 * out of range
 * Leave try
 * 
 * Receiving 2
 * Leave try
 * 
 * Receiving 3
 * Leave try
 * 
 * Receiving 4
 * Leave try
 * 
 * 続行するには何かキーを押してください . . .
 */

class Program
{
	static void Main()
	{
		for (int i = 0; i < 5; i++)
		{
			UseFinally.GenException(i);
			Console.WriteLine();
		}
	}
}
