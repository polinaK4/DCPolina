namespace Task9_Generics
{
    class DataStore<T> where T : Human
    {
        public T[] array;
        public DataStore(int size)
        {
            array = new T[size + 1];
        }
        public void Add(int index, T value)
        {
            array[index] = value;
            Console.Write($"New item {array[index].firstName} {array[index].lastName} ({typeof(T).Name}) is added \n");
        }

        public void Remove(int index)
        {
            T[] newData = new T[array.Length - 1];
            int c = 0;
            if (index >= 0 && index < newData.Length)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i != index)
                    {
                        newData[c] = array[i];
                        c++;
                    }
                }
                Console.WriteLine("Item was removed");
            }
            else
            {
                Console.WriteLine("Try another index");
            }            
        }

        public string GetItem(int index)
        {
            return $"{array[index].firstName} {array[index].lastName}";
        }

        public int Length()
        {
            return array.Length;
        }

        public string ToString()
        {
            if (typeof(T).Name is "Woman")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != null)
                    {
                        Console.WriteLine($"{array[i].firstName} {array[i].lastName}");
                    }
                }
                    return $"There’re only women";
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != null)
                    {
                        Console.WriteLine($"{array[i].firstName} {array[i].lastName}");
                    }
                }
                return $"There’re only men";
            }
        }

    }
}
