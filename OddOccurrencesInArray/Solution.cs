using System;
using System.Collections.Generic;
using System.Text;

namespace OddOccurrencesInArray
{
    public class Solution
    {
        public int solution(int[] array)
        {
            try
            {
                if (array.Length == 0) return 0;
                if (array.Length == 1) return array[^1];
                if (array.Length % 2 == 0) return 0;

                Array.Sort(array);

                for (int i = 0; i < array.Length - 1; i += 2)
                    if (array[i] != array[i + 1]) return array[i];

                return array[^1];
            }
            catch { throw; }
        }
    }
}
