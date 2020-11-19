//https://leetcode.com/problems/min-stack/



public class MinStack {

    public class Node
    {
        public int value_;
        public Node next_;
        //public Node prev_;
        public Node(int val, Node next)
        {
            value_ = val;
            next_ = next;
            //prev_ = prev;
        }
    }
    Node head_;
    
    int min_;
    /** initialize your data structure here. */
    public MinStack() {
        head_ = null;
    }
    
    public void Push(int x) {
        var newNode = new Node(x, null);
        if(head_ == null){ head_ = newNode; min_ = x; }
        else{
            newNode.next_ = head_;
            head_ = newNode;
            if(min_ > x) min_ = x;
        }
        
    }
    
    public void Pop()
    {
        var removedVal = head_.value_;
        head_ = head_.next_;
        if (head_ == null) return;
        if (removedVal == min_)
        {
            Node current = head_;
            min_ = current.value_;
            while (current != null)
            {
                if (current.value_ < min_) min_ = current.value_;
                current = current.next_;
            }
        }
    }
    
    public int Top() {
        return head_.value_;
    }
    
    public int GetMin() {
        return min_;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */