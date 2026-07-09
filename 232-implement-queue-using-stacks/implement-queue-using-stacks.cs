public class MyQueue {
    private Stack<int> stk1;
    private Stack<int> stk2;

    public MyQueue() {
        stk1 = new Stack<int>();
        stk2 = new Stack<int>();
    }
    
    public void Push(int x) {
        while(stk2.Count > 0){
            stk1.Push(stk2.Pop());
        }
        stk1.Push(x);
        while(stk1.Count > 0){
            stk2.Push(stk1.Pop());
        }
    }
    
    public int Pop() {
        return stk2.Pop();
    }
    
    public int Peek() {
        return stk2.Peek();
    }
    
    public bool Empty() {
        return stk2.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */