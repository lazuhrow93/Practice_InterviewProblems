public class Solution {
    
    public void reset_array(ref bool[] character_found){
        for(int i =0; i<96; ++i){
            character_found[i] = false;
        }
    }
    
    public int LengthOfLongestSubstring(string s) {
        
        bool[] ifchar_found = new bool[96];
        
        for(int i =0; i<96; ++i){
            ifchar_found[i] = false;
        }
        
        int curr_counter = 0;
        int top_counter = 0;
        int start_subStr = 0;
        
        for(int character = 0; character < s.Length; ++character){
            
            if(ifchar_found[s[character] - 32]){ //if that character already found in the sequence
                if(curr_counter > top_counter) top_counter = curr_counter;
                curr_counter = 0;
                
                
                reset_array(ref ifchar_found); 
                
                /*new algorithm start checking from one after the first instance of the repeated character*/
                character = s.IndexOf(s[character], start_subStr);
                start_subStr = character+1;
            
                /*old algorithm, start new subStr after the initial one*/
                //character = start_subStr; //minus because the foor loop will increment one forward
                //start_subStr++; //start the new subarray one character after the first element of the previous subarray
                
                
                
                
            }
            else{
                ++curr_counter;
                ifchar_found[s[character] - 32] = true; //found this characer
            }
        }
        
        if(curr_counter > top_counter) {
            top_counter = curr_counter;
        }
        
        return top_counter;
    }
}
