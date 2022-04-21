using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinExplorer
{
  public class FileInfoController
  {
    public static List<FileInfoViewModel> GetFileInfos(DirectoryInfo dirInfo)
    {
      var allFiles = dirInfo.GetFiles();
      
      var lst = new List<FileInfoViewModel>();
      foreach (var fi in allFiles)
      {
        var x = new FileInfoViewModel(fi);
        lst.Add(x);
      }

      return lst;
    }
  }
}
