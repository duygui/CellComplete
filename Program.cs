using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellComplete
{
    class Program
    {
        static void Main(string[] args)
        {
           var x = cellCompete(new int[] { 0, 1, 0, 1, 0, 1, 0, 1 }, 4);
        }
        
        public static int[] cellCompete(int[] states, int days)
        {
            List<int> returnVal = states.ToList();
            for (int dayIdx = 0; dayIdx < days; dayIdx++)
            {
                int[] arrToTry = returnVal.ToArray().Clone() as int[];
                returnVal = new List<int>();
                for (int stateIdx = 0; stateIdx < arrToTry.Length; stateIdx++)
                {
                    int leftVal = stateIdx == 0 ? 0 : arrToTry[stateIdx - 1];
                    int rightVal = stateIdx == arrToTry.Length - 1 ? 0 : arrToTry[stateIdx + 1];
                    returnVal.Add(leftVal == rightVal ? 0 : 1);
                }
            }
            return returnVal.ToArray();
        }
    }
}
