using System;
using System.Collections.Generic;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Exceptions;
using Alg1.Practica.Utils.Models;


namespace Alg1.Practica.Practicum1
{
    public class NawArrayOrdered : INawArray, INawArrayOrdered
    {
        protected Alg1NawArray _nawArray;

        public Alg1NawArray Array => _nawArray;

        protected int _size;
        protected int _used = 0;
        private Boolean _result = false;

        public NawArrayOrdered(int initialSize)
        {
            _size = initialSize;

            if (_size < 1 || _size > 1000000)
            {
                throw new Utils.Exceptions.NawArrayOrderedInvalidSizeException();
            }

            _nawArray = new Alg1NawArray(_size);
        }

        public void Show()
        {
            // Niet gevraagd

            System.Console.WriteLine("Array contains {0} of {1} items.", _used, _size);
            for (int i = 0; i < _size; i++)
            {
                if (i == _used)
                {
                    System.Console.WriteLine("------------------------------------------------------");
                }
                System.Console.Write("Item {0} contains: ", i);
                if (_nawArray[i] != null)
                {
                    _nawArray[i].Show();
                }
                else
                {
                    System.Console.WriteLine("nothing");
                }
            }
        }

        public int Count
        {
            get { return ItemCount(); }
            set { _used = value; }

        }

        public int ItemCount()
        {
            return _used;
        }

        public virtual void Add(NAW item)
        {

            if (_used < _size)
            {
                for (var indexChecker = 0; indexChecker < _used; indexChecker++)
                {
                    if (item.CompareTo(_nawArray[indexChecker]) == -1)
                    {
                        for (var i = _used; i > indexChecker; i--)
                        {
                            _nawArray[i] = _nawArray[i - 1];
                        }
                        _nawArray[indexChecker] = item;
                        _used++;
                        return;
                    }

                }
                _nawArray[_used] = item;
                _used++;
            }
            else
            {
                throw new NawArrayOrderedOutOfBoundsException();
            }


        }

        public void RemoveAtIndex(int index)
        {
            if (_nawArray[index] == null || index > _size || index < 0)
            {
                throw new Utils.Exceptions.NawArrayUnorderedOutOfBoundsException();
            }
            _nawArray[index] = null;

            for (int i = index; i < _used; i++)
            {
                _nawArray[i] = _nawArray[i + 1];
            }
            _used--;
            _result = true;
        }

        public virtual bool Remove(NAW item)
        {
            var index = Find(item);
            RemoveAtIndex(index);
            return _result;
        }

        public NAW ItemAtIndex(int index)
        {
            if (_nawArray[index] == null || index > _used || index < 0)
            {
                throw new Utils.Exceptions.NawArrayOrderedOutOfBoundsException();
            }

            return _nawArray[index];
        }


        public int Find(NAW item)
        {
            int found = 0;
            for (int i = 0; i < _used; i++)
            {
                if (item.Equals(_nawArray[i]))
                {
                    found = i;
                    break;
                }
                else
                {
                    found = -1;
                }
            }
            return found;
        }

        public bool Update(NAW oldValue, NAW newValue)
        {
            if (Find(oldValue) != -1)
            {
                Remove(oldValue);
                Add(newValue);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


