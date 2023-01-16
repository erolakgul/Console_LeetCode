
using Console_LeetCode.Utils;

// challange
// https://leetcode.com/study-plan/leetcode-75/?progress=xulfpu4ts

int[] nums = new int[] { 1, 2, 3, 4 };
Helper.Running_Sum_of_1d_Array(nums).ToList().ForEach(x => Console.WriteLine($" Result => {x}"));


int[] nums2 = new int[] { 1, 2, 3 };//{ 1, 7, 3, 6, 5, 6 };
Console.WriteLine($" Result 2 => {Helper.PivotIndex(nums2)}");



Console.ReadKey();