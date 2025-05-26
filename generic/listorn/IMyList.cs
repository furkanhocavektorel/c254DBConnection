namespace generic.listorn
{
    internal interface IMyList<T>
    {
        void Add(T item);
        void Insert(int index, T item);
        void Remove(T item);



    }
}
