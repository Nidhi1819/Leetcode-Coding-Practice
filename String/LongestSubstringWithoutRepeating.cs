public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        int maxLength =0;
        string test="";

        foreach(char c in s)
        {
            var current= c+"";

            if(test.Contains(current))
            {
                test = test.Substring(test.IndexOf(current)+1);
            }
            test = test +c;
            maxLength = Math.Max(test.Length,maxLength);
        }
    return maxLength;
    }
}