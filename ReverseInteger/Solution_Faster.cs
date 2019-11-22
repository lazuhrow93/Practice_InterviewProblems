public class Solution {
    public int Reverse(int x) {
        
        //pop and push algorithm
        
        int MAX_NUM = 2147483647;
        int MIN_NUM = -2147483648;
        
        int reverse = 0;
        
        //first get the last int
        while(x != 0){
            
            int last_int = x%10;

            //remove the last digit from the integer
            x = x/10;

            //add the integer
            if(reverse > MAX_NUM/10 || (reverse == MAX_NUM/10 && last_int > 7)) return 0; //overflow
            if(reverse < MIN_NUM/10 || (reverse == MIN_NUM/10 && last_int < -8)) return 0; //overflow

            reverse = reverse * 10 + last_int;
        
        }
        
        return reverse;
        
    }
}
