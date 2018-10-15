using System;
using System.Runtime.CompilerServices;
using System.IO;
using Newtonsoft.Json;
namespace ReadingFiles
{
    public class JSONFileBase : FileComponent
    {
        public override T ReadFile<T>(string file)
        {
            string jsonObject = base.ReadFile<string>(file);
            var content = JsonConvert.DeserializeObject(jsonObject);
            return content as T;
        }
    }
}
