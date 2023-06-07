using System;
using System.Linq;
namespace Day3AOC
{
	public class RuckSackSorter
	{
		public static int Priorities()
		{
			Console.Write("Enter puzzle input file path: ");
			var path = Console.ReadLine();

			var ruckSackList = File.ReadAllLines(path);

            var Duplicates = new List<int>();
			var Priorities = new List<int>();

			var GroupDuplicates = new List<int>();
			var badgePriorities = new List<int>();
			 
			// Part 1 Solution
			foreach (var line in ruckSackList)
			{

				var firstHalf = line.Take(line.Length / 2).ToArray();
				var secondHalf = line.Skip(line.Length / 2).ToArray();
				

				foreach (var letter in firstHalf)
				{
					if (secondHalf.Contains(letter))
					{
                        var intLetter = Convert.ToInt32(letter);
                        Duplicates.Add(intLetter);
						break;					
                    }
                    
                }
			}
					
			foreach (var number in Duplicates)
			{

				if (number >= 65 && number <= 90)
				{
                    var priority = number - 38;
                    Priorities.Add(priority);
                    
				}
				else if(number >= 97 && number <=122)
				{
                    var priority = number - 96;
                    Priorities.Add(priority);
                    
                }	
			}

			//var groupList = new List<string>();
			//var count = 0;

			//Part 2 Solution

			//Group 3 lines together

			//Find a duplicate letter for those three lines

			// Convert duplicate Char to a letter & add to list

		

			
				


            //foreach (var number in GroupDuplicates)
            //{

            //    if (number >= 65 && number <= 90)
            //    {
            //        var priority = number - 38;
            //        badgePriorities.Add(priority);

            //    }
            //    else if (number >= 97 && number <= 122)
            //    {
            //        var priority = number - 96;
            //        badgePriorities.Add(priority);

            //    }
            //}

			return Priorities.Sum();
		}
	}
}

