//The following example shows a generic class called MyList<T>,
//which implements a growable list of objects.
//The class contains several examples of the most common kinds of function members.

namespace OtherFunctionMembers
{
    public class MyList<T>
    {
        const int DefaultCapacity = 4;

        T[] _items;
        int _count;

        //Constructor
        public MyList(int capacity = DefaultCapacity)
        {
            _items = new T[capacity];
        }

        //Property
        //read-only
        public int Count => _count;

        //Property
        //read-write
        public int Capacity
        {
            get => _items.Length;
            set
            {
                if (value < _count) value = _count;
                if (value != _items.Length)
                {
                    T[] newItems = new T[value];
                    Array.Copy(_items, 0, newItems, 0, _count);
                    _items = newItems;
                }
            }
        }

        //Indexer
        public T this[int index]
        {
            get => _items[index];
            set
            {
                if (!object.Equals(_items[index], value))
                {
                    _items[index] = value;
                    OnChanged();
                }
            }
        }

        public void Add(T item)
        {
            if (_count == Capacity) Capacity = _count * 2;
            _items[_count] = item;
            _count++;
            OnChanged();
        }
        protected virtual void OnChanged() =>
            Changed?.Invoke(this, EventArgs.Empty);

        public override bool Equals(object other) =>
            Equals(this, other as MyList<T>);

        static bool Equals(MyList<T> a, MyList<T> b)
        {
            if (Object.ReferenceEquals(a, null)) return Object.ReferenceEquals(b, null);
            if (Object.ReferenceEquals(b, null) || a._count != b._count)
                return false;
            for (int i = 0; i < a._count; i++)
            {
                if (!object.Equals(a._items[i], b._items[i]))
                {
                    return false;
                }
            }
            return true;
        }

        //Event
        public event EventHandler Changed;

        //Operators 

        //These overridden operators give new meaning to expressions that apply those operators to MyList instances.
        //Specifically, the operators define equality of two MyList<T>
        //  instances as comparing each of the contained objects using their Equals methods. 
        public static bool operator ==(MyList<T> a, MyList<T> b) =>
            Equals(a, b);

        public static bool operator !=(MyList<T> a, MyList<T> b) =>
            !Equals(a, b);

    }
}
