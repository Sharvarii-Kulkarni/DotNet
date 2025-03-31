/*Take input in string and try to convert it into number,boolean( make use of if else condition to demonstrate the type casted value   ),double,decimal,date&time (just print the value)*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a value: ");
        string input = Console.ReadLine();

        //converting to an integer
        if (int.TryParse(input, out int intValue))
        {
            Console.WriteLine("Converted to Integer: " + intValue);
        }
        //converting to a boolean
        else if (bool.TryParse(input, out bool boolValue))
        {
            Console.WriteLine("Converted to Boolean: " + boolValue);
        }
        //converting to a double
        else if (double.TryParse(input, out double doubleValue))
        {
            Console.WriteLine("Converted to Double: " + doubleValue);
        }
        //converting to a decimal
        else if (decimal.TryParse(input, out decimal decimalValue))
        {
            Console.WriteLine("Converted to Decimal: " + decimalValue);
        }
        //converting to DateTime
        else if (DateTime.TryParse(input, out DateTime dateTimeValue))
        {
            Console.WriteLine("Converted to DateTime: " + dateTimeValue);
        }
        else
        {
            Console.WriteLine("Could not convert input to a known type.");
        }
    }
}
