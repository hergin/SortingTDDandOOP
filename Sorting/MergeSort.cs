using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class MergeSort : Sort
    {
        public List<int> sort(List<int> list)
        {
            if(list.Count==1)
            {
                return new List<int> { list[0] };
            }
            else if (list.Count == 2)
            {
                if(list[0]>list[1])
                {
                    return new List<int> { list[1],list[0] };
                }
                else
                {
                    return new List<int> { list[0], list[1] };
                }
            }
            else
            {
                // CUT INTO TWO PIECES
                List<int> list1 = list.GetRange(0, list.Count / 2);
                List<int> list2 = list.GetRange(list.Count / 2, list.Count / 2);

                // RECURSIVE SORT
                List<int> sorted1 = sort(list1);
                List<int> sorted2 = sort(list2);

                // MERGE
                List<int> mergedList = new List<int>();
                while(sorted1.Count>0 && sorted2.Count>0)
                {
                    if (sorted1[0] < sorted2[0])
                    {
                        mergedList.Add(sorted1[0]);
                        sorted1.RemoveAt(0);
                    }
                    else if (sorted1[0] > sorted2[0])
                    {
                        mergedList.Add(sorted2[0]);
                        sorted2.RemoveAt(0);
                    }
                }

                if (sorted1.Count > 0)
                    mergedList.AddRange(sorted1);
                if (sorted2.Count > 0)
                    mergedList.AddRange(sorted2);
                
                return mergedList;
            }
        }
    }
}