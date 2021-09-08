/*You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.

Implement the function likes which takes an array containing the names of people that like an item. It must return the display text as shown in the examples:

Kata.Likes(new string[0]) => "no one likes this"
Kata.Likes(new string[] {"Peter"}) => "Peter likes this"
Kata.Likes(new string[] {"Jacob", "Alex"}) => "Jacob and Alex like this"
Kata.Likes(new string[] {"Max", "John", "Mark"}) => "Max, John and Mark like this"
Kata.Likes(new string[] {"Alex", "Jacob", "Mark", "Max"}) => "Alex, Jacob and 2 others like this"
For 4 or more names, the number in and 2 others simply increases.*/

using System;

public static class Kata
{
    public static string Likes(string[] name)
      => name.Length switch
      {
          0 => "no one likes this",
          1 => $"{name[0]} likes this",
          2 => $"{name[0]} and {name[1]} like this",
          3 => $"{name[0]}, {name[1]} and {name[2]} like this",
          _ => $"{name[0]}, {name[1]} and {name.Length - 2} others like this",
      };
}