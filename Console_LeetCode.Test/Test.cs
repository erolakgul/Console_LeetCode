using Console_LeetCode.Utils;
using NUnit.Framework;
using System.Linq;

namespace Console_LeetCode.Test
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void RunSumArray()
        {
            int isOk = 0;

            int[] nums1 = new int[] { 1, 2, 3 , 4};
            int[] nums1_Response = Helper.Running_Sum_of_1d_Array(nums1);
            isOk = (nums1_Response.SequenceEqual(new[] { 1, 3, 6, 10 })) ? isOk : 1;


            int[] nums2 = new int[] { 1, 1, 1, 1 , 1 };
            int[] nums2_Response = Helper.Running_Sum_of_1d_Array(nums2);
            isOk = (nums2_Response.SequenceEqual(new[] { 1, 2, 3, 4, 5 })) ?  isOk : 2;


            int[] nums3 = new int[] { 3, 1, 2, 10, 1 };
            int[] nums3_Response = Helper.Running_Sum_of_1d_Array(nums3);
            isOk = (nums3_Response.SequenceEqual(new[] { 3, 4, 6, 16, 17 })) ?  isOk : 3;


            Assert.AreEqual(isOk, 0);
            //Assert.Pass();
        }

        [Test]
        public void PivotIndex()
        {
            int IsOk = 0;

            int[] nums1 = new int[] { 1, 7, 3, 6, 5, 6 };
            int nums1_response_index = Helper.PivotIndex(nums1);
            IsOk = (nums1_response_index == 3) ? IsOk : 1;


            int[] nums2 = new int[] { 1, 2, 3 };
            int nums2_response_index = Helper.PivotIndex(nums2);
            IsOk = (nums2_response_index == -1 ) ? IsOk : 2;


            int[] nums3 = new int[] { 2, 1, -1 };
            int nums3_response_index = Helper.PivotIndex(nums3);
            IsOk = (nums3_response_index == 0) ? IsOk : 3;

            Assert.AreEqual(IsOk, 0);
        }


        [Test]
        public void IntToRoman()
        {
            int IsOk = 0;

            int num1 = 3;
            string res1 = Helper.IntToRoman(num1);
            IsOk = ("III" == res1) ? IsOk : 1;

            int num2 = 58;
            string res2 = Helper.IntToRoman(num2);
            IsOk = ("LVIII" == res2) ? IsOk : 1;

            int num3 = 1994;
            string res3 = Helper.IntToRoman(num3);
            IsOk = ("MCMXCIV" == res3) ? IsOk : 1;

            Assert.AreEqual(IsOk, 0);
        }
    }
}