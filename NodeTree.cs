using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastTry
{
    public class NodeTree
    {
        public int Value { get; set; }
        public List<NodeTree> Children { get; set; }

        public NodeTree(int value)
        {
            Value = value;
            Children = new List<NodeTree>();

        }

        public void AddChild(NodeTree child)
        {
            Children.Add(child);

        }

    }
}
