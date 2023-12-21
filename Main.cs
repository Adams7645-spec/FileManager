using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace FileManager
{
    public partial class Main : Form
    {
        //textBox_DirrectoryPathRight
        string CurrentPathLeftView { get; set; }
        string CurrentPathRightView { get; set; }
        int CurrentIndexLeftView { get; set; }
        int CurrentIndexRightView { get; set; }
        public Main()
        {
            InitializeComponent();
            LoadApp();
        }

        private void LoadApp()
        {
            LoadDrives();
            CurrentPathLeftView = comboBox_Left_Drives.SelectedItem.ToString();
            CurrentPathRightView = comboBox_Right_Drives.SelectedItem.ToString();
            LoadFilesAndFolders(CurrentPathLeftView, listView_left, textBox_DirrectoryPathLeft);
            LoadFilesAndFolders(CurrentPathRightView, listView_right, textBox_DirrectoryPathRight);
        }
        private void PathTextboxUpdate(TextBox textBox, string path)
        {
            textBox.Text = path;
        }
        private void LoadDrives()
        {
            var drives = DriveInfo.GetDrives();
            foreach (var item in drives)
            {
                comboBox_Left_Drives.Items.Add(item.ToString());
                comboBox_Right_Drives.Items.Add(item.ToString());
            }
            comboBox_Left_Drives.SelectedIndex = 0;
            comboBox_Right_Drives.SelectedIndex = 0;
        }
        private void LoadFilesAndFolders(string path, ListView view, TextBox textBox)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            view.Items.Clear();

            foreach (var item in directoryInfo.GetDirectories())
            {
                ListViewItem listViewItem = new ListViewItem(item.Name);
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add("Папка");
                listViewItem.SubItems.Add(item.CreationTime.ToString());
                listViewItem.SubItems.Add(item.LastWriteTime.ToString());
                view.Items.Add(listViewItem);
            }

            foreach (var item in directoryInfo.GetFiles())
            {
                ListViewItem listViewItem = new ListViewItem(item.Name);
                listViewItem.SubItems.Add(item.Length.ToString());
                listViewItem.SubItems.Add("Файл");
                listViewItem.SubItems.Add(item.CreationTime.ToString());
                listViewItem.SubItems.Add(item.LastWriteTime.ToString());
                view.Items.Add(listViewItem);
            }
            PathTextboxUpdate(textBox, path);
        }
        private void UpdateListviews()
        {
            LoadFilesAndFolders(CurrentPathLeftView, listView_left, textBox_DirrectoryPathLeft);
            LoadFilesAndFolders(CurrentPathRightView, listView_right, textBox_DirrectoryPathRight);
        }
        private void listView_Left_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selectedView = sender as ListView;

            selectedView.Focus();
            CurrentPathLeftView = Path.Combine(textBox_DirrectoryPathLeft.Text, listView_left.SelectedItems[0].Text);

            LoadFilesAndFolders(CurrentPathLeftView, listView_left, textBox_DirrectoryPathLeft);
        }
        private void listView_Left_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            CurrentIndexLeftView = e.ItemIndex;
        }
        private void listView_Right_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selectedView = sender as ListView;

            selectedView.Focus();
            CurrentPathRightView = Path.Combine(textBox_DirrectoryPathRight.Text, listView_right.SelectedItems[0].Text);

            LoadFilesAndFolders(CurrentPathRightView, listView_right, textBox_DirrectoryPathRight);
        }
        private void listView_Right_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            CurrentIndexRightView = e.ItemIndex;
        }
        private void left_button_Back_Click(object sender, EventArgs e)
        {
            buttonBackClick(listView_left, textBox_DirrectoryPathLeft, CurrentPathLeftView);
        }
        private void right_button_Back_Click(object sender, EventArgs e)
        {
            buttonBackClick(listView_right, textBox_DirrectoryPathRight, CurrentPathRightView);
        }
        private void buttonBackClick(ListView listView, TextBox textBox, string path)
        {
            try
            {
                DirectoryInfo tempParent = Directory.GetParent(path);
                var parentExists = tempParent != null;
                if (parentExists)
                {
                    path = tempParent.FullName;
                    LoadFilesAndFolders(path, listView, textBox);
                }
            }
            catch
            {
                return;
            }
        }
        private void comboBox_Left_Drives_SelectedIndexChanged(object sender, EventArgs e)
        {
            var box = (ComboBox)sender;
            CurrentPathLeftView = box.SelectedItem.ToString();
            LoadFilesAndFolders(CurrentPathLeftView, listView_left, textBox_DirrectoryPathLeft);
        }
        private void comboBox_Right_Drives_SelectedIndexChanged(object sender, EventArgs e)
        {
            var box = (ComboBox)sender;
            CurrentPathRightView = box.SelectedItem.ToString();
            LoadFilesAndFolders(CurrentPathRightView, listView_right, textBox_DirrectoryPathRight);
        }
        private void listView_left_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenu = new ContextMenuStrip();

                contextMenu.Items.Add("Переименовать", null, RenameMenuItemLeft_Click);
                contextMenu.Items.Add("Удалить", null, OptionDeleteLeftView_Click);
                contextMenu.Items.Add("Копировать", null, OptionCopyToLeftView_Click);
                contextMenu.Items.Add("Переместить", null, OptionMoveOnPathLeftView_Click);
                contextMenu.Items.Add("Добавить в архив", null, OptionArchiveLeftView_Click);

                contextMenu.Show(listView_left, e.Location);
            }
        }
        private void listView_right_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenu = new ContextMenuStrip();

                contextMenu.Items.Add("Переименовать", null, RenameMenuItemRight_Click);
                contextMenu.Items.Add("Удалить", null, OptionDeleteRightView_Click);
                contextMenu.Items.Add("Копировать", null, OptionCopyToRightView_Click);
                contextMenu.Items.Add("Переместить", null, OptionMoveOnPathRightView_Click);
                contextMenu.Items.Add("Добавить в архив", null, OptionArchiveRightView_Click);

                contextMenu.Show(listView_right, e.Location);
            }
        }
        private void OptionArchiveLeftView_Click(object sender, EventArgs e)
        {
            ArchiveData(CurrentPathLeftView, CurrentPathRightView);
        }
        private void OptionArchiveRightView_Click(object sender, EventArgs e)
        {
            ArchiveData(CurrentPathRightView, CurrentPathLeftView);
        }
        private void ArchiveData(string sourceDirectory, string destinationFile)
        {
            using (FileStream compressedFileStream = File.Create(destinationFile + $"\\New compessed.gz"))
            {
                using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                {
                    DirectoryInfo di = new DirectoryInfo(sourceDirectory);
                    foreach (var file in di.GetFiles())
                    {
                        using (FileStream fileToCompress = File.OpenRead(file.FullName))
                        {
                            fileToCompress.CopyTo(compressionStream);
                        }
                    }
                }
            }
        }
        private void RenameMenuItemLeft_Click(object sender, EventArgs e)
        {
            if (listView_left.SelectedItems.Count == 1)
            {
                listView_left.LabelEdit = true;
                listView_left.SelectedItems[0].BeginEdit();
            }
        }
        private void RenameMenuItemRight_Click(object sender, EventArgs e)
        {
            if (listView_right.SelectedItems.Count == 1)
            {
                listView_left.LabelEdit = true;
                listView_right.SelectedItems[0].BeginEdit();
            }
        }
        private void OptionDeleteRightView_Click(object sender, EventArgs e)
        {
            DeleteOnPath(listView_right, textBox_DirrectoryPathRight);
            UpdateListviews();
        }
        private void OptionCopyToRightView_Click(object sender, EventArgs e)
        {
            CopyToPath(listView_right, textBox_DirrectoryPathRight, textBox_DirrectoryPathLeft);
            UpdateListviews();
        }
        private void OptionMoveOnPathRightView_Click(object sender, EventArgs e)
        {
            MoveOnPath(listView_right, textBox_DirrectoryPathRight, textBox_DirrectoryPathLeft);
            UpdateListviews();
        }
        private void OptionDeleteLeftView_Click(object sender, EventArgs e)
        {
            DeleteOnPath(listView_left, textBox_DirrectoryPathLeft);
            UpdateListviews();
        }
        private void OptionCopyToLeftView_Click(object sender, EventArgs e)
        {
            CopyToPath(listView_left, textBox_DirrectoryPathLeft, textBox_DirrectoryPathRight);
            UpdateListviews();
        }
        private void OptionMoveOnPathLeftView_Click(object sender, EventArgs e)
        {
            MoveOnPath(listView_left, textBox_DirrectoryPathLeft, textBox_DirrectoryPathRight);
            UpdateListviews();
        }
        private void MoveOnPath(ListView listView, TextBox CopyFromTB, TextBox CopyToTB)
        {
            var selectedReplaceFromPath = Path.Combine(CopyFromTB.Text, listView.SelectedItems[0].Text);
            var selectedReplaceToPath = Path.Combine(CopyToTB.Text, listView.SelectedItems[0].Text);

            if (File.Exists(selectedReplaceFromPath))
            {
                File.Move(selectedReplaceFromPath, selectedReplaceToPath);
            }
            else if (Directory.Exists(selectedReplaceToPath))
            {
                Directory.Move(selectedReplaceFromPath, selectedReplaceToPath);
            }
        }
        private void DeleteOnPath(ListView listView, TextBox textBox)
        {
            var selectedPath = Path.Combine(textBox.Text, listView.SelectedItems[0].Text);
            if (File.Exists(selectedPath))
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить файл?", "Подтверждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    File.Delete(selectedPath);
                    listView.Items.Remove(listView.SelectedItems[0]);
                }
            }
            else if (Directory.Exists(selectedPath))
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить директорию?", "Подтверждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Directory.Delete(selectedPath, true);
                    listView.Items.Remove(listView.SelectedItems[0]);
                }
            }
        }
        private void CopyToPath(ListView listView, TextBox CopyFromTB, TextBox CopyToTB)
        {
            var selectedCopyFromPath = Path.Combine(CopyFromTB.Text, listView.SelectedItems[0].Text);
            var selectedCopyToPath = CopyToTB.Text;

            if (File.Exists(selectedCopyFromPath))
            {
                File.Copy(selectedCopyFromPath, selectedCopyToPath, true);
            }
            else if (Directory.Exists(selectedCopyFromPath))
            {
                DirectoryCopy(selectedCopyFromPath, selectedCopyToPath, true);
            }
        }
        private void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                return;
            }

            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, true);
            }

            if (copySubDirs)
            {
                DirectoryInfo[] subDirs = dir.GetDirectories();
                foreach (DirectoryInfo subDir in subDirs)
                {
                    string tempPath = Path.Combine(destDirName, subDir.Name);
                    DirectoryCopy(subDir.FullName, tempPath, copySubDirs);
                }
            }
        }
        private void listView_left_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            EndLabelEdit(e, textBox_DirrectoryPathLeft.Text, listView_left);
        }
        private void listView_right_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            EndLabelEdit(e, textBox_DirrectoryPathRight.Text, listView_right);
        }
        private void EndLabelEdit(LabelEditEventArgs e, string sourcePath, ListView listView)
        {
            if (e.Label != null)
            {
                string selectedPath = Path.Combine(sourcePath, listView.SelectedItems[0].Text);
                string newPath = Path.Combine(Path.GetDirectoryName(selectedPath), e.Label);

                if (File.Exists(selectedPath) || Directory.Exists(selectedPath))
                {
                    if (!File.Exists(newPath) && !Directory.Exists(newPath))
                    {
                        if (File.Exists(selectedPath))
                        {
                            File.Move(selectedPath, newPath);
                        }
                        else
                        {
                            Directory.Move(selectedPath, newPath);
                        }
                        listView.LabelEdit = false;
                    }
                    else
                    {
                        e.CancelEdit = true;
                    }
                }
            }
        }
        private void button_CreateFolderLeft_Click(object sender, EventArgs e)
        {
            string newFolderPath = Path.Combine(textBox_DirrectoryPathLeft.Text, "New folder");

            if (!Directory.Exists(newFolderPath))
            {
                Directory.CreateDirectory(newFolderPath);
            }

            UpdateListviews();
        }
        private void button_CreateFolderRight_Click(object sender, EventArgs e)
        {
            string newFolderPath = Path.Combine(textBox_DirrectoryPathRight.Text, "New folder");

            if (!Directory.Exists(newFolderPath))
            {
                Directory.CreateDirectory(newFolderPath);
            }

            UpdateListviews();
        }
    }
}
