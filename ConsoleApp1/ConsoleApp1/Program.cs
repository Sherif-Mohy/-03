namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region 1
			Console.Write("Enter a number: ");
			int num = int.Parse(Console.ReadLine());
			if (num % 3 == 0 && num % 4 == 0)
				Console.WriteLine("Yes");
			else
				Console.WriteLine("No");
			#endregion

			#region 2
			Console.Write("Enter a number: ");
			int numm = int.Parse(Console.ReadLine());
			if (num < 0)
				Console.WriteLine("negative");
			else
				Console.WriteLine("positive");
			#endregion

			#region 3
			Console.Write("Enter first number: ");
			int a = int.Parse(Console.ReadLine());
			Console.Write("Enter second number: ");
			int b = int.Parse(Console.ReadLine());
			Console.Write("Enter third number: ");
			int c = int.Parse(Console.ReadLine());

			int max, min;

			if (a > b)
			{
				if (a > c) max = a; else max = c;
			}
			else
			{
				if (b > c) max = b; else max = c;
			}

			if (a < b)
			{
				if (a < c) min = a; else min = c;
			}
			else
			{
				if (b < c) min = b; else min = c;
			}

			Console.WriteLine($"Max element = {max}");
			Console.WriteLine($"Min element = {min}");
			#endregion

			#region 4
			Console.Write("Enter a number: ");
			int nnnum = int.Parse(Console.ReadLine());
			if (nnnum % 2 == 0)
				Console.WriteLine("Even");
			else
				Console.WriteLine("Odd");
			#endregion

			#region 5
			Console.Write("Enter a character: ");
			char ch = Console.ReadKey().KeyChar;
			Console.WriteLine();

			if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'U' || ch == 'u')
				Console.WriteLine("Vowel");
			else
				Console.WriteLine("Consonant");
			#endregion

			#region 6
			Console.Write("Enter a number: ");
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++)
			{
				Console.Write(i);
				if (i < n) Console.Write(", ");

			}
			#endregion

			#region 7
			Console.Write("Enter a number: ");
			int m = int.Parse(Console.ReadLine());
			for (int i = 1; i <= 12; i++)
			{
				Console.WriteLine($"{m} x {i} = {m * i}");

			}
			#endregion

			#region 8
			Console.Write("Enter a number: ");
			int s = int.Parse(Console.ReadLine());
			for (int i = 2; i <= s; i += 2)
			{
				Console.Write(i + " ");

			}
			#endregion

			#region 9
			Console.Write("Enter base number: ");
			int baseNUM = int.Parse(Console.ReadLine());
			Console.Write("Enter exponent: ");
			int power = int.Parse(Console.ReadLine());

			int result = 1;
			for (int i = 1; i <= power; i++)
			{
				result *= baseNUM;
			}

			Console.WriteLine($"Result = {result}");
			#endregion


			#region 10
			int total = 0;
			int subjectMarks;

			for (int i = 1; i <= 5; i++)
			{
				Console.Write($"Enter marks for subject {i}: ");
				subjectMarks = int.Parse(Console.ReadLine());
				total += subjectMarks;
			}

			double average = total / 5.0;
			Console.WriteLine($"Total Marks = {total}");
			Console.WriteLine($"Average Marks = {average}");
			double averagepercent = average / 100;
			Console.WriteLine($"Percentage = {averagepercent}%");
			#endregion

			#region 11
			Console.Write("Enter month number (1-12): ");
			int month = int.Parse(Console.ReadLine());

			if (month == 2)
			{
				Console.WriteLine("Days in Month: 28");
			}
			else if (month == 4 || month == 6 || month == 9 || month == 11)
			{
				Console.WriteLine("Days in Month: 30");
			}
			else
			{
				Console.WriteLine("Days in Month: 31");
			}
			#endregion


			#region 12
			Console.Write("Enter first number: ");
			double x = double.Parse(Console.ReadLine());
			Console.Write("Enter second number: ");
			double y = double.Parse(Console.ReadLine());

			Console.Write("Enter operator (+, -, *, /): ");
			char op = Console.ReadKey().KeyChar;

			Console.WriteLine();
			if (op == '+') Console.WriteLine($"Result = {x + y}");
			else if (op == '-') Console.WriteLine($"Result = {x - y}");
			else if (op == '*') Console.WriteLine($"Result = {x * y}");
			else if (op == '/') Console.WriteLine($"Result = {x / y}");
			else Console.WriteLine("Invalid operator");
			#endregion

			#region 13
			Console.Write("Enter a string: ");
			string str = Console.ReadLine();

			for (int i = str.Length - 1; i >= 0; i--)
				Console.Write(str[i]);
			#endregion

			#region 14
			Console.Write("Enter an integer: ");
			int nuumm = int.Parse(Console.ReadLine());

			while (numm != 0)
			{
				Console.Write(nuumm % 10);
				nuumm /= 10;
			}
			#endregion

			#region 15
			Console.Write("Enter starting range: ");
			int start = int.Parse(Console.ReadLine());
			Console.Write("Enter ending range: ");
			int end = int.Parse(Console.ReadLine());

			for (int i = start; i <= end; i++)
			{
				bool isPrime = true;

				if (i < 2) isPrime = false;

				for (int j = 2; j < i; j++)
				{
					if (i % j == 0)
					{
						isPrime = false;
						break;
					}
				}

				if (isPrime) Console.Write(i + " ");
			}
			#endregion

			#region 16
			Console.Write("Enter a number to convert: ");
			int nnum = int.Parse(Console.ReadLine());
			int remainder;
			string binary = "";

			if (nnum == 0)
			{
				Console.WriteLine("The Binary of 0 is 0");
			}
			else
			{
				while (nnum > 0)
				{
					remainder = nnum % 2;
					binary = remainder + binary;
					nnum = nnum / 2;
				}

				Console.WriteLine($"The Binary is {binary}");
			}
			#endregion

			#region 17
			// Input for Point 1
			Console.Write("Enter x1: ");
			int x1 = int.Parse(Console.ReadLine());
			Console.Write("Enter y1: ");
			int y1 = int.Parse(Console.ReadLine());

			// Input for Point 2
			Console.Write("Enter x2: ");
			int x2 = int.Parse(Console.ReadLine());
			Console.Write("Enter y2: ");
			int y2 = int.Parse(Console.ReadLine());

			// Input for Point 3
			Console.Write("Enter x3: ");
			int x3 = int.Parse(Console.ReadLine());
			Console.Write("Enter y3: ");
			int y3 = int.Parse(Console.ReadLine());

			// Check if points lie on a straight line using cross multiplication
			if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
			{
				Console.WriteLine("The points lie on a straight line.");
			}
			else
			{
				Console.WriteLine("The points do not lie on a straight line.");
			}
			#endregion

			#region 18
			Console.Write("Enter the time taken by the worker (in hours): ");
			double time = double.Parse(Console.ReadLine());

			if (time >= 2 && time < 3)
			{
				Console.WriteLine("highly efficient.");
			}
			else if (time >= 3 && time < 4)
			{
				Console.WriteLine("hould increase their speed.");
			}
			else if (time >= 4 && time <= 5)
			{
				Console.WriteLine("needs training to improve their speed.");
			}
			else if (time > 5)
			{
				Console.WriteLine("required to leave the company.");
			}
			else
			{
				Console.WriteLine("Invalid input. Time must be 2 or greater.");
			}
			#endregion
		}
	}
}