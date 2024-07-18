/*
Given a string text, you want to use the characters of text to form as many instances of the word "balloon" as possible.
You can use each character in text at most once. Return the maximum number of instances that can be formed.
Example 1:
Input: text = "nlaebolko"
Output: 1
Example 2:
Input: text = "loonbalxballpoon"
Output: 2
Example 3:
Input: text = "leetcode"
Output: 0
*/


namespace ChallengeLab_11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text1 = "nlaebolko";
            string text2 = "loonbalxballpoon";
            string text3 = "leetcode";

            Solution solution = new Solution();

            Console.WriteLine(solution.MaxNumberOfBalloons(text1));  // Output: 1
            Console.WriteLine(solution.MaxNumberOfBalloons(text2));  // Output: 2
            Console.WriteLine(solution.MaxNumberOfBalloons(text3));  // Output: 0
        }
    }

    public class Solution
    {
        public int MaxNumberOfBalloons(string text)
        {
            Dictionary<char, int> charDict = new Dictionary<char, int>();


            foreach (char c in text)
            {
                if (charDict.ContainsKey(c))
                {
                    charDict[c] += 1;
                }
                else
                {
                    charDict.Add(c, 1);
                }
            }

            int bCount = charDict.ContainsKey('b') ? charDict['b'] : 0;
            int aCount = charDict.ContainsKey('a') ? charDict['a'] : 0;
            int lCount = charDict.ContainsKey('l') ? charDict['l'] : 0;
            int oCount = charDict.ContainsKey('o') ? charDict['o'] : 0;
            int nCount = charDict.ContainsKey('n') ? charDict['n'] : 0;

            // 'l' and 'o' are needed twice for each "balloon"
            lCount /= 2;
            oCount /= 2;

            // The maximum number of "balloon" instances is determined by the minimum count of the needed characters
            int result = Math.Min(Math.Min(Math.Min(bCount, aCount), lCount), Math.Min(oCount, nCount));

            return result;
        }
    }
}
