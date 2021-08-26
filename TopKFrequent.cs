		//https://leetcode.com/problems/top-k-frequent-elements/
		
		
		/*public static int[] TopKFrequent(int[] nums, int k)
        {
            var pairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (pairs.ContainsKey(nums[i])) pairs[nums[i]]++;
                else pairs.Add(nums[i], 1);
            }
            var ordered = pairs.OrderByDescending(e => e.Value).ToArray();
            var rslt = new List<int>();
            for(int i = 0; i < k; i++)
            {
                rslt.Add(ordered.ElementAt(i).Key);
            }
            return rslt.ToArray();

        }*/
		
	public class Solution {
		//using SortedDictionary - TreeMap
		public int[] TopKFrequent(int[] nums, int k) {
			var dict = new Dictionary<int, int>();
			foreach(var item in nums){
				if(dict.ContainsKey(item)) dict[item]++;
				else dict.Add(item, 1);
			}
			var sorted = new SortedDictionary<int, List<int>>();
			foreach(var item in dict){
				if(sorted.ContainsKey(item.Value)) sorted[item.Value].Add(item.Key);
				else sorted.Add(item.Value, new List<int>(){item.Key});
			}
			var keys = sorted.Keys.ToArray();
			var rs = new int[k];
			int idx = 0;
			for(int i = keys.Length - 1; i >= 0 && idx < k; i--){
				for(int j = 0; j < sorted[keys[i]].Count && idx < k; j++)
					rs[idx++] = sorted[keys[i]][j];
			}
			return rs;
		}
		
		
		
		public int[] TopKFrequent(int[] nums, int k)
        {
            var pairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (pairs.ContainsKey(nums[i])) pairs[nums[i]]++;
                else pairs.Add(nums[i], 1);
            }
            var sortedByValue = new MySortedDictionary();
            foreach(var pair in pairs){
                sortedByValue.Add(pair);
            }
            var rslt = new List<int>();
            for(int i = 0; i < k; i++)
            {
                rslt.Add(sortedByValue.popTail().Key);
            }
            return rslt.ToArray();
            
        }
        
	}
	class MySortedDictionary
    {
        public class Node
        {
            
            public KeyValuePair<int, int> KeyValuePair_;
            public Node next_;
            public Node prev_;
            public Node(KeyValuePair<int,int> keyValuePair, Node next, Node prev)
            {
                KeyValuePair_ = keyValuePair;
                next_ = next;
                prev_ = prev;
            }
        }
        Node root_;
        Node tail_;
        public int length { get; set; }
        

        public MySortedDictionary()
        {
            root_ = null;
            length = 0;
        }
        public void calculateLength()
        {
            this.length = 0;
            Node current = root_;
            while (current != null)
            {
                length++;
                current = current.next_;
            }
        }
        public void Add(KeyValuePair<int,int> newKeyValuePair)
        {
            
            var newNode = new Node(newKeyValuePair, null, null);
            if (root_ == null) { root_ = newNode; tail_ = newNode;  length++; }
            else
            {
                Node current = root_;

                while (current != null)
                {
                    if(current.next_ == null && newKeyValuePair.Value > current.KeyValuePair_.Value)
                    {
                        current.next_ = newNode;
                        current.next_.prev_ = current;
                        tail_ = current.next_;
                        length++;
                        return;
                    }
                    if(newKeyValuePair.Value <= current.KeyValuePair_.Value)
                    {
                        if(current.prev_ == null)
                        {
                            current.prev_ = newNode;
                            current.prev_.next_ = current;
                            root_ = current.prev_;
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
        public KeyValuePair<int,int> popTail()
        {
            KeyValuePair<int, int> rslt = new KeyValuePair<int,int>();
            if (tail_ == null) return rslt;
            if (tail_.prev_ == root_)
            {
                root_.next_ = null;
                rslt = tail_.KeyValuePair_;
                tail_ = root_;
            }
            else if (tail_.prev_ == null)
            {
                rslt = tail_.KeyValuePair_;
                root_ = tail_ = null;
            }
            else
            {
                tail_.prev_.next_ = null;
                rslt = tail_.KeyValuePair_;
                tail_ = tail_.prev_;
            }
            length--;
            
            return rslt;
        }
        

	}
        