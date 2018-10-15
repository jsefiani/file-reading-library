using System;
using System.Runtime.CompilerServices;
using System.IO;
namespace ReadingFiles
{
    public class TextFileBase : FileComponent
    {
        public TextFileBase()
        {

        }

        public override T ReadFile<T>(string file)
        {
            return base.ReadFile<T>(file);
        }

    }
}

