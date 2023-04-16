using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastTry
{
    class Program
    {
        
        static void Main(string[] args)
        {
            NodeTree root = new NodeTree(1);
            NodeTree child1 = new NodeTree(2);
            NodeTree child2 = new NodeTree(0);
            NodeTree grandChild1 = new NodeTree(0);
            NodeTree grandChild2 = new NodeTree(0);
            NodeTree grandChild3 = new NodeTree(0);
            NodeTree grandChild4 = new NodeTree(0);
            NodeTree GgrandChild1= new NodeTree(4);
            NodeTree GgrandChild2 = new NodeTree(0);
            NodeTree GgrandChild3 = new NodeTree(0);
            NodeTree GggrandChild1 = new NodeTree(3);

            root.AddChild(child1);
            root.AddChild(child2);
            child1.AddChild(grandChild1);
            child2.AddChild(grandChild2);
            child2.AddChild(grandChild3);
            child2.AddChild(grandChild4);
            grandChild2.AddChild(GgrandChild1);
            grandChild3.AddChild(GgrandChild2);
            grandChild3.AddChild(GgrandChild3);
            GgrandChild2.AddChild(GggrandChild1);

            int depth = CalDepth(root);
            Console.WriteLine("Depth of provided structure is: " + depth);

        }

        private static int CalDepth(NodeTree node)
        {
            if (node.Children.Count == 0)
            {
                return 0;
            }

            int maxDepth = 0;

            foreach (NodeTree child in node.Children)
            {
                int childDepth = CalDepth(child);
                if (childDepth > maxDepth)
                {
                    maxDepth = childDepth;
                }

            }

            return maxDepth + 1;
        }
    }
}
