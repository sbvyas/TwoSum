using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] aArray = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
			string aTarget = Console.ReadLine();
			var aOutPut = TwoSum(aArray, Convert.ToInt32(aTarget));
			Console.WriteLine(string.Join(" ", aOutPut));
			Console.ReadLine();
		}

		static int[] TwoSum(int[] nums, int target)
		{
			int[] TwoSumIndices = new int[2];
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = i + 1; j < nums.Length; j++)
				{
					if (nums[i] == target - nums[j])
					{
						TwoSumIndices[0] = i;
						TwoSumIndices[1] = j;
						return TwoSumIndices;
					}
				}
			}
			return TwoSumIndices;

		}
	}
}
