using System;
using System.IO;
namespace ReadingFiles
{
    public class FileComponent
    {

        public virtual T ReadFile<T>(string file) where T: class {
            return File.ReadAllText(file) as T;
        }

        public void DisplayFileOutput(string fileContent){
            Console.WriteLine(fileContent);
        }
    }
}
