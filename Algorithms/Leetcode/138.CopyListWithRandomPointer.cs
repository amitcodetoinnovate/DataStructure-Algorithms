//https://leetcode.com/problems/copy-list-with-random-pointer
using DataStructures;
using System.Collections.Generic;

namespace Algorithms.Leetcode
{
    public class CopyListRandomPointer
    {
        public static NodeWithRandom CopyListWithRandomPointersRecursive(NodeWithRandom head)
        {
            Dictionary<NodeWithRandom, NodeWithRandom> map = new Dictionary<NodeWithRandom, NodeWithRandom>();
            return RecursiveHelper(head, map);
        }

        public static NodeWithRandom RecursiveHelper(NodeWithRandom head, Dictionary<NodeWithRandom, NodeWithRandom> map)
        {
            if (head == null)
                return null;

            if (map.ContainsKey(head))
                return map[head];

            NodeWithRandom nodeWithRandom = new NodeWithRandom(head.val);
            map.Add(head, nodeWithRandom);

            nodeWithRandom.next = RecursiveHelper(head.next, map);
            nodeWithRandom.random = RecursiveHelper(head.next, map);
            return nodeWithRandom;
        }

        public static NodeWithRandom CopyListWithRandomPointersIterative(NodeWithRandom head)
        {
            Dictionary<NodeWithRandom, NodeWithRandom> map = new Dictionary<NodeWithRandom, NodeWithRandom>();
            NodeWithRandom headDummy = new NodeWithRandom(-1);
            for (NodeWithRandom dummy = headDummy; head != null; head = head.next, dummy = dummy.next)
            {
                if (!map.ContainsKey(head))
                    map.Add(head, new NodeWithRandom(head.val));

                if (head.random != null && !map.ContainsKey(head.random))
                    map.Add(head.random, new NodeWithRandom(head.random.val));

                dummy.next = map[head];
                dummy.next.random = head.random == null ? null : map[head.random];

            }
            return headDummy.next;
        }

        public static NodeWithRandom CopyListWithRandomPointers(NodeWithRandom head)
        {
            if (head == null)
                return null;
            NodeWithRandom ptr = head;
            while (ptr != null)
            {
                NodeWithRandom newNodeWithRandom = new NodeWithRandom(ptr.val);
                newNodeWithRandom.next = ptr.next;
                ptr.next = newNodeWithRandom;
                ptr = newNodeWithRandom.next;
            }

            ptr = head;
            while (ptr != null)
            {
                ptr.next.random = ptr.random != null ? ptr.random.next : null;
                ptr = ptr.next.next;
            }
            NodeWithRandom ptr_old = head;
            NodeWithRandom ptr_new = head.next;
            NodeWithRandom head_old = head.next;
            while (ptr_old != null)
            {
                ptr_old.next = ptr_old.next.next;
                ptr_new.next = ptr_new.next != null ? ptr_new.next.next : null;
                ptr_old = ptr_old.next;
                ptr_new = ptr_new.next;
            }
            return head_old;
        }
    }
}
