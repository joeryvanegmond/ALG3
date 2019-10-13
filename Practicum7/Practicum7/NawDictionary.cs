using System;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum7
{
    public class NawDictionary : INawDictionary
    {
        public int Size { get; }
        protected LogFile[] logFiles;
        private int _count;

        public NawDictionary(int size)
        {
            Size = size;
            logFiles = new LogFile[size];
            for (int i = 0; i < logFiles.Length; ++i)
                logFiles[i] = new LogFile();
        }

        protected int KeyToIndex(string key)
        {
            if (key != null)
            {
                var hashValue = key.GetHashCode();
                var compressedHashValue = hashValue % 10;
                var index = Math.Abs(compressedHashValue);
                return index;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }



        public void Insert(string key, NAW value)
        {
            if (key != null)
            {
                var index = KeyToIndex(key);
                logFiles[index].Insert(key, value);
                _count++;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public NAW Find(string key)
        {
            if (key != null)
            {
                var index = KeyToIndex(key);

                if (logFiles[index].Find(key) != null)
                {
                    return logFiles[index].Find(key);
                }

                return null;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public NAW Delete(string key)
        {
            if (key != null)
            {
                var index = KeyToIndex(key);
                var temp = logFiles[index].Find(key);

                if (temp == null)
                {
                    return null;
                }
                logFiles[index].Delete(key);
                _count--;
                return temp;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }


        public int Count
        {
            get
            {
                return _count;
            }
        }

        public double LoadFactor
        {
            get
            {
                return _count / Size; 
            }
        }
    }
}
