public class SignOfProductArray {
    public int ArraySign(int[] nums) {
        int productsign = 1;

        for(int i=0; i<nums.Length; i++){
            if (nums[i] == 0){
                return 0;
            }
            if (nums[i] < 0)
                productsign = -1 * productsign;
        }
    
        return productsign;
    }
}