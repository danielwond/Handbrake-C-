namespace Handbrake
{
    public partial class Form1 : Form
    {
        long size = 0;

        public Form1()
        {
            InitializeComponent();
            label3.Text = $"Total Data: {listViewDirectories.Items.Count + listViewFiles.Items.Count}";
            txtMinSize.Text = "900";
            size = int.Parse(txtMinSize.Text) * 1048576;
        }
        static List<string> files = [];

        private void listViewDirectories_DragEnter(object sender, DragEventArgs e)
        {
            size = int.Parse(txtMinSize.Text) * 1048576;
            files.Clear();

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listViewDirectories_DragDrop(object sender, DragEventArgs e)
        {
            size = int.Parse(txtMinSize.Text) * 1048576;
            files.Clear();

            var s = (string[])e.Data.GetData(DataFormats.FileDrop, true);

            for (int i = 0; i < s.Length; i++)
            {
                ReadDirectories(s[i]);
            }
            foreach (var item in files)
            {
                var exists = listViewDirectories.Items.Cast<ListViewItem>().Where(x => x.Text == item).FirstOrDefault();
                if (exists == null)
                {
                    listViewDirectories.Items.Add(item);
                }
            }
            label3.Text = $"Total Data: {listViewDirectories.Items.Count + listViewFiles.Items.Count}";
        }

        private void listViewFiles_DragEnter(object sender, DragEventArgs e)
        {
            size = int.Parse(txtMinSize.Text) * 1048576;
            files.Clear();

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listViewFiles_DragDrop(object sender, DragEventArgs e)
        {
            size = int.Parse(txtMinSize.Text) * 1048576;
            files.Clear();

            var extensions = new[] { ".mp4", ".wmv" }.ToHashSet();
            var s = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            s = s.Where(x => extensions.Contains(Path.GetExtension(x))).ToArray();

            for (int i = 0; i < s.Length; i++)
            {
                listViewFiles.Items.Add(s[i]);
            }
            label3.Text = $"Total Data: {listViewDirectories.Items.Count + listViewFiles.Items.Count}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listViewDirectories.Items.Clear();
            listViewFiles.Items.Clear();

            label3.Text = $"Total Data: {listViewDirectories.Items.Count + listViewFiles.Items.Count}";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listViewDirectories.Items.Clear();
            label3.Text = $"Total Data: {listViewDirectories.Items.Count + listViewFiles.Items.Count}";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listViewFiles.Items.Clear();
            label3.Text = $"Total Data: {listViewDirectories.Items.Count + listViewFiles.Items.Count}";

        }

        public void ReadDirectories(string path, string directoryName = "")
        {
            var extensions = new[] { ".mp4", ".wmv" }.ToHashSet();

            if (!string.IsNullOrEmpty(directoryName))
            {
                Console.WriteLine("DIRECTORY NAME - {0}", directoryName);
                path = @$"{path}\{directoryName}";
            }

            DirectoryInfo dir_place = new(path);

            FileInfo[] Files = dir_place.GetFiles().Where(x => extensions.Contains(Path.GetExtension(x.FullName))).ToArray();
            foreach (FileInfo i in Files)
            {
                Console.WriteLine("{0} - FILE NAME - {1}", directoryName, i.Name);
                if (i.Length >= size)
                {
                    if (!files.Contains(i.FullName) && !i.Name.StartsWith("Converted_"))
                    {
                        files.Add(i.FullName);
                    }
                }
            }

            DirectoryInfo[] directories = dir_place.GetDirectories();
            foreach (var directory in directories)
            {
                ReadDirectories(path, directory.Name);
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fromDirectories = listViewDirectories.Items;
            var fromFiles = listViewFiles.Items;
            var allItem = new List<string>();

            if (fromFiles.Count > 0)
            {
                foreach (var item in fromFiles)
                {
                    allItem.Add(item.ToString()!);
                }
            }

            if (fromDirectories.Count > 0)
            {
                foreach (var item in fromDirectories)
                {
                    allItem.Add(item.ToString()!);
                }
            }

            if (allItem.Count > 0)
            {
                foreach (var item in allItem)
                {
                    var newItem = item.Replace("ListViewItem: {", "");
                    newItem = newItem.Substring(0, newItem.Length - 1);
                    HandbrakeConversion.ConvertFile(newItem);
                }
            }
            else
            {
                MessageBox.Show("No files have been added!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
