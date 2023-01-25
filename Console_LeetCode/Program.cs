
using Console_LeetCode.Models;
using Console_LeetCode.Utils;

// challange
// https://leetcode.com/study-plan/leetcode-75/?progress=xulfpu4ts

int[] nums = new int[] { 1, 2, 3, 4 };
LeetCode75.Running_Sum_of_1d_Array(nums).ToList().ForEach(x => Console.WriteLine($" Result => {x}"));


int[] nums2 = new int[] { 1, 2, 3 };//{ 1, 7, 3, 6, 5, 6 };
Console.WriteLine($" Result 2 => {LeetCode75.PivotIndex(nums2)}");


string s = "aaaaaa";
string t = "bbaaaa";
bool res  = LeetCode75.IsSubsequence(s, t);


/*linkedlist single*/
int[] arr1 = new int[] { 1, 2,4 };
int[] arr2 = new int[] { 1,3,4 };


ListNode listNode1 = null;
for (int i = 0; i < arr1.Length; i++)
{
    listNode1 = new(arr1[i]);
}

ListNode listNode2 = null;
for (int i = 0; i < arr2.Length; i++)
{
    listNode2 = new(arr2[i]);
}

ListNode listNode = LeetCode75.MergeTwoLists(listNode1, listNode2);
Console.WriteLine(listNode);

Console.ReadKey();