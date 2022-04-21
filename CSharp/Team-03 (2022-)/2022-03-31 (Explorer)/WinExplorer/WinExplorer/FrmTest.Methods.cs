using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinExplorer
{
  public partial class FrmTest
  {

    private void AddDrives()
    {
      var allDrives = DriveInfo.GetDrives();
      // 0,0 = Images
      var ndRoot = new TreeNode("PC", 0, 0);

      foreach (var drive in allDrives)
      {
        var txt = $"{drive.Name}";
        Debug.WriteLine(txt);

        var ndDrive = new TreeNode(txt, 1, 1);
        ndDrive.Tag = drive;
        //ndDrive.ForeColor = Color.Green;
        if (drive.IsReady)
        {
          ndDrive.ToolTipText = $"{drive.DriveType}, {drive.DriveFormat}";
        }
        ndRoot.Nodes.Add(ndDrive);

        this.AddDirectories(ndDrive, drive.RootDirectory);
        //var ndDrive = new TreeNodeHdd(drive);
      }

      trvTest.Nodes.Clear();
      trvTest.Nodes.Add(ndRoot);
    }


    private void AddDirectories(TreeNode parentNode, DirectoryInfo dirInfo)
    {
      try
      {
        parentNode.Nodes.Clear();
        var subDirInfos = dirInfo.GetDirectories();

        foreach (var subDir in subDirInfos)
        {
          var txt = $"{subDir.Name}";
          var childNode = new TreeNode(txt, 2, 3);
          childNode.Tag = subDir;

          parentNode.Nodes.Add(childNode);
        }
      }
      catch (Exception ioEx)
      {
      }
    }


    private void AddDirectories(TreeNode node2Expand)
    {
      if (node2Expand.Tag == null)
        return;

      var allChildNodes = node2Expand.Nodes;
      foreach (TreeNode node in allChildNodes)
      {
        var dirInfo = node.Tag as DirectoryInfo;
        if (dirInfo != null)
        {
          //Debug.WriteLine($"{node.Text} => {dirInfo.FullName}");
          this.AddDirectories(node, dirInfo);
        }
      }
    }


    private void AddFiles(DirectoryInfo dirInfo, bool includeDirs)
    {
      lvwTest.Items.Clear();

      if (dirInfo == null)
        return;

      try
      {
        if (includeDirs)
        {
          var allDirectories = dirInfo.GetDirectories();
          foreach (var dir in allDirectories)
          {
            var item = lvwTest.Items.Add(dir.FullName, dir.Name, 2);
            item.Tag = dir;
          }
        }

        var allFiles = dirInfo.GetFiles();

        if (lvwTest.Visible)
        {
          foreach (var fileInfo in allFiles)
          {
            var item = lvwTest.Items.Add(fileInfo.FullName, fileInfo.Name, "File");

            var key = this.GetSystemIconKey(fileInfo);
            item.ImageKey = key;
            item.Tag = fileInfo;
            item.SubItems.Add($"{fileInfo.Length:N0}");
          }
        }

        ////Icon.ExtractAssociatedIcon(FileInfo.FullName);
        //var lst = new List<FileInfoWrapper>();
        //foreach (var fi in allFiles)
        //{
        //  var x = new FileInfoWrapper(fi);
        //  lst.Add(x);
        //}

        var lst = FileInfoController.GetFileInfos(dirInfo);

        dgvColName.DataPropertyName = nameof(FileInfoViewModel.Name);
        dgvColIcon.DataPropertyName = nameof(FileInfoViewModel.Icon);
        dgvColLength.DataPropertyName = nameof(FileInfoViewModel.Length);

        dgvFiles.AutoGenerateColumns = false;
        dgvFiles.DataSource = lst;

      }
      catch (Exception)
      {
      }

    }


    private string GetSystemIconKey(FileInfo fileInfo)
    {
      var ext = fileInfo.Extension;
      if (imgTest.Images.ContainsKey(ext))
      {
        return ext;
      }
      else
      {
        using (var icon = Icon.ExtractAssociatedIcon(fileInfo.FullName))
        {
          imgTest.Images.Add(ext, icon);
        }
        return ext;
      }
    }


    private void StartProcess()
    {
      try
      {
        var item = lvwTest.SelectedItems.OfType<ListViewItem>().FirstOrDefault();
        if (item == null)
          return;

        var fileInfo = item.Tag as FileInfo;
        if (fileInfo == null)
          return;

        Process.Start(fileInfo.FullName);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }


  }


  public class FileInfoViewModel
  {
    private FileInfo _fileInfo;
    private Icon _icon;

    public FileInfoViewModel(FileInfo fi) : base()
    {
      _fileInfo = fi;
    }

    public string Name { get { return _fileInfo.Name; } }
    public long Length { get { return _fileInfo.Length; } }

    public Icon Icon
    {
      get
      {
        if ( _icon == null )
          _icon = Icon.ExtractAssociatedIcon(_fileInfo.FullName);
        return _icon;
      }
    }

    //public FileInfo this[]
    //{
    //}
  }


}
