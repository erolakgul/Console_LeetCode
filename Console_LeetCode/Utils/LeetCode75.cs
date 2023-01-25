using Console_LeetCode.Models;
using System.Collections;
using System.Text;

namespace Console_LeetCode.Utils
{
    public static class LeetCode75
    {
        // level 1 ques 1
        public static int[] Running_Sum_of_1d_Array(int[] nums)
        {
            /*örn 1,2,3,4 geldiyse, 
             * diğer array in ilkine 1, 
             * ikinciisne 1+2 den 3
             * üçüncüsüne 1+2+3 ten 6
             * sonuncusuna da 1+2+3+4 ten 10 gelmeli
            */
            int[] returnSumNum = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - (nums.Length - 1 - i); j++)
                {
                    returnSumNum[i] += nums[j];
                }
            }

            return returnSumNum;
        }
        // level 1 ques 2
        public static int PivotIndex(int[] nums)
        {
            int pivotIndex = 0;


            for (int i = 0; i < nums.Length; i++)
            {
                pivotIndex = i;
                int leftSum = 0;
                int rightSum = 0;

                // 0     1     2    3    4   5
                // 7  ,  1  ,  6  , 3  , 6  ,8
                for (int j = 0; j < nums.Length; j++)
                {
                    if (pivotIndex != j)
                    {
                        if (pivotIndex > j)
                        {
                            leftSum += nums[j];
                        }
                        else if (pivotIndex < j || pivotIndex == 0)
                        {
                            rightSum += nums[j];
                        }
                    }
                }

                if (leftSum == rightSum)
                {
                    /*eşitlendiği bir an varsa o pivotindex numarasıdır*/
                    return pivotIndex;
                }
                else if (i == (nums.Length - 1))
                {
                    /*eğer sağ sol toplam eşit değilse -1 döndür*/
                    return -1;
                }
            }

            return pivotIndex;
        }
        // level 1 ques 3
        public static bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            if (s == null || t == null)

                return false;

            int[] chars1 = new int[128];
            int[] chars2 = new int[128];

            for (int i = 0; i < s.Length; i++)
            {
                if (chars1[s[i]] != chars2[t[i]])
                {
                    return false;
                }
                else
                {
                    chars1[s[i]] = i + 1;
                    chars2[t[i]] = i + 1;
                }
            }
            return true;
        }
        // level 1 ques 4
        public static bool IsSubsequence(string s, string t)
        {
            char[] st = s.ToArray();

            int currentIndex = -1;
            int lastIndex = -1;
            int searchNum = 0;

            for (int i = 0; i < st.Length; i++)
            {
                if (t.Contains(st[i]))
                {
                    // .Skip(lastIndex)
                    currentIndex = t.IndexOf(st[i], searchNum);
                    if (lastIndex == -1) lastIndex = currentIndex;

                    if (currentIndex < lastIndex) return false;
                    lastIndex = currentIndex;
                    searchNum = lastIndex + 1;
                }
                else
                {
                    return false;
                }

            }
            return true;
        }
        // level 1 ques 5
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }

            if (list2 == null)
            {
                return list1;
            }

            ListNode head;

            ListNode temp;

            if (list1.val > list2.val)
            {
                temp = head = new ListNode(list2.val);
                list2 = list2.next;
            }
            else
            {
                temp = head = new ListNode(list1.val);
                list1 = list1.next;
            }

            while (list1 != null || list2 != null)
            {
                if (list1 == null && list2 != null)
                {
                    temp.next = new ListNode(list2.val);
                    list2 = list2.next;
                }
                else if (list1 != null && list2 == null)
                {
                    temp.next = new ListNode(list1.val);
                    list1 = list1.next;
                }
                else
                {
                    if (list1.val > list2.val)
                    {
                        temp.next = new ListNode(list2.val);
                        list2 = list2.next;
                    }
                    else
                    {
                        temp.next = new ListNode(list1.val);
                        list1 = list1.next;
                    }
                }
                temp = temp.next;
            }
            return head;
        }

        // level 1 ques 6


    }
}
