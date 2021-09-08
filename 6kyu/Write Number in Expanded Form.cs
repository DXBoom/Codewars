/*Write Number in Expanded Form
You will be given a number and you will need to return it as a string in Expanded Form. For example:

Kata.ExpandedForm(12); # Should return "10 + 2"
Kata.ExpandedForm(42); # Should return "40 + 2"
Kata.ExpandedForm(70304); # Should return "70000 + 300 + 4"
NOTE: All numbers will be whole numbers greater than 0.*/

using System;
using System.Linq;

public static class Kata
{
    public static string ExpandedForm(long num)
    {
        var str = num.ToString();
        return String.Join(" + ", str
          .Select((x, i) => char.GetNumericValue(x) * Math.Pow(10, str.Length - i - 1))
          .Where(x => x > 0));
    }
}