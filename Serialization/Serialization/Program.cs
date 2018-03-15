using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
	[Serializable]
	class Program
	{
		static void Main(string[] args)
		{
			// an object to be serialized
			Book book = new Book();
			Console.WriteLine("Object was created");

			// sending class type to constructor
			XmlSerializer formatter = new XmlSerializer(typeof(Book));

			// get the stream to write serialized object in
			using (FileStream fs = new FileStream("books.xml", FileMode.OpenOrCreate))
			{
				formatter.Serialize(fs, book);

				Console.WriteLine("Object was serialized");
			}

			// deserialization
			using (FileStream fs = new FileStream("books.xml", FileMode.OpenOrCreate))
			{
				var newBook = (Book)formatter.Deserialize(fs);

				Console.WriteLine("Object was deserialized");
				Console.WriteLine("AuthName: {0} --- Title: {1}", newBook.Author, newBook.Title);
			}

			Console.ReadLine();
		}
	}
}
