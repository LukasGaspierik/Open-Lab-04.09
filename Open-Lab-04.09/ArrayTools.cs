using System;
using System.Collections.Generic;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            List<string> list = new List<string> { };
            int lenght = strings.Length;
            for (int l = 0; l < lenght; l++)
            {
                if (!list.Contains(strings[l]))
                {
                    list.Add(strings[l]);
                }
                else
                {

                }
            }
            return list.ToArray();

        }
    }
}
