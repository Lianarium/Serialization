using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
	[Serializable, XmlType(TypeName = "book")]
	public class Book
	{
		private DateTime publishDate, registrationDate; 

		[XmlAttribute("id")]
		public string Id { get; set; }

		[XmlElement("isbn")]
		public string Isbn { get; set; }

		[XmlElement("author")]
		public string Author { get; set; }

		[XmlElement("title")]
		public string Title { get; set; }

		[XmlElement("genre")]
		public GenreType Genre { get; set; }//must be enum

		[XmlElement("publisher")]
		public string Publisher { get; set; }

		[XmlElement("publish_date")]
		public DateTime PublishDate
		{
			get
			{
				return publishDate.Date;
			}
			set { publishDate = value; }
		}


		[XmlElement("registration_date")]
		public DateTime RegistrationDate
		{
			get
			{
				return registrationDate.Date;
			}
			set { registrationDate = value; }
		}


		[XmlElement("description")]
		public string Description { get; set; }

		public Book()
		{

		}

		public override string ToString()
		{
			return $"Book:{Title},  Author {Author}\n" +  $"{Genre}. {Description}" +  $"{PublishDate}, {Publisher}\n";
		}

		 
	}
}
