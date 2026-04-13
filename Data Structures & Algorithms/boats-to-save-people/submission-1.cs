public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        if (people.Length == 0) 
        {
            return 0;
        }

        if (people.Length == 1) 
        {
            return 1;
        }
        
        Array.Sort(people);
        Array.Reverse(people);
        int startIndex = 0;
        int endIndex = people.Length - 1;
        int boatCount = 0;
        while (startIndex <= endIndex) // strictly less
        {
            if ((people[startIndex] + people[endIndex]) > limit || startIndex == endIndex) 
            {
                startIndex++;
            }
            else
            {
                startIndex++;
                endIndex--;
            }
            boatCount++;
        }


        return boatCount;
    }
}