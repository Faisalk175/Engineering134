using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            List<int> listNums = new();   
           for(int i = 1; i <= max; i++)
            {
                if(i % 5 == 0)
                {
                    listNums.Add(i);  
                }              
            }
           return listNums;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            List<string> list = new();  
            foreach(string s in sourceList)
            {
                if (s.StartsWith('a') || s.StartsWith('A'))
                {
                    list.Add(s);    
                }
                
            }
            return list;
        }
    }
}
