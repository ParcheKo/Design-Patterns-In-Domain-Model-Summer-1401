using System.Collections.Generic;

namespace CompositeDemo.FileSystem
{
    public class File : FileSystemItem
    {
        private readonly long _size;

        public File(
            string name,
            long size
        ): base(name)
        {
            _size = size;
        }

        public override long Size()
        {
            return _size;
        }

        public override IReadOnlyList<FileSystemItem> GetItems()
        {
            return new List<FileSystemItem>();
        }
    }
}