//https://leetcode.com/problems/copy-list-with-random-pointer
using DataStructures;
using System.Collections.Generic;

namespace Algorithms.Leetcode
{
    public class CopyListRandomPointer
    {
        public static Node CopyListWithRandomPointersRecursive(Node head)
        {
            Dictionary<Node, Node> map = new Dictionary<Node, Node>();
            return RecursiveHelper(head, map);
        }

        public static Node RecursiveHelper(Node head, Dictionary<Node, Node> map)
        {
            if (head == null)
                return null;

            if (map.ContainsKey(head))
                return map[head];

            Node node = new Node(head.val);
            map.Add(head, node);

            node.next = RecursiveHelper(head.next, map);
            node.random = RecursiveHelper(head.next, map);
            return node;
        }

        public static Node CopyListWithRandomPointersIterative(Node head)
        {
            Dictionary<Node, Node> map = new Dictionary<Node, Node>();
            Node headDummy = new Node(-1);
            for (Node dummy = headDummy; head != null; head = head.next, dummy = dummy.next)
            {
                if (!map.ContainsKey(head))
                    map.Add(head, new Node(head.val));

                if (head.random != null && !map.ContainsKey(head.random))
                    map.Add(head.random, new Node(head.random.val));

                dummy.next = map[head];
                dummy.next.random = head.random == null ? null : map[head.random];

            }
            return headDummy.next;
        }

        public static Node CopyListWithRandomPointers(Node head)
        {
            if (head == null)
                return null;
            Node ptr = head;
            while (ptr != null)
            {
                Node newNode = new Node(ptr.val);
                newNode.next = ptr.next;
                ptr.next = newNode;
                ptr = newNode.next;
            }

            ptr = head;
            while (ptr != null)
            {
                ptr.next.random = ptr.random != null ? ptr.random.next : null;
                ptr = ptr.next.next;
            }
            Node ptr_old = head;
            Node ptr_new = head.next;
            Node head_old = head.next;
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
