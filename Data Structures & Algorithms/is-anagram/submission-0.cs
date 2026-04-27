public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) 
        {
            return false;
        }

        Dictionary<char, int> charCounts = [];
        foreach (char sChar in s)
        {
            if (charCounts.ContainsKey(sChar))
            {
                charCounts[sChar] = charCounts[sChar] + 1;
            }
            else 
            {
                charCounts[sChar] = 1;
            }
        }

        foreach (char tChar in t)
        {
            if (!charCounts.ContainsKey(tChar) || charCounts[tChar] == 0)
            {
                return false;
            }
            
            charCounts[tChar] = charCounts[tChar] - 1;
        }

        return true;
    }
}
