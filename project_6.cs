{
    Console.WriteLine("Hello World");
    Console.WriteLine("Number Analyzer");
    Console.Write("enter a number: ");
		string num = Console.ReadLine();
		int number = Convert.ToInt32(num);
 		
		if ((number > 0) && (number % 2 == 0))
		{
			Console.WriteLine("the integer is positive and even");
		}
		else if ((number < 0) && (number % 2 ==0))
		{
			Console.WriteLine("the integer is negative and even");
		}
		else if ((number > 0) && (number % 2 != 0))
		{
			Console.WriteLine("the integer is positive and odd");
		}
		else if ((number < 0) && (number % 2 != 0))
		{
			Console.WriteLine("the integer is negative and odd");
		}
		else
		{
			Console.WriteLine("the integer is neutral");
		}
}