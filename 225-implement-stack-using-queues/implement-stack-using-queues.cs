public class MyStack {

   Queue<int> q = new Queue<int>();
   private int top = -1;
    
    public void Push(int x) {
        q.Enqueue(x);
        top = x;
        int size = q.Count;
        while(size > 1)
        {
            int frond = q.Dequeue();
            q.Enqueue(frond);
            size--;
        }
    }
    
    public int Pop() {
        int remove = q.Dequeue();
        if(q.Count > 0)
        {
            top = q.Peek();
        }
        return remove;
    }
    
    public int Top() {
        return top;
    }
    
    public bool Empty() {
        return q.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */