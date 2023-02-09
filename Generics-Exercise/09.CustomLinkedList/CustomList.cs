using System;

namespace CustomStructures;

public class CustomList<T>
    {
    private const int InitialCapacity = 2;

    private T[] items;

    public CustomList()
        {
        items = new T[InitialCapacity];
        }

    public int Count { get; private set; }

    public T this[int index]
        {
        get
            {
            ValidateIndex(index);

            return items[index];
            }
        set
            {
            ValidateIndex(index);

            items[index] = value;
            }
        }

    public void Add(T item)
        {
        if (items.Length == Count)
            {
            Resize();
            }

        items[Count] = item;

        Count++;
        }

    //Bonus
    public void AddRange(T[] items)
        {
        foreach (T item in items)
            {
            Add(item);
            }
        }

    public T RemoveAt(int index)
        {
        ValidateIndex(index);

        T removedItem = items[index];

        items[index] = default;

        ShiftLeft(index);

        Count--;

        if (Count <= items.Length / 4)
            {
            Shrink();
            }

        return removedItem;
        }

    public void InsertAt(int index, T item)
        {
        ValidateIndex(index);

        if (items.Length == Count)
            {
            Resize();
            }

        ShiftRight(index);

        items[index] = item;

        Count++;
        }
    public void Swap(int firstIndex, int secondIndex)
        {
        ValidateIndex(firstIndex);
        ValidateIndex(secondIndex);

        T temp = items[firstIndex];
        items[firstIndex] = items[secondIndex];
        items[secondIndex] = temp;
        }

    private void Resize()
        {
        T[] copy = new T[items.Length * 2];

        for (int i = 0; i < Count; i++)
            {
            copy[i] = items[i];
            }

        items = copy;
        }

    private void Shrink()
        {
        T[] copy = new T[items.Length / 2];

        for (int i = 0; i < Count; i++)
            {
            copy[i] = items[i];
            }

        items = copy;
        }

    private void ShiftLeft(int index)
        {
        for (int i = index; i < Count - 1; i++)
            {
            items[i] = items[i + 1];
            }
        }

    private void ShiftRight(int index)
        {
        for (int i = Count - 1; i >= index; i--)
            {
            items[i + 1] = items[i];
            }
        }

    private void ValidateIndex(int index)
        {
        if (index < 0 || index >= Count)
            {
            throw new IndexOutOfRangeException();
            }
        }
    }