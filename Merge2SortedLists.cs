	//https://leetcode.com/problems/merge-two-sorted-lists/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        var sorted = new MySortedList();

        ListNode current = l1;
        while(current != null){
            sorted.Add(current.val);
            current = current.next;
        }
        current = l2;
        while(current != null){
            sorted.Add(current.val);
            current = current.next;
        }
        if(sorted.length == 0) return null;
        var rslt = new ListNode();
        current = rslt;
        while (sorted.popHead(out int? val))
            {
                current.val = val.Value;
                if (sorted.length > 0)
                {
                    current.next = new ListNode();
                    current = current.next;
                }
            }
        return rslt;
        
    }
}
class MySortedList
{
    public class Node
    {

        public int value_ { get; private set; }
        public Node next_;
        public Node prev_;
        public Node(int val, Node next, Node prev)
        {
            value_ = val;
            next_ = next;
            prev_ = prev;
        }
    }
    Node head_;
    Node tail_;
    public int length { get; private set; }


    public MySortedList()
    {
        head_ = null;
        tail_ = null;
        length = 0;
    }

    public void Add(int val)
    {

        var newNode = new Node(val, null, null);
        if (head_ == null) { head_ = newNode; tail_ = newNode; length++; }
        else
        {
            Node current = head_;

            while (current != null)
            {
                if (current.next_ == null && val > current.value_)
                {
                    current.next_ = newNode;
                    current.next_.prev_ = current;
                    tail_ = current.next_;
                    length++;
                    return;
                }
                if (val <= current.value_)
                {
                    if (current.prev_ == null)
                    {
                        current.prev_ = newNode;
                        current.prev_.next_ = current;
                        head_ = current.prev_;
                    }
                    else
                    {
                        current.prev_.next_ = newNode;
                        current.prev_.next_.prev_ = current.prev_;
                        current.prev_.next_.next_ = current;
                        current.prev_ = current.prev_.next_;
                    }

                    length++;
                    return;
                }
                current = current.next_;

            }
        }
    }
    public bool popTail(out int? rslt)
        {
            rslt = null;
            bool removed = false;
            if (tail_ == null) return removed;
            if (tail_.prev_ == head_)
            {
                head_.next_ = null;
                rslt = tail_.value_;
                tail_ = head_;

            }
            else if (tail_.prev_ == null)
            {
                rslt = tail_.value_;
                head_ = tail_ = null;

            }
            else
            {
                tail_.prev_.next_ = null;
                rslt = tail_.value_;
                tail_ = tail_.prev_;

            }
            removed = true;
            length--;

            return removed;
        }
        public bool popHead(out int? rslt)
        {
            rslt = null;
            bool removed = false;
            if (head_ == null) return removed;

            if (head_.next_ == tail_)
            {
                tail_.prev_ = null;
                rslt = head_.value_;
                head_ = tail_;
            }
            else if (head_.next_ == null)
            {
                tail_ = null;
                rslt = head_.value_;
                head_ = null;
            }
            else
            {
                head_.next_.prev_ = null;
                rslt = head_.value_;
                head_ = head_.next_;
            }
            removed = true;
            length--;
            return removed;
        }
}