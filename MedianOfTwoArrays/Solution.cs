public int returnMax(int i, int j){
        if(i > j) return i;
        else return j;
    }
    
    public int returnMin(int i, int j){
        if(i < j) return i;
        else return j;
    }
    
    public double findMedianBetweenTwoArrays(int[] a_small, int[] b_big){
        //a_small is the smaller array
        //b_big is the bigger array
        
        bool even = false;
        bool odd = false;
        
        if((a_small.Length + b_big.Length) % 2 == 0) even = true;
        else odd = true;
        
        int min_index = 0;
        int max_index = a_small.Length;
        
        double median = 0;
        int a_partition = 0;
        int b_partition = 0;
        
        while(min_index <= max_index){
            
            a_partition = (min_index + max_index)/2; 
            b_partition = ((a_small.Length + b_big.Length + 1)/2) - a_partition; //b_partition
        
        
            if(a_partition < a_small.Length && b_partition > 0 && b_big[b_partition - 1] > a_small[a_partition]){
                //
                min_index = a_partition + 1;
            }
            else if(b_partition < b_big.Length && a_partition > 0 && b_big[b_partition] < a_small[a_partition-1]){
                
                max_index = a_partition - 1;
            }
            else{ //we got the good halves
                if(a_partition == 0) median = b_big[b_partition - 1];          
                else if(b_partition == 0) median = a_small[a_partition-1];
                else median = returnMax(a_small[a_partition-1], b_big[b_partition-1]);
                break;
            }
            
            
            
        }
            if(odd) return median;
            if(a_partition == a_small.Length) return (median + b_big[b_partition]) /2.0;
            if(b_partition == b_big.Length) return (median + a_small[a_partition]) /2.0;
            
            //even
            return (median+returnMin(a_small[a_partition], b_big[b_partition]))/2.0;
        
    }
    
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
     
        if(nums1.Length > nums2.Length) return findMedianBetweenTwoArrays(nums2, nums1);
        else return findMedianBetweenTwoArrays(nums1, nums2);
        
    }
