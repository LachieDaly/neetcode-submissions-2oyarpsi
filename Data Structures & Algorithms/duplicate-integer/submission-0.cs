public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> numSet = [];
        foreach (int num in nums)
        {
            if (numSet.Contains(num))
            {
                return true;
            }
            numSet.Add(num);
        }
        
        return false;
    }
}