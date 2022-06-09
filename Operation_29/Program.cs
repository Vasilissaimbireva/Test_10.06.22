using System;
using System.Globalization;

class Program
{
	static readonly IFormatProvider _ifp = CultureInfo.InvariantCulture;

	class Number
	{
		readonly int _number;

        public Number(int number)
        {
            _number = number;
        }

        public override string ToString()
		{
			return _number.ToString(_ifp);
		}
		public static Number operator +(Number ls, Number rs)
		{
			return new Number(ls._number + rs._number);
		}
		public static string operator +(Number ls, string rs)
		{
			if (int.TryParse(rs, out int number)) return (ls + new Number(number)).ToString();
			throw new ArgumentException();
		}
	}

	static void Main(string[] args)
	{
		int someValue1 = 10;
		int someValue2 = 5;
	
		string result = new Number(someValue1) + someValue2.ToString(_ifp);
		Console.WriteLine(result);
		Console.ReadKey();
	}
}

//программа выводит: 105
