public class Solution {
    public int[] PlusOne(int[] digits) {
        int i=digits.Length-1;
        for (;i>=0;i--){
            if(digits[i]!=9){
                digits[i]++;

                return digits;
            }
            digits[i]=0;
        }
        var newDigits=new int[digits.Length+1];
        newDigits[0]=1;

        return newDigits;
    }
}