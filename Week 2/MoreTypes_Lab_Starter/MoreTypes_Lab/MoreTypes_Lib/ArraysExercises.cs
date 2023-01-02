using System;
using System.Collections.Generic;

namespace MoreTypes_Lib
{
    public class ArraysExercises
    {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents)
        {
            string[] mySymbols = { "Alpha", "Beta", "Gamma", "Delta", "Epsilon", "Zeta" };
            return mySymbols;
            throw new NotImplementedException();
        }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
        {
            if (length1 + length2 +length3 != contents.Count)
            {
                throw new ArgumentException("Number of elements in list must match array size");
            }
            string[,,] output = new string[length1, length2, length3];
            int index = 0;
            for (int x = 0; x < length1; x++)
            {
                for (int y = 0; y < length2; y++)
                {
                    for (int z = 0; z < length3; z++)
                    {
                        output[x, y, z] = contents[index];
                        index++;
                    }
                }
            }
            return output;
            //if (length1*length2*length3 == contents.Count)
            //{
            //    string[,,] mySymbols = new string[2, 1, 3];
            //    mySymbols[0, 0, 0] = "Alpha";
            //    mySymbols[0, 0, 1] = "Beta";
            //    mySymbols[0, 0, 2] = "Gamma";
            //    mySymbols[1, 0, 0] = "Delta";
            //    mySymbols[1, 0, 1] = "Epsilon";
            //    mySymbols[1, 0, 2] = "Zeta";
            //    return mySymbols;
            //}
            //else
            //{
            //    throw new ArgumentException("Number of elements in list must match array size");
            //}
            //throw new NotImplementedException();
        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {
            if (countRow1 + countRow2!= contents.Count)
            {
                throw new ArgumentException("Number of elements in list must match array size");
            }
            string[][] output = new string[2][];
            output[0] = new string[countRow1];
            output[1] = new string[countRow2];
            int index = 0;
            foreach(string element in contents)
            {
                if (index < countRow1)
                {
                    output[0][index] = element;
                }
                else
                {
                    output[1][index - countRow1] = element;
                }
                index++;
            }
            return output;
            //string[][] mySymbols = new string[][]
            //{
            //    new string[] {"Alpha"},
            //    new string[] {"Beta"},
            //    new string[] {"Gamma"},
            //    new string[] {"Delta"},
            //    new string[] {"Epsilon"},
            //    new string[] {"Zeta"}
            //};
            //return mySymbols;
            //throw new NotImplementedException();
        }
    }
}
