using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DynamicArray<T> where T: new()
    {
        const int DEFAULT_CAPACITY = 8;
        const int RESERVE = 2; //Во сколько раз увеличивать ёмкость массива при его полном заполнении
        
        private T[] _arr;
        private int currentIndex;

        public int Length
        {
            get
            {
                return currentIndex;
            }
        }

        public int Capacity
        {
            get
            {
                return _arr.Length;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index > this.Length)
                {
                    throw new ArgumentOutOfRangeException
                        ("Index was outside the bounds of the array"); 
                }
                return _arr[index];
            }
            set
            {
                if (index > this.Length)
                {
                    throw new ArgumentOutOfRangeException
                        ("Index was outside the bounds of the array");
                }
                _arr[index] = value;
            }
        }
                                                                                   
        public DynamicArray()
        {
            this._arr = new T[DEFAULT_CAPACITY];
            SetDefault(0, _arr.Length);
            currentIndex = 0;
        }
        
        public DynamicArray(int length)
        {
            this._arr = new T[length];
            currentIndex = 0;
        }

        public DynamicArray(T[] initialArray)
        {
            this._arr = new T[initialArray.Length];
            for (int i = 0; i < initialArray.Length; i++)
            {
                this._arr[i] = initialArray[i];
            }
            currentIndex = initialArray.Length - 1;
        }
        
        private void SetDefault(int leftBound, int rightBound)
        {
            for (int i = leftBound; i < rightBound; i++)
            {
                _arr[i] = default(T);
            }
        }

        public void Add(T element)
        {
            if (currentIndex == _arr.Length - 1)
            {
                ExpandCapacity(_arr.Length);
            }
            this._arr[currentIndex] = element;
            currentIndex++;
        }

        public void AddRange(T[] rangeArray)
        {
            if (rangeArray.Length + (currentIndex+1) > _arr.Length)
            {
                ExpandCapacity(rangeArray.Length + currentIndex);
            }
            foreach (var element in rangeArray)
            {
                this._arr[currentIndex] = element;
                currentIndex++;
            }
        }

        public void Remove(T element)
        {
            T[] tempArr = new T[_arr.Length];
            int j = 0;
            for (int i = 0; i < _arr.Length; i++)
            {
                if (!_arr[i].Equals(element))
                {
                    tempArr[j] = _arr[i];
                    j++;
                }
                else
                {
                    currentIndex--;
                }
            }
            _arr = tempArr;
        }

        public bool Insert(T element, int position)
        {
            if (position > this.Length)
            {
                throw new ArgumentOutOfRangeException("Index was outside the bounds of the array");
            }
            if (currentIndex == _arr.Length - 1)
            {
                ExpandCapacity(_arr.Length);
            }
            int i = currentIndex;
            while (i != position - 1)
            {
                _arr[i + 1] = _arr[i];
                i--;
            }
            _arr[position] = element;
            currentIndex++;
            return true;
        }

        private void ExpandCapacity(int Capacity) //Увеличение реальной ёмкости
        {
            T[] tempArr = new T[Capacity * RESERVE];//Увеличиваем в заданное кол-во раз
            for (int i = 0; i < _arr.Length; i++)
            {
                tempArr[i] = _arr[i];
            }
            _arr = tempArr;
        }
    }
}
