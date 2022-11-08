using System;
using System.Text;
using CompositeDemo.FileSystem;
using Xunit;

namespace CompositeDemo.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var root = CreateSampleDirectory();

            Assert.Equal(60, root.Size());
        }

        [Fact]
        public void PrintDirectoryInnerFileAndDirectoriesRecursively()
        {
            var output = new StringBuilder();
            var root = CreateSampleDirectory();
            root.ForEach(fs => output.AppendLine($"{fs}"));
            var text = output.ToString();
        }

        private static Directory CreateSampleDirectory()
        {
            var file1 = new File("F1", 10);
            var file2 = new File("F2", 20);
            var file3 = new File("F3", 30);
            var directory1 = new Directory("D1" ,file1, file2);
            var root = new Directory("D2", directory1, file3);
            return root;
        }
    }
}