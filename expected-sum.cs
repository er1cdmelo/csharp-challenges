using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		int sumExpected = 17;
		int[] numsExpected = new int[2]{7, 10};
		int[] nums = new int[]{4, 7, 10, 3, 6};
		
		var answer = GetSumNumbers(nums, sumExpected);
		
		if (answer.SequenceEqual(numsExpected))
			Console.WriteLine("CORRECT");
		else
		{
			Console.WriteLine("WRONG");
			
			foreach(var elem in answer)
				Console.WriteLine(elem);
		}
	}
	
	public static int[] GetSumNumbers(int[] nums, int sumExpected)
	{
		int[] answer = new int[2];
		
		int[] sorted = nums; 
		Array.Sort(sorted);
		
		
		bool found = false;
		for(int i = 0; i < sorted.Length - 1; i++)
		{
			if (found) break;
			for(int j = sorted.Length - 1; j > i; j--)
			{
				int sum = sorted[i] + sorted[j];
				if (sum == sumExpected)
				{
					found = true;
					answer[0] = sorted[i];
					answer[1] = sorted[j];
					break;
				}
				
				if (sum < sumExpected)
					break;
			}
		}
		
		return answer;
	}
}
