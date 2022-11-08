using System.Collections.Generic;
using System.Linq;
using CompositeDemo.FileSystem;

namespace CompositeDemo.Iterators
{
    public class FileSystemIterator : IIterator<FileSystemItem>
    {
        private readonly Queue<FileSystemItem> _items = new Queue<FileSystemItem>();

        public FileSystemIterator(FileSystemItem fileSystemItem)
        {
            _items.Enqueue(fileSystemItem);
        }

        public bool HasNext()
        {
            return _items.Any();
        }

        public FileSystemItem Next()
        {
            var current = _items.Dequeue();
            foreach (var item in current.GetItems())
                _items.Enqueue(item);
            return current;
        }
    }
}