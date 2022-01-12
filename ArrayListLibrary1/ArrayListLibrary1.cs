using System;

namespace ArrayListLibrary1
{
    public class ArrayList
    {
        private int[] _array;
        private int _currentCount;
        private double _MagnificationFactor;

        public ArrayList()
        {
            _array = new int[5];
            _currentCount = 0;
            _MagnificationFactor = 1.5;
        }

        public int Length => _currentCount;

        public int this [int i]
        {
            get
            {
                if (i >=0 && i < _currentCount)
                {
                    return _array[i];
                }

                throw new ArgumentOutOfRangeException("index was out of range.");
            }
        }

        private void ArrayСheck (int number)
        {
            if (_currentCount+ number>= _array.Length)
            {
                int[] newArray = new int[(int)(_array.Length * _MagnificationFactor)];
                for (int i = 0; i < (_array.Length); i++)
                {
                    newArray[i] = _array[i];
                }

                _array = newArray;
            }

            if (_currentCount + number < 0)
            {
                throw new ArgumentOutOfRangeException("index was out of range.");
            }

            _currentCount += number;
        }

        private static int [] FillingTemp(int amount, int index, int [] array)
        {
            int[] temp = new int[(int)(amount)];
            for (int i = 0; i < amount; i++)
            {
                temp[i] = array[i + index];
            }

            return temp;
        }

        private void Filling (int amount, int index, int [] temp)
        {
            for (int i = 0; i < amount; i++)
            {
                _array [i+ index] = temp [i];
            }
        }

        public void Add1 (int value)
        {
            ArrayСheck(1);
            int[] temp = new int[(int)(1)];
            temp[0] = value;
            int index = _currentCount - 1;
            Filling(1, index, temp);
        }

        public void AddStart2(int value)
        {
            ArrayСheck(1);
            int[] temp = new int[(int)(0)];
            temp = (int [])_array.Clone();
            int amount = _currentCount - 1;
            Filling(amount, 1, temp);
            _array[0] = value;
        }

        public void AddIndex3(int index, int value)
        {
            if (index > _currentCount+1)
            {
                throw new ArgumentOutOfRangeException("index was out of range.");
            }

            ArrayСheck(1);
            int[] temp = new int[(int)(0)];

            if (index != _currentCount)
            {
                temp = FillingTemp(_currentCount - index, index-1, _array);
                Filling(_currentCount - index, index, temp);
                _array[index - 1] = value;
            }

            else
            {
                _array[index - 1] = value;
            }
        }

        public void DeleteEnd4()
        {
            ArrayСheck(-1);

        }

        public void DeleteStart5()
        {
            ArrayСheck(-1);
            int[] temp = new int[(int)(0)];
            temp = FillingTemp(_currentCount, 1, _array);
            Filling(_currentCount, 0, temp);
        }

        public void DeleteIndex6(int index)
        {
            ArrayСheck(-1);
            int[] temp = new int[(int)(0)];
            temp = FillingTemp(_currentCount+1-index, index, _array);
            Filling(_currentCount+1 - index, index-1, temp);
        }

        public void removing_N_ElementsFromTheEnd7(int number)
        {
            ArrayСheck(-number);
        }

        public void removing_N_ElementsFromTheStart8(int number)
        {
            ArrayСheck(-number);
            int[] temp = new int[(int)(0)];
            temp = FillingTemp(_currentCount, number , _array);
            Filling(_currentCount, 0, temp);
        }

        public void removing_N_ElementsFromTheIndex9(int index, int number)
        {
            if (index+number > _currentCount)
            {
                throw new ArgumentOutOfRangeException("Deleted items are outside the array.");
            }

            ArrayСheck(-number);
            int[] temp = new int[(int)(0)];
            temp = FillingTemp(number, index - 1 + number, _array);
            Filling(number, index-1, temp);
        }

        private static int [] indexByValue(int value, int [] array)
        {
            int[] temp = new int[(array.Length)];
            int indexTemp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array [i] == value)
                {
                    temp[indexTemp] = i + 1;
                    indexTemp++;
                }

                return temp;
            }
        }

        //Task 12


        // Task 13
        public void changeByIndex13 (int index, int value)
        {
            _array[index - 1] = value;
        }

        // Task 14
        public void reverse ()
        {
            int[] temp = new int[_currentCount];
            for (int i = _currentCount - 1; i >= 0; i--)
            {
                temp[_currentCount-1-i] = _array[i];
            }

            _array = (int[])temp.Clone();
        }

        private static (int indexMim, int indexMax, int valueMin, int valueMax) minMax (int [] array)
        {
            int indexMim = 0;
            int indexMax = 0;
            int valueMin = array[0];
            int valueMax = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (valueMax > array[i])
                {
                    valueMax = array[i];
                    indexMax = i;
                }

                if (valueMin < array[i])
                {
                    valueMin = array[i];
                    indexMim = i;
                }
            }

            return (indexMim, indexMax, valueMin, valueMax);
        }

        //Task 15
        public int valueMax15()
        {
            (int indexMim, int indexMax, int valueMin, int valueMax) =minMax(_array);

            return valueMax;
        }

        //Task 16
        public int valueMin16()
        {
            (int indexMim, int indexMax, int valueMin, int valueMax) = minMax(_array);

            return valueMin;
        }

        //Task 17
        public int indexMax17()
        {
            (int indexMim, int indexMax, int valueMin, int valueMax) = minMax(_array);

            return indexMax+1;
        }

        //Task 18
        public int indexMin18()
        {
            (int indexMim, int indexMax, int valueMin, int valueMax) = minMax(_array);

            return indexMim+1;
        }

        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        //Task 19
        public void sortAscending19()
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
        public void sortDescending20()
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

        public void deleteByValueFirstReturnIndex(int value)
        {
            temp = tyj(value, _array);
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
