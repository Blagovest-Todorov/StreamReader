using System;
using System.IO;
using System.Threading.Tasks;



namespace StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader ---we read from a file
            //The StreamReeaderClass
            //StreamReaderClass implements methods for reading text lines and sequence of characters
            //works like Console.Read(), Cosnsole.ReadLine(); but over txt files
            //stream is like a small river of date packets , but is working over files;

            StreamReader reader = new StreamReader("test.txt");
            string fileContents = reader.ReadToEnd();
            Console.WriteLine(fileContents);
            StreamReader.Close();

            
        }
    }
}
