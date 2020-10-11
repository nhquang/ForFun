public class MyHashSet
{
	public class Node
        {
            public int val_;
            public Node next_;
            public Node prev_;
            public Node(int val, Node next, Node prev)
            {
                val_ = val;
                next_ = next;
                prev_ = prev;
            }
        }
        Node root_;
        public int length;
        
        public MyHashSet()
        {
            root_ = null;
            length = 0;
        }
        public int calculateLength()
        {
            length = 0;
            if (root_ == null) return length;
            else
            {
                length++;
               Node current = root_;
               while(current != null)
               {
                    length++;
                    current = current.next_;
               }
            }
            return length;
        }
        public void Add(int key)
        {
            if (this.Contains(key)) return;
            var newNode = new Node(key, null, null);
            if (root_ == null) { root_ = newNode; length++; }
            else
            {
                Node current = root_;
                
                while(current != null)
                {
                    if (current.next_ == null)
                    {
                        current.next_ = newNode;
                        current.next_.prev_ = current;
                        length++;
                        return;
                    }
                    current = current.next_;

                }
            }
        }

        public void Remove(int key)
        {
            if (!Contains(key)) return;
            Node current = root_;
            
            
            while(current != null)
            {
                if(current.val_ == key)
                {
                    if (current.next_ == null)
                    {
                        current.prev_.next_ = null;
                        current = null;
                    }
                    else if (current.prev_ == null)
                    {
                        root_ = current.next_;
                        current = null;
                    }
                    else
                    {
                        current.prev_.next_ = current.next_;
                        current.next_.prev_ = current.prev_;
                        current = null;
                    }
                    length--;
                    return;
                }
                current = current.next_;
            }
        }

        
        public bool Contains(int key)
        {
            if (root_ == null) return false;
            Node current = root_;
            if (current.val_ == key) return true;
            while (current != null)
            {
                if (current.val_ == key) return true;
                else
                    current = current.next_;
            }
            return false;
        }
}