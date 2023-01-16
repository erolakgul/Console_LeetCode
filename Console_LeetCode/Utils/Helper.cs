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

    }
}
