namespace FileIOExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            // Start in the "My Documents" folder
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Code to handle the file open
                string filePath = openFileDialog.FileName;
                // Read the file content into a string
                string fileContents = File.ReadAllText(filePath);
                // You can now use the fileContent string as needed
                MessageBox.Show(fileContents, "File Content");
            }
        }
    }
}
