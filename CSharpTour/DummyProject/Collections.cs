//Program structure example

//The fully qualified name of this class is Acme.Collections.Stack.
//The class contains several members: a field named _top, two methods named Push and Pop, and a nested class named Entry.
//The Entry class further contains three members: a property named Next, a property named Data, and a constructor.
//The Stack is a generic class. It has one type parameter, T that is replaced with a concrete type when it's used.

namespace Acme.Collections;
public class Stack<T>
{
    Entry _top;

    public void Push(T data)
    {
        _top = new Entry(_top, data);
    }

    public T Pop()
    {
        if (_top == null)
        {
            throw new InvalidOperationException();
        }
        T result = _top.Data;
        _top = _top.Next;

        return result;
    }

    class Entry
    {
        public Entry Next { get; set; }
        public T Data { get; set; }

        public Entry(Entry next, T data)
        {
            Next = next;
            Data = data;
        }
    }
}
