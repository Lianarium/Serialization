using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
	public enum GenreType
	{
		[XmlEnum(Name = "Science Fiction")] ScienceFiction,
		[XmlEnum] Romance,
		[XmlEnum] Fantasy,
		[XmlEnum] Computer,
		[XmlEnum] Horror
	}
}
