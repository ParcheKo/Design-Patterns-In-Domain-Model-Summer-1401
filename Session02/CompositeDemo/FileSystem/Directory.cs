using System.Collections.Generic;
using System.Linq;

namespace CompositeDemo.FileSystem
{
    public class Directory : FileSystemItem
    {
        private readonly List<FileSystemItem> _children;

        public Directory(
            string name,
            params FileSystemItem[] children
        ): base(name)
        {
            _children = children.ToList();
        }

        public override long Size()
        {
            long sum = 0;
            foreach (var fileSystemItem in _children)
            {
                sum += fileSystemItem.Size();
            }

            return sum;
        }

        public override IReadOnlyList<FileSystemItem> GetItems()
        {
            return _children;
        }
    }
}