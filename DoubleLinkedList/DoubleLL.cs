using System;

namespace DoubleLinkedList
{
    public class DoubleLL
    {
        private Node _root;
        private Node _tail;
        public int Length { get; private set; }

        public DoubleLL()
        {
            _root = null;
            _tail = null;
            Length = 0;
        }

        public DoubleLL(int a)
        {
            _root = new Node(a);
            _tail = _root;
            Length = 1;
        }

        public DoubleLL(int[] array)
        {
            if (array.Length != 0)
            {
                _root = new Node(array[0]);
                Node tmp = _root;
                for (int i = 1; i < array.Length; i++)
                {
                    tmp.Next = new Node(array[i]);
                    tmp.Next.Prev = tmp;
                    tmp = tmp.Next;
                }
                _tail = tmp;
                Length = array.Length;
            }
            else
            {
                _root = null;
                _tail = null;
                Length = 0;
            }
        }

        public void Add(int value)
        {
            if (Length > 0)
            {
                Node tmp = _tail;
                tmp.Next = new Node(value);
                tmp.Next.Prev = tmp;
                _tail = tmp.Next;
                Length++;
            }
            else
            {
                _root = new Node(value);
                _tail = _root;
                Length++;
            }
        }

        public void Add(int[] array)
        {
            if (Length == 0)
            {
                if (array.Length != 0)
                {
                    _root = new Node(array[0]);
                    Node tmp = _root;
                    for (int i = 1; i < array.Length; i++)
                    {
                        tmp.Next = new Node(array[i]);
                        tmp.Next.Prev = tmp;
                        tmp = tmp.Next;
                    }
                    _tail = tmp;
                    Length = array.Length;
                }
                else
                {
                    _root = null;
                    _tail = null;
                    Length = 0;
                }
            }
            else
            {
                if (array.Length != 0)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        _tail.Next = new Node(array[i]);
                        _tail.Next.Prev = _tail;
                        _tail = _tail.Next;
                    }
                    Length += array.Length;
                }
            }
        }

        public void AddByFirst(int value)
        {
            if (Length > 0)
            {
                Node tmp = _root;
                tmp.Prev = new Node(value);
                tmp.Prev.Next = tmp;
                _root = tmp.Prev;
                Length++;
            }
            else
            {
                _root = new Node(value);
                _tail = _root;
                Length++;
            }
        }

        public void AddByFirst(int[] array)
        {
            if (Length == 0)
            {
                if (array.Length != 0)
                {
                    _root = new Node(array[0]);
                    Node tmp = _root;
                    for (int i = 1; i < array.Length; i++)
                    {
                        tmp.Next = new Node(array[i]);
                        tmp.Next.Prev = tmp;
                        tmp = tmp.Next;
                    }
                    _tail = tmp;
                    Length = array.Length;
                }
                else
                {
                    _root = null;
                    _tail = null;
                    Length = 0;
                }
            }
            else
            {
                if (array.Length != 0)
                {
                    Node tmp = new Node(array[0]);
                    Node tmp1 = tmp;
                    for (int i = 1; i < array.Length; i++)
                    {
                        tmp.Next = new Node(array[i]);
                        tmp.Next.Prev = tmp;
                        tmp = tmp.Next;
                    }
                    tmp.Next = _root;
                    _root.Prev = tmp;
                    _root = tmp1;
                    Length += array.Length;
                }
            }
        }

        public void AddByIndex(int index, int value)
        {
            if (index < 0 || index > Length)
            {
                throw new NullReferenceException();
            }
            else
            {
                if (index == 0)
                {
                    AddByFirst(value);
                }
                else if (index <= Length / 2)
                {
                    Node tmp = _root;
                    for (int i = 1; i < index; i++)
                    {
                        tmp = tmp.Next;
                    }
                    Node tmp2 = tmp.Next;
                    tmp.Next = new Node(value);
                    tmp.Next.Prev = tmp;
                    tmp = tmp.Next;
                    tmp.Next = tmp2;
                    tmp2.Prev = tmp;
                    Length++;
                }
                else
                {
                    Node tmp = _tail;
                    for (int i = Length - 1; i > index; i--)
                    {
                        tmp = tmp.Prev;
                    }
                    Node tmp2 = tmp.Prev;
                    tmp.Prev = new Node(value);
                    tmp.Prev.Next = tmp;
                    tmp = tmp.Prev;
                    tmp.Prev = tmp2;
                    tmp2.Next = tmp;
                    Length++;
                }
            }
        }

        public void AddByIndex(int index, int[] array)
        {
            if (index >= 0)
            {
                if (Length == 0 || index >= Length)
                {
                    Add(array);
                }
                else
                {
                    if (index == 0)
                    {
                        AddByFirst(array);
                    }
                    else
                    {
                        if (index <= Length / 2)
                        {
                            Node tmp = _root;
                            for (int i = 1; i < index; i++)
                            {
                                tmp = tmp.Next;
                            }
                            Node tmp1 = tmp.Next;
                            for (int i = 0; i < array.Length; i++)
                            {
                                tmp.Next = new Node(array[i]);
                                tmp.Next.Prev = tmp;
                                tmp = tmp.Next;
                            }
                            tmp.Next = tmp1;
                            tmp1.Prev = tmp;
                            Length += array.Length;
                        }
                        else
                        {
                            Node tmp = _tail;
                            for (int i = Length - 1; i > index; i--)
                            {
                                tmp = tmp.Prev;
                            }
                            Node tmp1 = tmp.Prev;
                            for (int i = array.Length - 1; i >= 0; i--)
                            {
                                tmp.Prev = new Node(array[i]);
                                tmp.Prev.Next = tmp;
                                tmp = tmp.Prev;
                            }
                            tmp.Prev = tmp1;
                            tmp1.Next = tmp;
                            Length += array.Length;
                        }
                    }
                }
            }
        }

        public void Remove(int number = 1)        {            if (Length < number)            {                throw new IndexOutOfRangeException();            }            else if (number < 0)            {                throw new ArgumentOutOfRangeException();            }            else if (Length > 0 && Length - number > 0)            {                for (int i = Length; i > Length - number; i--)                {                    _tail = _tail.Prev;                }                _tail.Next = null;                Length -= number;            }            else
            {
                _root = null;
                _tail = null;
                Length = 0;
            }        }

        public void RemoveFirst(int number = 1)
        {
            if (Length < number)
            {
                throw new IndexOutOfRangeException();
            }
            else if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (Length > 0 && Length - number > 0)
            {
                for (int i = 0; i < number; i++)
                {
                    _root = _root.Next;
                }
                _root.Prev = null;
                Length -= number;
            }
            else
            {
                _root = null;
                _tail = null;
                Length = 0;
            }
        }

        public void RemoveByIndex(int index, int number = 1)
        {
            if (index > Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else if (Length < number || number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (index == 0)
            {
                RemoveFirst(number);
            }
            else if (index == Length - 1 || index + number == Length)
            {
                Remove(number);
            }
            else
            {
                Node current = GetNodeByIndex(index);
                for (int i = 0; i < number; i++)
                {
                    current.Next.Prev = current.Prev;
                    current.Prev.Next = current.Next;
                    current = current.Next;
                }
                Length -= number;
            }
        }

        public void RemoveItemFirstValue(int value)
        {
            if (Length > 0 && _root != null)
            {
                Node current = _root;
                for (int i = 0; i < Length; i++)
                {
                    if (current.Value == value)
                    {
                        RemoveByIndex(i);
                        break;
                    }
                    current = current.Next;
                }
            }
        }

        public void RemoveItemByValueAll(int value)
        {
            if (Length > 0 && _root != null)
            {
                Node current = _root;
                for (int i = 0; i < Length; i++)
                {
                    if (current.Value == value)
                    {
                        RemoveByIndex(i);
                        i--;
                    }
                    current = current.Next;
                }
            }
        }

        public int GetIndexByValue(int value)
        {
            if (Length > 0 && _root != null)
            {
                Node current = _root;
                for (int i = 0; i < Length; i++)
                {
                    if (current.Value == value)
                    {
                        return i;
                    }
                    current = current.Next;
                }
            }
            
                return -1;
        }

        public void ChangeIndex(int index, int value)
        {
            if (index > Length || index < 0)
            {
                throw new NullReferenceException();
            }
            else
            {
                if (Length > 0 && _root != null)
                {
                    Node current = _root;
                    for (int i = 0; i < Length; i++)
                    {
                        if (i == index)
                        {
                            current.Value = value;
                        }
                        current = current.Next;
                    }
                }
            }
        }

        public int GetMaxItem()
        {
            Node current = _root;
            int max = _root.Value;
            if (Length > 0 && _root != null)
            {
                for (int i = 1; i < Length; i++)
                {
                    current = current.Next;
                    if (current.Value > max)
                    {
                        max = current.Value;
                    }
                }
            }
            return max;
        }

        public int GetMinItem()
        {
            Node current = _root;
            int min = _root.Value;
            if (Length > 0 && _root != null)
            {
                for (int i = 1; i < Length; i++)
                {
                    current = current.Next;
                    if (current.Value < min)
                    {
                        min = current.Value;
                    }
                }
            }
            return min;
        }

        public int GetIndexMaxItem()
        {
            Node current = _root;
            int max = _root.Value;
            int indexMax = 0;
            if (Length > 0 && _root != null)
            {
                for (int i = 1; i < Length; i++)
                {
                    current = current.Next;
                    if (current.Value > max)
                    {
                        max = current.Value;
                        indexMax = i;
                    }
                }
            }
            return indexMax;
        }

        public int GetIndexMinItem()
        {
            Node current = _root;
            int min = _root.Value;
            int indexMin = 0;
            if (Length > 0 && _root != null)
            {
                for (int i = 1; i < Length; i++)
                {
                    current = current.Next;
                    if (current.Value < min)
                    {
                        min = current.Value;
                        indexMin = i;
                    }
                }
            }
            return indexMin;
        }

        public void Reverse()
        {
            Node current = _root;
            Node tmp;
            if (_root != null && _root.Next != null)
            {
                while (current != null)
                {
                    tmp = current.Next;
                    current.Next = current.Prev;
                    current.Prev = tmp;
                    current = current.Prev;
                }
                tmp = _root;
                _root = _tail;
                _tail = tmp;
            }
        }

        public void SortLayout()
        {
            Node rootNext = _root.Next;
            Node tmp;
            Node current;
            if (_root != null && _root.Next != null)
            {
                while (rootNext.Next != null)
                {
                    tmp = rootNext;
                    rootNext = rootNext.Next;
                    if (tmp.Prev != null)
                    {
                        tmp.Prev.Next = tmp.Next;
                    }
                    tmp.Next.Prev = tmp.Prev;
                    current = _root;
                    while (current.Next != null && current.Next.Value < tmp.Value)
                    {
                        current = current.Next;
                    }
                    tmp.Next = current.Next;
                    tmp.Prev = current;
                    if (tmp.Next != null)
                    {
                        tmp.Next.Prev = tmp;
                    }
                    current.Next = tmp;
                }
                _tail = rootNext;
                if (_root.Value > _root.Next.Value)
                {
                    tmp = _root;
                    _root = tmp.Next;
                    _root.Prev = null;
                    current = _root;
                    while (current.Next != null && current.Next.Value < tmp.Value)
                    {
                        current = current.Next;
                    }
                    tmp.Next = current.Next;
                    tmp.Prev = current;
                    if (tmp.Next != null)
                    {
                        tmp.Next.Prev = tmp;
                    }
                    current.Next = tmp;
                    if (tmp.Next == null)
                    {
                        _tail = tmp;
                    }
                }
            }
        }

        public void SortDecrease()
        {
            Node rootNext = _root.Next;
            Node tmp;
            Node current;
            if (_root != null && _root.Next != null)
            {
                while (rootNext.Next != null)
                {
                    tmp = rootNext;
                    rootNext = rootNext.Next;
                    if (tmp.Prev != null)
                    {
                        tmp.Prev.Next = tmp.Next;
                    }
                    tmp.Next.Prev = tmp.Prev;
                    current = _root;
                    while (current.Next != null && current.Next.Value > tmp.Value)
                    {
                        current = current.Next;
                    }
                    tmp.Next = current.Next;
                    tmp.Prev = current;
                    if (tmp.Next != null)
                    {
                        tmp.Next.Prev = tmp;
                    }
                    current.Next = tmp;
                }
                _tail = rootNext;
                if (_root.Value < _root.Next.Value)
                {
                    tmp = _root;
                    _root = tmp.Next;
                    _root.Prev = null;
                    current = _root;
                    while (current.Next != null && current.Next.Value > tmp.Value)
                    {
                        current = current.Next;
                    }
                    tmp.Next = current.Next;
                    tmp.Prev = current;
                    if (tmp.Next != null)
                    {
                        tmp.Next.Prev = tmp;
                    }
                    current.Next = tmp;
                    if (tmp.Next == null)
                    {
                        _tail = tmp;
                    }
                }
            }
        }

        public override bool Equals(object obj)
        {
            DoubleLL doubleLL = (DoubleLL)obj;

            if (Length != doubleLL.Length)
            {
                return false;
            }
            if (Length != 0)
            {
                Node tmp1 = _root;
                Node tmp2 = doubleLL._root;

                while (tmp1 != null || tmp2 != null)
                {
                    if (tmp1.Value != tmp2.Value)
                    {
                        return false;
                    }
                    tmp1 = tmp1.Next;
                    tmp2 = tmp2.Next;
                }

                tmp1 = _tail;
                tmp2 = doubleLL._tail;

                while (tmp1 != null || tmp2 != null)
                {
                    if (tmp1.Value != tmp2.Value)
                    {
                        return false;
                    }
                    tmp1 = tmp1.Prev;
                    tmp2 = tmp2.Prev;
                }
            }
            return true;
        }

        public override string ToString()
        {
            string s = "";

            Node tmp = _root;
            for (int i = 0; i < Length; i++)
            {
                s += tmp.Value + ";";
                tmp = tmp.Next;
            }
            return s;
        }

        public int GetLength()
        {
            int count = 0;
            for (int i = 1; i <= Length; i++)
            {
                count++;
            }
            return count;
        }

        private Node GetNodeByIndex(int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            Node current;

            if (index < Length / 2)
            {
                current = _root;

                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;
                }
            }
            else
            {
                current = _tail;

                for (int i = Length - 1; i > index; i--)
                {
                    current = current.Prev;
                }
            }
            return current;
        }
    }
}
