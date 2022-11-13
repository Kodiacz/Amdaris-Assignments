namespace ArraysAndGenericAsignment
{
    public class ArrayList<T>
    {
        T[] array;

        public ArrayList()
        {
            array = new T[4];
        }


        public ArrayList(params T[] values)
        {
            array = new T[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                array[i] = values[i];
            }
        }
        public T[] Array => this.array;

        public int Length => this.array.Length;

        public T GetItemAtIndex(int index) 
        {
            return array[index];
        }

        public void SetItemAtIndex(T item, int index)
        {
            T[] newArray = new T[this.Length + 1];
            int oldArrayIndex = 0;

            for (int i = 0; i < newArray.Length; i++)
            {
                if (i == index)
                {
                    newArray[i] = item;
                    i++;
                }

                newArray[i] = this.array[oldArrayIndex++];
            }

            this.array = newArray;
        }

        public void SwapItems(int firstIndex, int secondIndex)
        {
            T tempItem = this.array[firstIndex];
            this.array[firstIndex] = this.array[secondIndex];
            this.array[secondIndex] = tempItem;
        }

        public void SwapItems(T firstItem, T secondItem)
        {
            int indexOfFirstItem = 0;
            int indexOfSecondItem = 0;

            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i].Equals(firstItem))
                {
                    indexOfFirstItem = i;
                }

                if (this.array[i].Equals(secondItem))
                {
                    indexOfSecondItem = i;
                }
            }

            T tempItem = this.array[indexOfFirstItem];
            this.array[indexOfFirstItem] = this.array[indexOfSecondItem];
            this.array[indexOfSecondItem] = tempItem;
        }
    }
}
