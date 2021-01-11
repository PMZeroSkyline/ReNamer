using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Drawing.Imaging;
using System.Drawing;
using System.Text.RegularExpressions;

namespace VideoDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        #region 变量
        string[] filesPath = new string[] { };
        string[] filesPath_T = new string[] { };
        string[] newFilesPath = new string[] { };
        int starRenameIndex = 0;
        #endregion
        #region 初始化
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion
        #region 文件拖拽
        private void My_ListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop,false))
            {
                e.Effects = DragDropEffects.All;
            }
        }

        private void My_ListBox_Drop(object sender, DragEventArgs e)
        {
            newFilesPath = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var newFile in newFilesPath)
            {
                if (filesPath.Contains(newFile))
                {
                }
                else
                {
                    if (File.Exists(newFile))
                    {
                        filesPath=AddToArray(newFile,filesPath);
                        UpdateListBox();
                        My_PsText.Text = "";
                    }
                    else
                    {
                    }
                }
            }
        }
        #endregion
        #region 文件命名面板功能
        private void UpdateListBox()
        {
            My_ListBox.Items.Clear();
            foreach (var flie in filesPath)
            {
                string fileName = System.IO.Path.GetFileName(flie);
                My_ListBox.Items.Add(fileName);
            }
        }

        private string[] AddToArray(string newFile,string[] filesPath)
        {
            List<String> list = new List<String>(filesPath);
            list.Add(newFile);
            filesPath = list.ToArray();
            return filesPath;
        }

        private void ReplaceButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (filesPath.Length>0)
            {
                ReplaceFiles(My_oldText.Text, My_newText.Text);
            }
            else
            {
                MessageBox.Show("请先拖入文件");
            }
        }

        private void ReplaceFiles(string oldName,string newName)
        {
            foreach (var oldFilePath in filesPath)
            {
                if (oldName=="")
                {
                }
                else
                {
                    string oldFileFolder = System.IO.Path.GetDirectoryName(oldFilePath);
                    string oldFileExt = System.IO.Path.GetExtension(oldFilePath);
                    string oldFileName = System.IO.Path.GetFileNameWithoutExtension(oldFilePath);
                    string newFileName = "";
                    if (My_C_Regex.IsChecked == true)
                    {
                        try
                        {
                            newFileName = Regex.Replace(oldFileName, @My_oldText.Text, My_newText.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("前检查输入的正则表达式是否正确，否则请消勾“使用正则表达式”选框");
                        }
                    }
                    else
                    {
                        newFileName = oldFileName.Replace(oldName, newName);
                    }
                    string newFilePath = oldFileFolder + @"\" + newFileName + oldFileExt;
                    File.Move(oldFilePath, newFilePath);
                }
            }
            
            IniMyData();
        }

        private void RenameButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (filesPath.Length > 0)
            {
                ReNameFiles();
            }
            else
            {
                MessageBox.Show("请先拖入文件");
            }
        }

        private void ReNameFiles()
        {
            try
            {
                starRenameIndex =int.Parse(My_R_StarIndex.Text);
                foreach (var filePath in filesPath)
                {
                    if (My_RenameText.Text == "")
                    {
                    }
                    else
                    {
                        string oldFileFolder = System.IO.Path.GetDirectoryName(filePath);
                        string oldFileExt = System.IO.Path.GetExtension(filePath);
                        string oldFileName = System.IO.Path.GetFileNameWithoutExtension(filePath);
                        string newFileName = My_RenameText.Text + starRenameIndex.ToString();
                        string newFilePath = oldFileFolder + @"\" + newFileName + oldFileExt;
                        try
                        {
                            File.Move(filePath, newFilePath);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("请检查新旧命名是否重复");
                        }
                        starRenameIndex++;
                    }
                }
                IniMyData();
            }
            catch (Exception)
            {
                MessageBox.Show("序号起点只能是数字");
            }

        }

        private void AddStringButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (filesPath.Length > 0)
            {
                AddCharToFile();
            }
            else
            {
                MessageBox.Show("请先拖入文件");
            }    
        }

        private void AddCharToFile()
        {
            foreach (var filePath in filesPath)
            {
                if (My_AddText.Text == "")
                {
                }
                else
                {
                    if (My_CheckBox.IsChecked == true)
                    {
                        string oldFileFolder = System.IO.Path.GetDirectoryName(filePath);
                        string oldFileExt = System.IO.Path.GetExtension(filePath);
                        string oldFileName = System.IO.Path.GetFileNameWithoutExtension(filePath);
                        string newFileName = oldFileName + My_AddText.Text;
                        string newFilePath = oldFileFolder + @"\" + newFileName + oldFileExt;
                        File.Move(filePath, newFilePath);
                    }
                    else
                    {
                        string oldFileFolder = System.IO.Path.GetDirectoryName(filePath);
                        string oldFileExt = System.IO.Path.GetExtension(filePath);
                        string oldFileName = System.IO.Path.GetFileNameWithoutExtension(filePath);
                        string newFileName = My_AddText.Text + oldFileName;
                        string newFilePath = oldFileFolder + @"\" + newFileName + oldFileExt;
                        File.Move(filePath, newFilePath);
                    }

                }
            }
            IniMyData();
        }

        private void IniMyData()
        {
            filesPath = new string[] { };
            UpdateListBox();
            MessageBox.Show("已完成");
            My_PsText.Text = "拖拽文件进入窗口";
            My_AddText.Text = "";
            My_newText.Text = "";
            My_oldText.Text = "";
            My_RenameText.Text = "";
            My_R_StarIndex.Text = "0";
            starRenameIndex = 0;
        }
        #endregion
    }
}
