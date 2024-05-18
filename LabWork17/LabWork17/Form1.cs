namespace LabWork17
{
    public partial class Form1 : Form
    {
        FileInfo[] files;

        public Form1()
        {
            InitializeComponent();
            DirectoryInfo directory = new DirectoryInfo(@"V:\ispp35\LabWork17");
            files = directory.GetFiles("*", SearchOption.AllDirectories);
        }

        private void Task1Button_Click(object sender, EventArgs e)
        {
            fileDataGridView.DataSource = files
                .Select(
                files => new
                {
                    files.Name,
                    files.DirectoryName,
                    files.Length,
                    files.CreationTime
                })
                .OrderBy(files => files.Name)
                .ThenByDescending(files => files.CreationTime)
                .ToList();
        }

        private void Task2Button_Click(object sender, EventArgs e)
        {
            fileDataGridView.DataSource = files
                .Select(files => new
                {
                    files.Extension,
                })
                .Distinct()
                .ToList();
        }

        private void Task3Button_Click(object sender, EventArgs e)
        {
            fileDataGridView.DataSource = files
                .GroupBy(file => file.Extension)
                .Select(file => new
                {
                    Extension = file.Key,
                    ExtensionCount = file.Count()
                })
                .ToList();
        }

        private void Task4Button_Click(object sender, EventArgs e)
        {
            fileDataGridView.DataSource = files
                .Where(file => file.Name.Contains(fileNameTextBox.Text))
                .ToList();
        }
    }
}
