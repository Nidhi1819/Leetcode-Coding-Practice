public class LRUCache {
    Dictionary<int, int> queue;
    LinkedList<int> cachelist;
    int CAPACITY_SIZE;

    public LRUCache(int capacity) {
       queue= new Dictionary<int,int>();
         cachelist= new LinkedList<int>();
        CAPACITY_SIZE= capacity;

    }
    
    public int Get(int key) {
        Console.WriteLine("Inside Get");
        int value =-1;
        if (queue.ContainsKey(key)){
            cachelist.Remove(key);
            cachelist.AddFirst(key);
            value = queue[key];
        }

        return value ;
    }
    
    public void Put(int key, int value) {
        Console.WriteLine("Inside Put");
        try{
        if(!cachelist.Contains(key) && queue.Count == CAPACITY_SIZE)
        {
            int lastKey = cachelist.Last.Value;
            queue.Remove(lastKey);
            cachelist.RemoveLast();    

            queue.Add(key,value);
            cachelist.AddFirst(key);        
        }
        else
        {
            queue[key]= value;
            cachelist.Remove(key);
            cachelist.AddFirst(key);
        }
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }

    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */