using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetModulTask4
{
    public class Proses
    {
        public  void sort(int[] array, int n)
        {
            for (int j = 1; j <= n - 1; j++)
            {
                for (int k = 0; k <= n - 2; k++)
                {
                    if (array[k] < array[k + 1])
                    {
                        int tempat = array[k];
                        array[k] = array[k + 1];
                        array[k + 1] = tempat;
                    }
                }
            }
        } 
    }
}
