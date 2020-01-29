public class Solution {
    
    public int returnMin(int x, int y){
        if(x < y) return x;
        else return y;
    }
    
    public int MaxArea(int[] height) {
        //find the biggest area. 
        
        int max_area = 0;
        
        
        int bar1_x = 0;        
        int bar1_y = height[bar1_x];
        
        int bar2_x = height.Length-1;
        int bar2_y = height[bar2_x];
        
        int temp_area = 0;
        int temp_x_length = 0;
        
        while(true){

           temp_x_length = bar2_x - bar1_x;
           temp_area = temp_x_length * returnMin(bar2_y,bar1_y);

           if(temp_area > max_area) max_area = temp_area;

           if(bar2_y < bar1_y){ //if the second bar is smaller, update to new bar
               bar2_x--;
               bar2_y=height[bar2_x];
           }
           else{
               bar1_x++;
               bar1_y=height[bar1_x];
           }

           if(bar1_x >= bar2_x) break;

        }
        
    
        return max_area;
        
    }
}
