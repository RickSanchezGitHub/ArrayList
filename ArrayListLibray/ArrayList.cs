using System;

namespace Core
{
    public class ArrayList
    {
        private int[] _array;
        private int _trueLength;
        public int Length { get; private set; }

        public ArrayList(int[] array)
        {
            if(array.Length < 10)
            {
                _trueLength = 10;
            }
            else
            {
             _trueLength = array.Length * 3 / 2;
            }
            _array = new int[_trueLength];
            Length = 0;
            AddLast(array);
        }

        public ArrayList()
        {
            _trueLength = 10;
            _array = new int[_trueLength];
            Length = 0;
        }

        public ArrayList(int element)
        {
            _trueLength = 10;
            _array = new int[_trueLength];
            Length = 0;
        }

        private void AddLast(int[] array)
        {
            if (!CheckLength(array.Length - 1))
            {
                ChangeSizeArray();
            }
            for (int i = 0; i <= array.Length-1; i++)
            {
                _array[Length + i] = array[i]; 
            }
            Length += array.Length ;
        }
        public void AddLast(ArrayList array)
        {
            int[] tmpArray = array.ToArray();
            if (!CheckLength(array.Length - 1))
            {
                ChangeSizeArray();
            }
            for (int i = 0; i <= array.Length - 1; i++)
            {
                _array[Length + i] = tmpArray[i];
            }
            Length += array.Length;
        }

        public void AddLast(int element)
        {
            if (!CheckLength(1))
            {
                ChangeSizeArray();
            }
            _array[Length] = element;
            Length++;
        }
        public void AddFirst(int element)
        {
            if (!CheckLength(1))
            {
                ChangeSizeArray();
            }
            int[] tmpArray = new int[Length];
            Array.Copy(_array, 0, tmpArray, 0, Length);
            _array[0] = element;
            Array.Copy(tmpArray, 0, _array, 1, Length);
            Length++;
        }
        public void AddFirst(ArrayList array)
        {
            if (!CheckLength(array.Length))
            {
                ChangeSizeArray();
            }
            int[] tmpArray = array.ToArray();
            int[] tArray = this.ToArray();
            _array = new int[_trueLength];
            Length = tmpArray.Length;
            Array.Copy(tmpArray, 0, _array, 0, Length);
            if (!CheckLength(tArray.Length))
            {
                ChangeSizeArray();
            }
            Array.Copy(tArray, 0, _array, Length, tArray.Length);
            Length += tArray.Length;
        }
        public void AddAt(int idx, int element)
        {
            if (!CheckLength(1))
            {
                ChangeSizeArray();
            }
            int[] tmpArray = new int[Length];
            Array.Copy(_array, idx, tmpArray, 0, Length - idx);
            _array[idx] = element;
            Array.Copy(tmpArray, 0, _array, idx + 1, Length - idx);
            Length++;
        }
        public void AddAt(int idx, ArrayList array)
        {
            int[] arrayUser = array.ToArray();
            if (!CheckLength(array.Length))
            {
                ChangeSizeArray();
            }
            int[] tmpArray = new int[Length];
            Array.Copy(_array, idx, tmpArray, 0, Length - idx);
            int k = 0;
            for (int i = idx; i < array.Length + idx; i++)
            {
                _array[i] = arrayUser[k];
                k++;
            }
            Array.Copy(tmpArray, 0, _array, idx + array.Length, Length - idx);
            Length+=array.Length;
        }
        public void RemoveFirst()
        {
            for (int i = 0; i < Length; i++)
            {
                _array[i] = _array[i + 1];
            }
            Length--;
        }
        public int RemoveFirst(int value)
        {
            for (int k = 0; k < Length; k++)
            {
                if(_array[k] == value)
                {
                    for (int i = k; i < Length; i++)
                    {
                        _array[i] = _array[i + 1];
                    }
                    Length--;
                    return k;
                }
            }
            return -1;
        }

        public void RemoveFirstMultiple(int n)
        {
            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < Length; i++)
                {
                    _array[i] = _array[i + 1];
                }
                Length--;
            }
        }
        public void RemoveLast()
        {
            _array[Length - 1] = _array[Length];
            Length--;
        }
        public void RemoveLastMultiple(int n)
        {
            for (int k = Length - 1; k < Length + n; k++)
            {
                _array[Length - 1] = _array[Length];
                Length--;
            }
        }
        public void RemoveAt(int idx)
        {
            for (int i = idx; i < Length; i++)
            {
                _array[i] = _array[i + 1];
            }
            Length--;
        }
        public void RemoveAtMultiple(int idx, int n)
        {
            for (int k = 0; k < n; k++)
            {
                for (int i = idx; i < Length; i++)
                {
                    _array[i] = _array[i + 1];
                }
                Length--;
            }
        }
        public int RemoveAll(int value)
        {
            int count = 0;
            for (int k = 0; k < Length; k++)
            {
                if (_array[k] == value)
                {
                    for (int i = k; i < Length; i++)
                    {
                        _array[i] = _array[i + 1];
                    }
                    Length--;
                    count++;
                    k--;
                }
            }
            return count;
        }
        public int Min()
        {
            int minArrayElement = _array[0];
            for (int index = 0; index < Length - 1; index++)
            {
                if (minArrayElement >= _array[index])
                {
                    minArrayElement = _array[index];
                }
            }
            return minArrayElement;
        }
        public int Max()
        {
            int maxArrayElement = _array[0];
            for (int index = 0; index < Length - 1; index++)
            {
                if (maxArrayElement <= _array[index])
                {
                    maxArrayElement = _array[index];
                }
            }
            return maxArrayElement;
        }
        public int IndexOfMin()
        {
            int minElement = _array[0];
            int indexMinElement = 0;
            for (int i = 0; i < Length - 1; i++)
            {
                if (minElement >= _array[i])
                {
                    minElement = _array[i];
                    indexMinElement = i;
                }
            }
            return indexMinElement;
        }
        public int IndexOfMax()
        {
            int maxElement = _array[0];
            int indexMaxElement = 0;
            for (int i = 0; i < Length - 1; i++)
            {
                if (maxElement <= _array[i])
                {
                    maxElement = _array[i];
                    indexMaxElement = i;
                }
            }
            return indexMaxElement;
        }
        public void Reverse()
        {
            for (int i = 0; i < (Length) / 2; i++)
            {
                int t = _array[i];
                _array[i] = _array[Length - (i + 1)];
                _array[Length - (i + 1)] = t;
            }
        }
        public int Get(int idx)
        {
            for (int i = 0; i < Length - 1; i++)
            {
                if(i == idx)
                {
                    return _array[i];
                }
            }
            return 0;
        }
        public int IndexOf(int val)
        {
            for (int i = 0; i < Length - 1; i++)
            {
                if (_array[i] == val)
                {
                    return i;
                }
            }
            return -1;
        }
        public int GetLast()
        {
            return _array[Length - 1];
        }
        public int GetFirst()
        {
            return _array[0];
        }
        public int GetLength()
        {
            return Length;
        }
        public void Write()
        {
            for (int i = 0; i <= Length - 1; i++)
            {
                Console.WriteLine(_array[i]);
            }
        }
        public void Sort()
        {
            for (int i = 0; i < Length - 1; i++)
            {
                 if (_array[i] > _array[i + 1])
                 {
                     int max = _array[i];
                     _array[i] = _array[i + 1];
                     _array[i + 1] = max;
                 }
            }
        }
        public void SortDesc()
        {
            int legthT = Length;
            int index = 0;
            for (int i = legthT -= 1; i >= 0; i--)
            {
                int min = _array[i];
                for (int k = legthT; k >= 0; k--)
                {
                    if (min >= _array[k])
                    {
                        min = _array[k];
                        index = k;
                    }
                }
                _array[index] = _array[i];
                _array[i] = min;
                legthT -= 1;
            }
        }
        public void Set(int idx, int val)
        {
            _array[idx] = val;
        }

        public bool Contains(int value)
        {
            for (int i = 0; i < Length; i++)
            {
                if(value == _array[i])
                {
                    return true;
                }
            }
            return false;
        }
        public int[] ToArray()
        {
            int[] array = new int[Length];
            Array.Copy(_array, 0, array, 0, Length);
            _array = new int[_trueLength];
            Array.Copy(array, 0, _array, 0, Length);
            return array;
        }

        private bool CheckLength(int lengthFromUser)
        {
            if(Length + lengthFromUser >= _trueLength)
            {
                return false;
            }
            return true;
        }
        private void ChangeSizeArray()
        {
            _trueLength = _trueLength * 3 / 2;

            int[] tmpArray = new int[Length];
            Array.Copy(_array, 0, tmpArray, 0, Length);
            _array = new int[_trueLength];
            Array.Copy(tmpArray, 0, _array, 0, Length);
        }

        public override bool Equals(object obj)
        {
            ArrayList arrayList = (ArrayList)obj;

            if (Length != arrayList.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < Length; i++)
                {
                    if (_array[i] != arrayList._array[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
