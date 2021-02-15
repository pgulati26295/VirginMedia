using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using VirginMedia.Data.Interfaces;
using Model = VirginMedia.Data.Model;

namespace VirginMedia.Data.Implementations
{
    public class XMLFile : IFile
    {
        private readonly string path; 
        public XMLFile(IConfiguration configuration)
        {
            path = configuration.GetValue<string>("DataFile");
        }
        public async Task<Model.Data> LoadObjectFromFile()
        {
             XmlSerializer deserializer = new XmlSerializer(typeof(Model.Data));

            using (XmlReader reader = XmlReader.Create(path))
            {
              return deserializer.Deserialize(reader) as Model.Data;
            }
        }
    }
}
