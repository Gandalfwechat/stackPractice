using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monoStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var testList = new List<int>() { 4, 6, 3, 2, 5, 2, 7 };

            var listIdx = FindthelessValuetoLeftdirection(testList);


        }

        public static List<int> FindthelessValuetoLeftdirection(List<int> testList)
        {
            var stackUse = new Stack<int>();
            var listIdx = new List<int>();
            for (var i = 0; i < testList.Count; i++)
            {
                while (stackUse.Count > 0 && testList[stackUse.Peek()] >= testList[i])
                {
                    stackUse.Pop();
                }
                if (stackUse.Count == 0)
                {
                    listIdx.Add(99);
                }
                else
                {
                    listIdx.Add(stackUse.Peek());
                }

                stackUse.Push(i);
            }

            return listIdx;
        }




    }




}
