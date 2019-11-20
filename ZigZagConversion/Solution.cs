using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Solution
{


    public string Convert(string s, int numRows)
    {
        if (numRows == 1) return s;
        List<List<char>> converted_string = new List<List<char>>(numRows);

        for (int init = 0; init < numRows; ++init)
        {
            converted_string.Add(new List<char>());
        }

        int row_iteration = 0;

        bool ascending = true;

        for (int string_crawler = 0; string_crawler < s.Length; ++string_crawler)
        {
            converted_string[row_iteration].Add(s[string_crawler]);
            if (ascending) ++row_iteration;
            else --row_iteration;

            if (row_iteration >= numRows)
            {
                ascending = false;
                row_iteration = numRows - 2;
                //if (row_iteration < 0) row_iteration = 0;
            }
            else if (row_iteration < 0)
            {
                ascending = true;
                row_iteration = 1;
                //if (row_iteration >= numRows) row_iteration = numRows - 1;
            }

        }

        string converted = "";

        //create the new string
        foreach (List<char> list in converted_string)
        {
            foreach (char single_char in list)
            {
                converted += single_char.ToString();
            }
        }




        return converted;
    }

}
