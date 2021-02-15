using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Model = VirginMedia.Data.Model;

namespace VirginMedia.Data.Interfaces
{
  public  interface IFile
    {
        Task<Model.Data> LoadObjectFromFile();
    }
}
