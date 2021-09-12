/*Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}*/

using System.Linq;

public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    int[] result = findZeroes(arr);
    return result;
    /*return arr.OrderBy(x => x==0).ToArray();*/
  }
  
  static int[] findZeroes(int[] array)  
    {  
        for (int i = 0; i < array.Length; i++)  
        {   
            if (array[i] != 0)  
                continue;    
            for (int j = i + 1; j < array.Length; j++)  
            {  
                if (array[j] == 0)  
                    continue;  
                array[i] = array[j];  
                array[j] = 0;  
                break;  
            }  
        }  
        return array;  
    }
}