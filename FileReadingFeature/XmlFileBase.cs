using System;
using System.IO;
using System.Xml;
namespace ReadingFiles
{
    public class XmlFileBase : FileComponent
    {
        //public override void ReadFile(string file)
        //{
        //    base.ReadFile(file);
        //    XmlTextReader reader = new XmlTextReader(file);
        //    while (reader.Read())
        //    {
        //        switch (reader.NodeType)
        //        {
        //            case XmlNodeType.Element: // The node is an element.
        //                Console.Write("<" + reader.Name);
        //                Console.WriteLine(">");
        //                break;
        //            case XmlNodeType.Text: //Display the text in each element.
        //                Console.WriteLine(reader.Value);
        //                break;
        //            case XmlNodeType.EndElement: //Display the end of the element.
        //                Console.Write("</" + reader.Name);
        //                Console.WriteLine(">");
        //                break;
        //        }
        //    }
        //}
    }
}
