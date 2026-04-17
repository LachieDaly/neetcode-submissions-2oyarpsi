public class MyStack {
    bool _topOnOne;
    private Queue<int> _queueOne;
    private Queue<int> _queueTwo;

    public MyStack() 
    {
        bool _topOnOne = true;
        _queueOne = new Queue<int>();
        _queueTwo = new Queue<int>();
    }
    
    public void Push(int x) 
    {
        if (_topOnOne)
        {
            _queueOne.Enqueue(x);
            RebalanceQueues(_queueOne, _queueTwo);
        }
        else 
        {
            _queueTwo.Enqueue(x);
            RebalanceQueues(_queueTwo, _queueOne);
        }
    }

    
    public int Pop() 
    {
        int topValue;
        if (_topOnOne) 
        {
            topValue = _queueOne.Dequeue();
            RebalanceQueues(_queueTwo, _queueOne);
        }
        else 
        {
            topValue = _queueTwo.Dequeue();
            RebalanceQueues(_queueOne, _queueTwo);
        }
        _topOnOne = !_topOnOne;
        return topValue;
    }
    
    public int Top() 
    {
        if (_topOnOne)
        {
            return _queueOne.Peek();
        }
        else
        {
            return _queueTwo.Peek();
        }
    }
    
    public bool Empty() 
    {
        return _queueOne.Count == 0 && _queueTwo.Count == 0;
    }

    private void RebalanceQueues(Queue<int> topQueue, Queue<int> leftoverQueue)
    {
        while (topQueue.Count > 1)
        {
            leftoverQueue.Enqueue(topQueue.Dequeue());
        }
    }
}