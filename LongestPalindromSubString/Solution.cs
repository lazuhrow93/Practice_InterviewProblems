using System;


/// <summary>
/// Summary description for Class1
/// </summary>
public class Solution
{
    public int testChar(string s, int start, int end)
    {
        int left_pt = start;
        int right_pt = end;

        while(left_pt >= 0 && right_pt < s.Length && s[left_pt] == s[right_pt])
        {
                //expand outwards to check the next chars
                --left_pt;
                ++right_pt;
        }

        return right_pt - left_pt - 1; //return the length of the current palindrome

    }

    public string LongestPalindrome(string s)
    {
        //trying to widen out from each character. 

        string winner_substr = "";

        //gettting rid of the edge cases
        if (s.Length == 0) return "";
        else if (s.Length == 1) return s;
        else winner_substr = s[0].ToString();

        int start = 0, end = 0; //current indicies for longest palindrome

        for(int string_crawler = 0; string_crawler < s.Length; ++string_crawler)
        {
            int test_sub1 = testChar(s, string_crawler, string_crawler);
            int test_sub2 = testChar(s, string_crawler, string_crawler + 1);

            int longestSub = Math.Max(test_sub1, test_sub2); //this will give you the longest sub palindrome

            if(longestSub > end - start) //if longer than the previous one
            {
                //get the left/right side of the test char that is a palindrome
                start = string_crawler - (longestSub - 1) / 2;
                end = string_crawler + longestSub / 2;
            }

            
        }
        return s.Substring(start, end - start + 1);


        return "";
    }

	public string wrong_LongestPalindrome(string s)
    {

        string winner = "";

        if (s.Length == 1) return s;
        else if (s.Length == 0) return "";
        else winner = s[0].ToString();

        int string_crawler = 0;
        int first_char_of_test_palindrome = 0;
        int last_char_of_test_palindrome = s.Length-1;
        int longest_palindrome = -1;
        int test_length = 0;

        bool palindrome = true;

        while (string_crawler < s.Length)
        {

            first_char_of_test_palindrome = string_crawler;
            last_char_of_test_palindrome = s.IndexOf(s[first_char_of_test_palindrome], first_char_of_test_palindrome + 1);
            if (last_char_of_test_palindrome  != -1){ //then you found the second instance of the character
                //so now check if its a palindrom from the first char to the last char

                test_length = last_char_of_test_palindrome - first_char_of_test_palindrome;

                while(first_char_of_test_palindrome < last_char_of_test_palindrome && palindrome) //if its == or if the left sides passes the right side, end it
                {

                    if (s[first_char_of_test_palindrome] == s[last_char_of_test_palindrome]) //if they are the same char, increment and then move on to the next characters
                    {
                        first_char_of_test_palindrome++;
                        last_char_of_test_palindrome--;
                    }
                    else palindrome = false;

                }

                if(palindrome) //then it past the palindrome test
                {
                    if (test_length > longest_palindrome)
                    {
                        longest_palindrome = test_length;
                        winner = s.Substring(string_crawler, test_length+1);
                    }

                }
                else
                {
                    palindrome = true;
                }

            }


            string_crawler++;
        }

        




        return winner;
    }
}
