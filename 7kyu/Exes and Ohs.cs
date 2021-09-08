/*Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.

Examples input/output:

XO("ooxx") = > true
XO("xooxx") = > false
XO("ooxXm") = > true
XO("zpzpzpp") = > true // when no 'x' and 'o' is present should return true
XO("zzoo") = > false*/

using System;
using System.Linq;

public static class Kata 
{
    public static bool XO (string input)
    {
        input = input.ToLower();
        return input.Count(x => x == 'x') == input.Count(x => x == 'o') ? true : false;
    }
}
