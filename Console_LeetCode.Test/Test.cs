using Console_LeetCode.Utils;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Console_LeetCode.Test
{
    [TestFixture]
    public class Tests
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void RunSumArray()
        {
            int isOk = 0;

            int[] nums1 = new int[] { 1, 2, 3 , 4};
            int[] nums1_Response = LeetCode75.Running_Sum_of_1d_Array(nums1);
            isOk = (nums1_Response.SequenceEqual(new[] { 1, 3, 6, 10 })) ? isOk : 1;


            int[] nums2 = new int[] { 1, 1, 1, 1 , 1 };
            int[] nums2_Response = LeetCode75.Running_Sum_of_1d_Array(nums2);
            isOk = (nums2_Response.SequenceEqual(new[] { 1, 2, 3, 4, 5 })) ?  isOk : 2;


            int[] nums3 = new int[] { 3, 1, 2, 10, 1 };
            int[] nums3_Response = LeetCode75.Running_Sum_of_1d_Array(nums3);
            isOk = (nums3_Response.SequenceEqual(new[] { 3, 4, 6, 16, 17 })) ?  isOk : 3;


            Assert.AreEqual(isOk, 0);
            //Assert.Pass();
        }

        [Test]
        public void PivotIndex()
        {
            int IsOk = 0;

            int[] nums1 = new int[] { 1, 7, 3, 6, 5, 6 };
            int nums1_response_index = LeetCode75.PivotIndex(nums1);
            IsOk = (nums1_response_index == 3) ? IsOk : 1;


            int[] nums2 = new int[] { 1, 2, 3 };
            int nums2_response_index = LeetCode75.PivotIndex(nums2);
            IsOk = (nums2_response_index == -1 ) ? IsOk : 2;


            int[] nums3 = new int[] { 2, 1, -1 };
            int nums3_response_index = LeetCode75.PivotIndex(nums3);
            IsOk = (nums3_response_index == 0) ? IsOk : 3;

            Assert.AreEqual(IsOk, 0);
        }


        [Test]
        public void IsIsomorphic()
        {
            int IsOk = 0;

            string s = "egg";
            string t = "add";
            IsOk = (LeetCode75.IsIsomorphic(s,t)) ? IsOk : 1;

            string s2 = "foo";
            string t2 = "bar";
            IsOk = (LeetCode75.IsIsomorphic(s, t)) ? IsOk : 2;

            string s3 = "paper";
            string t3 = "title";
            IsOk = (LeetCode75.IsIsomorphic(s, t)) ? IsOk : 3;

            Assert.AreEqual(IsOk, 0);
        }

        [Test]
        public void IsSubsequence()
        {
            int IsOk = 0;

            string s = "abc";
            string t = "ahbgdc";
            IsOk = (LeetCode75.IsSubsequence(s, t)) ? IsOk : 1; // true bekle

            string s2 = "axc";
            string t2 = "ahbgdc";
            IsOk = (LeetCode75.IsSubsequence(s2, t2)) ? 2 : IsOk;  // false bekle

            string s3 = "aaaaaa";
            string t3 = "bbaaaa";
            IsOk = (LeetCode75.IsSubsequence(s3, t3)) ? 3 : IsOk;  // false bekle


            Assert.AreEqual(IsOk, 0);
        }

        [Test]
        public void Check_IntToRoman_WhenExecuted()
        {
            Dictionary<string, int> _responseDictionary = new();

            _responseDictionary.Add("III", 3);
            _responseDictionary.Add("LVIII", 58);
            _responseDictionary.Add("MCMXCIV", 1994);

            bool response = false;
            int _falseCount = 0;

            foreach (var item in _responseDictionary)
            {
                #region  Arrange
                string _responseExpected = item.Key;
                string _responseRoman = LeetCode75.IntToRoman(item.Value); //1994
                #endregion

                #region act
                response = (_responseRoman == _responseExpected) ? true : false;
                _falseCount = (response == false) ? _falseCount + 1 : _falseCount;
                #endregion

                TestContext.WriteLine($"Beklenen    : {_responseExpected}\nGelen Cevap : {_responseRoman}");
                string result = (response) ? "Baþarýlý" : "Baþarýsýz";
                TestContext.WriteLine($"Sonuç       : {result}");
            }
            TestContext.WriteLine("*************************************");
            TestContext.WriteLine($"Hatalý Kayýt Sayýsý : {_falseCount}");

            #region assert
            Assert.AreEqual(_falseCount, 0);
            //Assert.AreNotSame(connectionSettings.PortNumber, connectionSettings.MaxCountQueue);
            #endregion
        }

    }
}