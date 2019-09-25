using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Exceptions;
using Alg1.Practica.Utils.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg1.Practica.Practicum1
{
    public class NawArrayUnordered : INawArray
    {
        protected Alg1NawArray _nawArray;
        public Alg1NawArray Array => _nawArray;
        protected int _size;
        protected int _used;
        private Boolean _result = false;

        // constructor
        public NawArrayUnordered(int initialSize)
        {
            //throw new System.NotImplementedException();
            _size = initialSize;
            _used = 0;


            if (_size < 1 || _size > 1000000)
            {
                throw new Utils.Exceptions.NawArrayUnorderedInvalidSizeException();
            }

            _nawArray = new Alg1NawArray(_size);




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

            if (_size != _used)
            {
                _nawArray[_used] = item;
                _used++;
            }
            else
            {
                throw new Utils.Exceptions.NawArrayUnorderedOutOfBoundsException();
            }

        }

        public int Find(NAW item)
        {
            int found = 0;
            for (int i = 0; i < _used; i++) {
                if (item.Equals(_nawArray[i]))
                {

                    found = i;
                    break;

                }
                else {
                    found = - 1;
                }
            }

            return found;
        }



        public void Show()
        {
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

        public NAW ItemAtIndex(int index)
        {
            if (_nawArray[index] == null || index > _used || index < 0)
            {
                throw new Utils.Exceptions.NawArrayOrderedOutOfBoundsException();
            }
            return _nawArray[index];
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

        public bool Remove(NAW item)
        {
            var index = Find(item);
            RemoveAtIndex(index);
            return _result;
        }

    }

}
