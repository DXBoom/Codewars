/*The rgb function is incomplete. Complete it so that passing in RGB decimal values will result in a hexadecimal representation being returned. Valid decimal values for RGB are 0 - 255. Any values that fall out of that range must be rounded to the closest valid value.

Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.

The following are examples of expected output values:

Rgb(255, 255, 255) # returns FFFFFF
Rgb(255, 255, 300) # returns FFFFFF
Rgb(0,0,0) # returns 000000
Rgb(148, 0, 211) # returns 9400D3*/

using System;

public class Kata
{
  public static string Rgb(int r, int g, int b) 
  {
    r = Math.Max(Math.Min(255, r), 0);
    g = Math.Max(Math.Min(255, g), 0);
    b = Math.Max(Math.Min(255, b), 0);
    
    return String.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
  }
}