﻿namespace CompositeDemo.Iterators
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}