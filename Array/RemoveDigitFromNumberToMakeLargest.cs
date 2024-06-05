//leetcode 2259. Remove Digit From Number to Maximize Result
// Example 2:

// Input: number = "1231", digit = "1"
// Output: "231"
// Explanation: We can remove the first '1' to get "231" or remove the second '1' to get "123".
// Since 231 > 123, we return "231".
public class RemoveDigitFromNumber{
public static string RemoveDigit(string number, char digit) {
        int index =-1;
        string newstr="";
        for(int i=0; i<number.Length-1; i++)
        {
            if(number[i] == digit &&  number[i] - '0'
          < number[i + 1] - '0')
            {
                index = i;
                    break; 
            }
        }

        if (index == -1) {
      for (int i = number.Length - 1; 
           i >= 0; i--) {
        if (number[i] == digit ) {
          index = i;
          break;
        }
      }
    }
        newstr = number.Remove(index,1);
        Console.WriteLine(newstr);
        return newstr;
    }
}