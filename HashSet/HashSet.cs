namespace HashSet;


public class HashSet<T>
{
    private List<T>[] _hashSet;
    private readonly int _size;

    public HashSet(int size)
    {
        _size = size;
        _hashSet = new List<T>[size];

        for (int i = 0; i < _size; i++) { _hashSet[i] = new List<T>(); }
    }



    public void Add(T item)
    {
        int index = item.GetHashCode() % _size;
        if (!_hashSet[index].Contains(item)) { _hashSet[index].Add(item); }
    }

    public bool IsPresent(T item)
    {
        int index = item.GetHashCode() % _size;
        return _hashSet[index].Contains(item);
    }

    public void Rebalance()
    {
        List<T>[] newHashSet = new List<T>[_size * 2];
        for (int i = 0; i < newHashSet.Length; i++) { newHashSet[i] = new List<T>(); }

        foreach (List<T> bucket in _hashSet)
        {
            foreach (T item in bucket)
            {
                int index = item.GetHashCode() % newHashSet.Length;
                if (!newHashSet[index].Contains(item)) { newHashSet[index].Add(item); }
            }
        }
        _hashSet = newHashSet;
    }


}