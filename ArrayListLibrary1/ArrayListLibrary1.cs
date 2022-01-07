using System;

namespace ArrayListLibrary1
{
    public class ArrayList
    {
        private int[] _array;
        private int _currentCount;
        private double _MagnificationFactor;
        private double _indexSearch;

        public ArrayList()
        {
            _array = new int[5];
            _currentCount = 0;
            _MagnificationFactor = 1.5;
            _indexSearch = 0;
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

        // Task 1
        public void Adding1 (int number)
        {
            if(_currentCount != _array.Length)
            {
                _array[_currentCount] = number;
            }

            else
            {
                int[] newArray = new int[(int)(_array.Length * _MagnificationFactor)];
                for (int i = 0; i < (_array.Length); i++)
                {
                    newArray[i] = _array[i];
                }

                newArray[_currentCount] = number;
                _array = newArray;
            }

            _currentCount++;
        }

        // Task 2
        public void AddingBeginning2(int number)
        {

            int[] newArray = new int[(_array.Length + 1)];
            for (int i = 0; i < (_array.Length); i++)
            {
                newArray[i+1] = _array[i];
            }

            newArray[0] = number;
            _array = newArray;
            _currentCount++;
        }

        // Task 3
        public void addingValueByIndex3 (int Index, int value)
        {
            if (Index >= 0 && Index < _array.Length)
            {
                int[] newArray = new int[(int)(_array.Length + 1)];
                for (int i = 0; i < Index; i++)
                {
                    newArray[i] = _array[i];
                }

                newArray[Index] = value;
                for (int i = Index; i < _array.Length; i++)
                {
                    newArray[i + 1] = _array[i];
                }

                _array = newArray;
                _currentCount++;
            }

            else
            {
                throw new ArgumentOutOfRangeException("index was out of range.");
            }
        }

        // Task 4
        public void removeOneElementFromTheEnd4()
        {
            if (_currentCount == 0)
            {
                throw new ArgumentOutOfRangeException("index was out of range.");
            }

            else if (_currentCount == 1)
            {
                _array[0] = 0;
                _currentCount--;
            }

            else
            {
                _array[_array.Length-1]=0;
                _currentCount--;
            }
        }

        // Task 5
        public void deletingOneElementFromTheBeginning5()
        {
            if (_currentCount == 0)
            {
                throw new ArgumentOutOfRangeException("index was out of range.");
            }

            else if (_currentCount == 1)
            {
                _array[0] = 0;
                _currentCount--;
            }

            else
            {
                int[] newArray = new int[(_array.Length - 1)];
                for (int i = 1; i < (_array.Length); i++)
                {
                    newArray[i-1] = _array[i];
                }
                _array = newArray;
                _currentCount--;
            }
        }

        //Task 6
        public void deletingOneElementAtTheIndex6(int Index)
        {
            if (Index >= 0 && Index < _array.Length)
            {
                int[] newArray = new int[(int)(_array.Length - 1)];
                for (int i = 0; i < Index; i++)
                {
                    newArray[i] = _array[i];
                }

                for (int i = Index; i < _array.Length; i++)
                {
                    newArray[i-1] = _array[i];
                }

                _array = newArray;
                _currentCount--;
            }

            else
            {
                throw new ArgumentOutOfRangeException("index was out of range.");
            }
        }

        //Task 7
        public void removing_N_ElementsFromTheEnd7(int value)
        {
            if (value > _currentCount)
            {
                throw new ArgumentOutOfRangeException("index was out of range.");
            }

            else if (value == _currentCount)
            {
                int[] newArray = new int[(int)(0)];
                _array = newArray;
                _currentCount = 0;
            }
            else
            {
                int[] newArray = new int[(int)(_array.Length - value)];
                for (int i = 0; i < value; i++)
                {
                    newArray[i] = _array[i];
                }
                _array = newArray;
                _currentCount -=value;
            }
        }

        //Task 8
        public void deleting_N_ElementsFromTheBeginning8(int value)
        {
            if (value > _currentCount)
            {
                throw new ArgumentOutOfRangeException("index was out of range.");
            }

            else if (value == _currentCount)
            {
                int[] newArray = new int[(int)(0)];
                _array = newArray;
                _currentCount = 0;
            }
            else
            {
                int[] newArray = new int[(int)(_array.Length - value)];
                for (int i = 0; i < value; i++)
                {
                    newArray[i] = _array[i + value];
                }
                _array = newArray;
                _currentCount -= value;
            }
        }

        //Task 9
        public void deletingByIndex_N_elements9(int value, int Index)
        {
            if (Index + value > _currentCount)
            {
                throw new ArgumentOutOfRangeException("index was out of range.");
            }

            else if (Index + value == _currentCount)
            {
                int[] newArray = new int[(int)(0)];
                _array = newArray;
                _currentCount = 0;
            }
            else
            {
                int[] newArray = new int[(int)(_array.Length - value)];
                for (int i = 0; i < Index; i++)
                {
                    newArray[i] = _array[i];
                }

                for (int i = Index + value; i < _array.Length; i++)
                {
                    newArray[i - value] = _array[i];
                }

                _array = newArray;
                _currentCount -= value;
            }
        }

        //Task 12
        public void firstIndexByValue12(int value)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == value)
                {
                    _indexSearch = i + 1;
                    break;
                }

                //???
                else
                {

                }
            }
        }

        //Task 13
        public void changeByIndex13(int value, int index)
        {
            _indexSearch = 0;
            if (index > _currentCount && index < 0)
            {
                throw new ArgumentOutOfRangeException("index was out of range.");
            }

            else
            {
                for (int i = 0; i < _array.Length; i++)
                {
                    if (_array[i] == index)
                    {
                        _array[i] = value;
                    }
                }
            }
        }

        //Task 14
        public void reverse14()
        {
            int[] newArray = new int[(int)(_array.Length)];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[_array.Length - 1 - i] = _array[i];
            }

            _array = newArray;
        }

        //Task 15-17
        public void searchForTheMaximum15_17()
        {
            _indexSearch = 0;
            int max = _array[0];
            for (int i = 0; i < _array.Length; i++)
            {
                if (max < _array[i])
                {
                    max = _array[i];
                    _indexSearch = i;
                }
            }
        }

        //Task 16-18
        public void searchForMinimum16_18()
        {
            _indexSearch = 0;
            int min = _array[0];
            for (int i = 0; i < _array.Length; i++)
            {
                if (min > _array[i])
                {
                    min = _array[i];
                    _indexSearch = i;
                }
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
