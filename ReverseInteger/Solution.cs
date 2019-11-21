public class Solution {
    public int Reverse(int x) {
        bool negative = false;
        bool maybe_overflow = false;
        if(x < 0) negative = true;
        
        if(x > 999999999) maybe_overflow = true;
        
        int absValue = Math.Abs(x);
        
        string str_rep = absValue.ToString();
        
        string flipped_str = "";
        
        for(int crawl = 0; crawl<str_rep.Length; ++crawl){
            flipped_str+=str_rep[str_rep.Length-1-crawl];
        }
        
        /*
        for(int crawl = 0; crawl<str_rep.Length/2; ++crawl){
            char replace = str_rep[crawl];
            str_rep[crawl] = str_rep[str_rep.Length - 1 - crawl];
            str_rep[x.Length - 1 - crawl] = replace;
            
        }
        */
        
        
        if(negative) return -1 * Convert.ToInt32(flipped_str);
        return Convert.ToInt32(flipped_str);
    }
}
