using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


// program to find average of three numbers

namespace Average

{ class Program

	{ 
		static void Main()

		{ //declare variables

			int sum1;
			int ave;
			int remain;

			int num1; //Declare first number
			Console.Writeline("Enter an integer Score:");
			num1 = int.Parse(Console.ReadLine());

			int num2; //declare second number
			Console.Writeline("Enter an integer Score:");
			num2 = int.Parse(Console.ReadLine());

			int num3; //declare third number
			Console.Writeline("Enter an integer Score:");
			num3 = int.Parse(Console.ReadLine());

			sum1 = num1 + num2 + num3;
			ave = sum1 / 3;

			remain = sum1 % 3;

			Console.Writeline("The average of {0}, {1}, and {2} is {3} with a remainder of {4}.", num1, num2, num3, ave, remain);
			Console.Writeline("Press any key to continue.");
		}
	}
}
