using System.Text;

namespace Console_LeetCode.Utils
{
    public static class Helper
    {

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


        public static string IntToRoman(int num)
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "I");
            keyValuePairs.Add(5, "V");
            keyValuePairs.Add(10, "X");
            keyValuePairs.Add(50, "L");
            keyValuePairs.Add(100, "C");
            keyValuePairs.Add(500, "D");
            keyValuePairs.Add(1000, "M");

            StringBuilder stringBuilder = new();

            // 1994
            int lengtNum = num.ToString().Length;
            int maxUnit = 1;

            for (int i = 1; i < lengtNum + 1; i++)
            {
                if (i != 1)
                {
                    maxUnit = maxUnit * 10;
                }
            }


            for (int i = lengtNum; i >= 0; i--)
            {
                if (maxUnit != 0)
                {
                    int factor = 0;
                    factor = num / (maxUnit);

                    if (keyValuePairs.ContainsKey(factor * maxUnit))
                    {
                        stringBuilder.Append(keyValuePairs.Where(c => c.Key == factor * maxUnit).Select(f => f.Value).SingleOrDefault());
                    }
                    else
                    {
                        int upNum = maxUnit * 10;
                        int diffNum = upNum - (factor * maxUnit);
                        string _currentRoman = "";

                        // fark birler basamağı kadar ise
                        if ((upNum - diffNum).ToString().Length == 1)
                        {
                            int oneUpNum = (5 - (upNum - diffNum));

                            if (oneUpNum > 0)
                            {
                                if (oneUpNum == 1)
                                {
                                    //_currentRoman = "IV";
                                    _currentRoman = keyValuePairs.Where(c => c.Key == 1).Select(f => f.Value).SingleOrDefault() + keyValuePairs.Where(c => c.Key == 5).Select(f => f.Value).SingleOrDefault();
                                }
                                else
                                {
                                    for (int Y = 0; Y < (upNum - diffNum); Y++)
                                    {
                                        _currentRoman += "I";
                                    }
                                }
                            }
                            else
                            {
                                // 10 - 5 ARASI demek oluyor
                                if (diffNum == 1)
                                {
                                    _currentRoman = keyValuePairs.Where(c => c.Key == diffNum).Select(f => f.Value).SingleOrDefault() + keyValuePairs.Where(c => c.Key == upNum).Select(f => f.Value).SingleOrDefault();
                                }
                                else
                                {
                                    _currentRoman = "V";
                                    for (int r = 0; r < ((upNum - diffNum) - 5); r++)
                                    {
                                        _currentRoman += "I";
                                    }
                                }

                            }
                        }
                        else
                        {
                            _currentRoman = keyValuePairs.Where(c => c.Key == diffNum).Select(f => f.Value).SingleOrDefault() + keyValuePairs.Where(c => c.Key == upNum).Select(f => f.Value).SingleOrDefault();
                        }
                        stringBuilder.Append(_currentRoman);

                    }

                    maxUnit = maxUnit / 10;

                    if (num.ToString().Length != 1)
                    {
                        num = Convert.ToInt32(num.ToString().Remove(0, 1));
                    }
                }

            }


            return stringBuilder.ToString();
        }

    }
}
