public class ArrayOperations {
    public int RemoveDuplicates(int[] nums) {        
        
        int i=0, j= 0, l= nums.Length;
        int[] expectednum =new int[l];
        expectednum[i] = nums[j];
        j++;
        
        while(j<l && i<l)
        {
            if(expectednum[i]!=nums[j] )
            { 
                expectednum[++i] = nums[j];
                j++;
            }
            else if(expectednum[i] == nums[j])
                j++;                
            
        }
        
        nums = new int[i+1];
        
        for(int num=0 ; num<nums.Length; num++)
        {   Console.WriteLine(num) ;
            nums[num] = expectednum[num];
        }
        return nums.Length;
    }

    
}