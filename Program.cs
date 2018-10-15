using System;
using System.IO;

namespace ReadingFiles
{
    class Program {
        static void Main(string[] args)
        {

            //var textFile = new TextFileBase();
            //var contentTextFile = textFile.ReadFile<string>("hallo.txt");
            //textFile.DisplayFileOutput(contentTextFile);

            var jsonFile = new JSONFileBase();
            var contentJsonFile = jsonFile.ReadFile<string>("hallo.json");
            jsonFile.DisplayFileOutput(contentJsonFile);
        }
    }
}
