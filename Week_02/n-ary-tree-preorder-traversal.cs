using System.Collections.Generic;
using System;
public class Solution
{
    public IList<int> Preorder(Node root)
    {
        var Traversal = new List<int>();
        if (root == null) return Traversal;
        var S = new Stack<Node>();
        S.Push(root);

        // 把孩子们倒序压入栈中即可
        while (S.Count != 0)
        {
            Node cur = S.Pop();
            Traversal.Add(cur.val);
            if (cur.children != null)
            {
                for (int i = cur.children.Count - 1; i >= 0; i--)
                {
                    S.Push(cur.children[i]);
                }
            }
        }

        return Traversal;
    }
}

public class Node
{
    public int val;
    public List<Node> children;

    public Node() { }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, List<Node> _children)
    {
        val = _val;
        children = _children;
    }
}