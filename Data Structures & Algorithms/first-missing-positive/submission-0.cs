public class Solution {
    public int FirstMissingPositive(int[] nums) {
        HashSet<int> positiveNums = [];
        int maxNumber = 1;
        foreach (int num in nums)
        {
            if (num > 0 && !positiveNums.Contains(num))
            {
                positiveNums.Add(num);
                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }
        }

        for (int i = 1; i <= maxNumber + 1; i++)
        {
            if (!positiveNums.Contains(i))
            {
                return i;
            }
        }

        return -1;
    }
}