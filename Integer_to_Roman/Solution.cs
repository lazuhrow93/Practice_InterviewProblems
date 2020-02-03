public class Solution {
    public string IntToRoman(int num) {
        string roman_rep = "";
        
        int num_of_chars = 0;
        
        //roman numeral M
        if(num >= 1000){
            num_of_chars = num/1000;
            for(int i = 0; i<num_of_chars;++i) roman_rep += "M";   
        }

        //get rid of 1000s;
        num = num % 1000;
        if(num == 0) return roman_rep;
        
        if(num >= 900){
            roman_rep += "CM";
        }
        
        //get rid of 900s;
        num = num % 900;
        if(num == 0) return roman_rep;
        
        if(num >= 500){
            roman_rep += "D";
        }
        
        //get rid of 500s;
        num = num % 500;
        if(num == 0) return roman_rep; // if 0, then were done
        
        if(num >= 400){
            roman_rep += "CD";
        }
        
        //get rid of 400s;
        num = num % 400;
        if(num == 0) return roman_rep;// if 0, then were done
        
        if(num >= 100){
            num_of_chars = num/100;
            for(int i = 0; i<num_of_chars;++i) roman_rep += "C";
        }
        
        num = num % 100;
        if(num == 0) return roman_rep;
        
        if(num >= 90){
            roman_rep += "XC";
        }
        
        num = num % 90;
        if(num == 0) return roman_rep;// if 0, then were done
        
        if(num >= 50){
            roman_rep += "L";
        }
        
        num = num % 50;
        if(num == 0) return roman_rep;
        
        if(num >= 40){
            roman_rep += "XL";
        }
        
        num = num % 40;
        if(num == 0) return roman_rep;
        
        if(num >= 10){
            num_of_chars = num/10;
            for(int i = 0; i<num_of_chars;++i) roman_rep += "X";
        }
        
        num = num % 10;
        if(num == 0) return roman_rep;
        
        if(num >= 9){
            roman_rep += "IX";
        }
        
        num = num % 9;
        if(num == 0) return roman_rep;
        
        if(num >= 5){
            roman_rep += "V";
        }
        
        num = num % 5;
        if(num == 0) return roman_rep;
        
        if(num >= 4){
            roman_rep += "IV";
        }
        
        num = num % 4;
        
        if(num == 0) return roman_rep;
        
        if(num >= 1){
            num_of_chars = num/1;
            for(int i = 0; i<num_of_chars;++i) roman_rep += "I";
        }
        
        return roman_rep;
        
        
    }
}
