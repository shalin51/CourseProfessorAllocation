using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProfessorAllocation
{
   public class BST
    {
        public BST()
        {
            Root = null;
            Nodes = new List<Node>();
            Nodes.Add(Root);
        }       
        public Node Root { get; set; }
        public List<Node> Nodes { get; set; }

        int[] rand = new int[] { 99, 98, 92, 97, 95,45,23,43,98,4,6,34,54,2345,44,5412,21,10 };
        int[] sortedArray = new int[] { 1, 2, 3, 4, 5, 6, 7};
       public void SortBST()
        {
            //Array.Sort(rand);
            GetMedianWrapper(sortedArray, 0, sortedArray.Length - 1);
        }

        public void GetMedianWrapper(int[] arr, int startIndex, int endIndex)
        {
            if (startIndex<endIndex)
            {
                int median = GetMedian(startIndex,endIndex);
                AddNode(new Node { value = arr[median] },this.Root);                                 
                GetMedianWrapper(arr, startIndex, median-1);                                                                               
                GetMedianWrapper(arr, median+1, endIndex);                                  
            }
            else
            {
                AddNode(new Node { value = arr[startIndex] },this.Root);
            }           
        }
        public int GetMedian(int startIndex,int endIndex)
        {
            return ((startIndex+endIndex)/2);
        }

        public void AddNode(Node node,Node root)
        {
            
            if (Root==null)
            {
               Root = node;
            }
            else
            {
                if (node.value > root.value)
                {
                    if (root.RightChild == null)
                    {
                        root.RightChild = node;
                    }
                    else 
                    {
                        AddNode(node, root.RightChild);
                    }
                  
                }
                else
                {
                    if (root.LeftChild == null)
                    {
                       root.LeftChild = node;
                    }
                    else
                    {
                        AddNode(node,root.LeftChild);
                    }
                }

            }

        }
    }
}
