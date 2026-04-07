public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string lcp = string.Empty;

        if (strs.Length == 1) 
        {
            return strs[0];
        }
        
        for (int i = 0; i < strs[0].Length; i++) 
        {
            char letter = strs[0][i];
            for (int j = 1; j < strs.Length; j++) 
            {
                if (i >= strs[j].Length || strs[j][i] != letter)
                {
                    return lcp;
                }
            }
            lcp += letter;
        }

        return lcp;
    }
}