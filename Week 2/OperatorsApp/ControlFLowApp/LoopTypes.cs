﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ControlFLowApp
{
    public static class LoopTypes
    {
        internal static int HighestDoWhileLoop(List<int> nums)
        {
            int i = 0;
            int highest = nums[0];
            do
            {
                if (nums[i + 1] > highest)
                {
                    highest = nums[i + 1];
                }
                ++i;
            }
            while (i < (nums.Count - 1));
            return highest;
        }

        internal static int HighestForEachLoop(List<int> nums)
        {
            int highest = nums[0];
            foreach(int i in nums)
            {
                if (i > highest)
                {
                    highest = i;
                }
            }
            return highest;
        }

        internal static int HighestForLoop(List<int> nums)
        {
            int highest = nums[0];
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
            }
            return highest;
                
            
            
        }

        internal static int HighestWhileLoop(List<int> nums)
       
        {
            int highest = nums[0];
            int i = 0;
            while (i < nums.Count())
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
                i++;
            } return highest;
        }  
    }
}







