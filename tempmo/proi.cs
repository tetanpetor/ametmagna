using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlData = "<root><study_first_submitted>2024-06-22</study_first_submitted></root>";
        
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(xmlData);
        
        XmlNode node = doc.SelectSingleNode("/root/study_first_submitted");
        string firstSubmissionDate = node.InnerText;
        
        Console.WriteLine(firstSubmissionDate);  // Output: 2024-06-22
    }
}
