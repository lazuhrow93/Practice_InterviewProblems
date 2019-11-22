public class Solution {
    public int Reverse(int x) {
        
        //edge cases
        if(x == -2147483648 || x == 2147483647) return 0;
        
        bool negative = false;
        bool maybe_overflow = false;
        
        char[] overflow_chars = new char[10] {'2','1','4','7','4','8','3','6','4','7'};
        
        if(x < 0) negative = true;
        
        /*
            you only need to check if its more than 999999999, which means it has 10 digits. Any more digits than that
            then it wouldn't even come into this function. 
            
        */
        
        int absValue = Math.Abs(x);
        
        if(absValue > 999999999) maybe_overflow = true;
        
        string str_rep = absValue.ToString();
        
        string flipped_str = "";
        
        for(int crawl = 0; crawl<str_rep.Length; ++crawl){
            if(maybe_overflow){
                //if(str_rep[str_rep.Length-1-crawl] > overflow_chars[crawl]) return 0;
                if(str_rep[str_rep.Length-1-crawl] < overflow_chars[crawl]) maybe_overflow = false;
                else if(str_rep[str_rep.Length-1-crawl] > overflow_chars[crawl]) return 0;
            }
            flipped_str+=str_rep[str_rep.Length-1-crawl];
        }
        
        if(negative) return -1 * Convert.ToInt32(flipped_str);
        return Convert.ToInt32(flipped_str);
    }
}
