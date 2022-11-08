using System;
using System.Collections.Generic;
using CompositeDemo.Iterators;

namespace CompositeDemo.FileSystem
{
    public abstract class FileSystemItem //Component
    {
        private readonly string _name;
        public string Name => _name;
        public abstract long Size();

        public FileSystemItem(string name)
        {
            _name = name;
        }

        public override string ToString() => $"Name: {Name}, Size: {Size()}";

        //public abstract void Add(FileSystemItem item);
        public abstract IReadOnlyList<FileSystemItem> GetItems();

        public void ForEach(Action<FileSystemItem> action)
        {
            var iterator = new FileSystemIterator(this);
            while (iterator.HasNext())
            {
                var current = iterator.Next();
                action(current);
            }
        }
    }
}