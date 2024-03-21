using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Document
    {
        private string title;
        private List<Paragraph> paragraphs=new List<Paragraph>();
        public Document(string title)
        {
            this.title = title;
        }
        public Document() { }
        public void AddParagraph(string content)
        {
            paragraphs.Add(new Paragraph(content));
        }
        public void PrintContent()
        {
            foreach (Paragraph paragraph in paragraphs)
            {
                paragraph.PrintContent();
            }
        }
    }
    public class Paragraph
    {
        private string content;
        public Paragraph(string content)
        {
            this.content= content;
        }
        public void PrintContent()
        {
            Console.WriteLine(this.content);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            document.AddParagraph("This is first paragraph!");
            document.AddParagraph("This is second paragraph!");
            document.PrintContent();
            Console.ReadKey();
        }
    }
}
