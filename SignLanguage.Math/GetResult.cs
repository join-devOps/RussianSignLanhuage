using System.Collections.Generic;

namespace SignLanguage.Math
{
    public class GetResult
    {
        public static float GetSum(List<bool> listResult)
        {
            int result = 0;

            foreach (bool list in listResult)
            {
                if (list == true)
                    result += 5;
                else
                    result += 2;
            }

            return result / listResult.Count;
        }

        public static float GetMaxSum(List<bool> listSum)
        {
            int result = 0;

            foreach (bool list in listSum)
                result += 5;

            return result / listSum.Count;
        }

        public static float GetPercent(float sum, float maxSum)
        {
            if (sum != 0 && maxSum != 0)
                return (sum / maxSum) * 100;
            else return 0;
        }
    }
}