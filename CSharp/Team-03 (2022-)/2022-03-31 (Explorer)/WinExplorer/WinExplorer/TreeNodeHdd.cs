using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinExplorer
{
  public class TreeNodeDirInfo : TreeNode
  {
    protected void AddDirectories(DirectoryInfo dirInfo)
    {
      try
      {
        this.Nodes.Clear();
        var subDirInfos = dirInfo.GetDirectories();

        foreach (var subDir in subDirInfos)
        {
          var txt = $"{subDir.Name}";
          var childNode = new TreeNode(txt, 2, 3);
          childNode.Tag = subDir;

          this.Nodes.Add(childNode);
        }
      }
      catch (Exception ioEx)
      {
      }
    }
  }

  public class TreeNodeHdd : TreeNodeDirInfo
  {
    public TreeNodeHdd(DriveInfo driveInfo) : base()
    {
      this.Tag = driveInfo;

      this.Text = $"{driveInfo.Name}";
      this.ImageIndex = 1;
      this.SelectedImageIndex = 1;

      this.AddDirectories(driveInfo.RootDirectory);
    }
  }


  public class TreeNodeDir : TreeNodeDirInfo
  {
    public TreeNodeDir(DirectoryInfo dirInfo) : base()
    {
      this.Tag = dirInfo;

      this.Text = $"{dirInfo.Name}";
      this.ImageIndex = 2;
      this.SelectedImageIndex = 3;

      this.AddDirectories(dirInfo);
    }

  }

}
