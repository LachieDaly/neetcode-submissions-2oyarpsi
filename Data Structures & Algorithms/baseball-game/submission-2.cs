public class Solution {
    public int CalPoints(string[] operations) {
        List<int> scores = [];
        for (int i = 0; i < operations.Length; i++)
        {
            bool removeLastScore = false;
            int operationScore = 0;
            switch (operations[i])
            {
                case "+":
                    operationScore = scores[scores.Count - 2] + scores[scores.Count - 1];
                    break;
                case "D":
                    operationScore = scores[scores.Count - 1] * 2;
                    break;
                case "C":
                    removeLastScore = true;
                    break;
                default:
                    operationScore = int.Parse(operations[i]);
                    break;
            }
            if (removeLastScore)
            {
                scores.RemoveAt(scores.Count - 1);
            }
            else 
            {
                scores.Add(operationScore);
            }
        }

        int totalScore = 0;
        foreach (int score in scores)
        {
            totalScore += score;
        }
        return totalScore;
    }
}