namespace CSharpForDummies
{
    public class Storage<T>
        where T : class
    {
        private uint m_currentIndex = 0;
        private T[] m_array = null;
        private bool[] m_indexer = null;

        public Storage(uint size = 1)
        {
            this.m_array = new T[size];
            this.m_indexer = new bool[size];
        }

        public uint Add(T element)
        {
            uint startIndex = this.m_currentIndex;
            while (this.m_indexer[this.m_currentIndex++ % this.m_array.Length])
            {
                if (this.m_currentIndex == startIndex)
                {
                    uint nextStartIndex = (uint)this.m_array.Length;
                    this.ExpandArray();
                    this.m_currentIndex = nextStartIndex;
                }
            }

            this.m_indexer[this.m_currentIndex % this.m_array.Length] = true;
            this.m_array[this.m_currentIndex % this.m_array.Length] = element;
            return this.m_currentIndex;
        }

        public bool RemoveAt(uint index)
        {
            if (index < this.m_array.Length)
            {
                m_indexer[index] = false;
            }
            return false;
        }

        private void ExpandArray()
        {
            T[] array = m_array;
            m_array = new T[m_array.Length * 2];

            bool[] indexArray = m_indexer;
            m_indexer = new bool[m_array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                m_array[i] = array[i];
                m_indexer[i] = indexArray[i];
            }
        }
    }
}
