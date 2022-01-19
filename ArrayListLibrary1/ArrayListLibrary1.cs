using System;

namespace ArrayListLibrary
{
    public class ArrayList
    {
        private int[] _array;
        private int _currentCount;
        private double _MagnificationFactor=1.5;

        public ArrayList ()
        {

            _array = new int[5];
            _currentCount = 0;
        }

        public ArrayList (int capacity)
        {
            _array = new int[capacity];
            _currentCount = 0;
        }

        public ArrayList (int [] array)
        {
            int size = (int)(array.Length * _MagnificationFactor);
            _array = new int[size];
            _currentCount = _array.Length;
            Filling(array.Length,0 , array);
        }

        public int Length => _currentCount;

        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < _currentCount)
                {
                    return _array[i];
                }

                throw new ArgumentOutOfRangeException("index was out of range.");
            }
        }

        private void ArrayСheck(int number)
        {
            while(_currentCount + number >= _array.Length)
            {
                int[] newArray = new int[(int)(_array.Length * _MagnificationFactor)];
                for (int i = 0; i < (_array.Length); i++)
                {
                    newArray[i] = _array[i];
                }

                _array = newArray;
            }

            _currentCount += number;
        }

        private static int[] FillingTemp(int amount, int index, int[] array)
        {
            int[] temp = new int[(int)(amount)];
            for (int i = 0; i < amount; i++)
            {
                temp[i] = array[i + index];
            }

            return temp;
        }

        private void Filling(int amount, int index, int[] temp)
        {
            for (int i = 0; i < amount; i++)
            {
                _array[i + index] = temp[i];
            }
        }

        //Task1
        public void AddEnd(int value)
        {
            ArrayСheck(1);
            _array[_currentCount - 1] = value;
        }

        //Task2
        public void AddStart(int value)
        {
            ArrayСheck(1);
            int[] temp = new int[0];
            temp = (int[])_array.Clone();
            int amount = _currentCount - 1;
            Filling(amount, 1, temp);
            _array[0] = value;
        }

        //Task3
        public void AddIndex(int index, int value)
        {
            if (index > _currentCount)
            {
                throw new ArgumentOutOfRangeException("index was out of range.");
            }

            ArrayСheck(1);
            int[] temp = new int[0];

            if (index != _currentCount - 1)
            {
                temp = FillingTemp(_currentCount - index - 1, index, _array);
                Filling(_currentCount - index - 1, index + 1, temp);
                _array[index] = value;
            }

            else
            {
                _array[index] = value;
            }
        }

        //Task4
        public void DeleteEnd()
        {
            ArrayСheck(-1);

        }

        //Task5
        public void DeleteStart()
        {
            ArrayСheck(-1);
            int[] temp = new int[0];
            temp = FillingTemp(_currentCount, 1, _array);
            Filling(_currentCount, 0, temp);
        }

        //Task6
        public void DeleteIndex(int index)
        {
            ArrayСheck(-1);
            int[] temp = new int[0];
            temp = FillingTemp(_currentCount - index, index + 1, _array);
            Filling(_currentCount - index, index, temp);
        }

        //Task7
        public void removing_N_ElementsFromTheEnd(int number)
        {
            ArrayСheck(-number);
        }

        //Task8
        public void removing_N_ElementsFromTheStart(int number)
        {
            ArrayСheck(-number);
            int[] temp = new int[0];
            temp = FillingTemp(_currentCount, number, _array);
            Filling(_currentCount, 0, temp);
        }

        //Task9
        public void removing_N_ElementsFromTheIndex(int index, int number)
        {
            if (index + number > _currentCount)
            {
                throw new ArgumentOutOfRangeException("Deleted items are outside the array.");
            }

            if (index + number != _currentCount)
            {
                int[] temp = new int[0];
                temp = FillingTemp(_currentCount-index-number, index + number, _array);
                Filling(temp.Length, index, temp);
                ArrayСheck(-number);
            }

            else
            {
                ArrayСheck(-number);
            }
        }

        //Task 12
        private int FirstIndexByValue(int value)
        {
            int FirstIndex = -1;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == value)
                {
                    FirstIndex = i;
                    //ArrayСheck(-1);
                    break;
                }
            }

            return FirstIndex;
        }

        // Task 13
        public void changeByIndex(int index, int value)
        {
            if (index + 1 > _currentCount)
            {
                throw new ArgumentOutOfRangeException("index was out of range.");
            }

            _array[index] = value;
        }

        // Task 14
        public void reverse()
        {
            int[] temp = new int[_currentCount];
            for (int i = _currentCount - 1; i >= 0; i--)
            {
                temp[_currentCount - 1 - i] = _array[i];
            }

            _array = (int[])temp.Clone();
        }
        public int IndexMaxElement(int[] array)
        {
            int indexMax = 0;
            int valueMax = array[0];
            for (int i = 0; i < _currentCount; i++)
            {
                if (valueMax < array[i])
                {
                    indexMax = i;
                    valueMax = array[i];
                }
            }

            return indexMax;
        }

        public int IndexMinElement(int[] array)
        {
            int indexMin = 0;
            int valueMin = array[0];
            for (int i = 0; i < _currentCount; i++)
            {
                if (valueMin > array[i])
                {
                    indexMin = i;
                    valueMin = array[i];
                }
            }

            return indexMin;
        }

        //Task 15
        public int valueMax()
        {
            int valueMax = _array[IndexMaxElement(_array)];

            return valueMax;
        }

        //Task 16
        public int valueMin()
        {
            int valueMin = _array[IndexMinElement(_array)];

            return valueMin;
        }

        //Task 17
        public int indexMax()
        {
            int indexMax = IndexMaxElement(_array);

            return indexMax;
        }

        //Task 18
        public int indexMin()
        {
            int indexMin = IndexMinElement(_array);

            return indexMin;
        }
        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        //Task 19
        public void SortAscending()
        {
            for (int i = 0; i < _currentCount; i++)
            {
                for (int j = i + 1; j < _currentCount; j++)
                {
                    if (_array[i] > _array[j])
                    {
                        Swap(ref _array[i], ref _array[j]);
                    }
                }
            }
        }

        //Task 20
        public void SortDescending()
        {
            for (int i = 0; i < _currentCount; i++)
            {
                for (int j = i + 1; j < _currentCount; j++)
                {
                    if (_array[i] < _array[j])
                    {
                        Swap(ref _array[i], ref _array[j]);
                    }
                }
            }
        }

        //Task 21
        public int DeleteByValueFirstReturnIndex(int value)
        {
            int Index = FirstIndexByValue(value);
            if (Index != (-1))
            {
                DeleteIndex(Index);
            }

            return Index;
        }

        //Task 22
        public int DeleteByValueAll(int value)
        {
            int IndexTemp = 0;
            for (int i = 0; i < _currentCount; i++)
            {
                if (_array[i] == value)
                {
                    DeleteIndex(i);
                    IndexTemp++;
                    i--;
                }
            }

            return IndexTemp;
        }

        //Task 24
        public void AddingAListToTheEnd (int [] array)
        {
            ArrayСheck(array.Length);
            Filling(array.Length, _currentCount - array.Length , array);
        }

        //Task 25
        public void addingAListToTheBeginning (int[] array)
        {
            ArrayСheck(array.Length);
            int[] temp = (int[])_array.Clone();
            Filling(_currentCount- array.Length, array.Length, temp);
            Filling(array.Length, 0, array);
        }

        //Task 26
        public void AddListByIndex (int index, int[] array)
        {
            if (index > _currentCount)
            {
                throw new ArgumentOutOfRangeException("index was out of range.");
            }

            ArrayСheck(array.Length);
            int[] temp = new int[0];
            if (index != _currentCount - array.Length)
            {
                temp = FillingTemp(_currentCount - index - array.Length, index, _array);
                Filling(_currentCount - index - array.Length, index + array.Length, temp);
                Filling(array.Length, index, array);
            }

            else
            {
                Filling(array.Length, index, array);
            }
        }

        public void Print()
        {
            for (int i = 0; i < _currentCount; i++)
            {
                Console.Write($"{_array[i]} ");
            }
        }
    }
}
