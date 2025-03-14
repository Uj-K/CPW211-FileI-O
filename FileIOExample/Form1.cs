using System.Text;

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
            // Start in the "My Documents" folder.
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // 처음 시작할때 어느 폴더에서 열지 설정
            openFileDialog.Filter = "Text files (*.txt)|*.txt"; // 어떤 종류의 파일들을 보여줄지 설정. 여기서는 txt 파일만 보여줌.
            // openFileDialog.FilterIndex = 1 만약 위의  Filter가 여러개일 경우 어떤것들 default로 보여줄지 선택. 근데 우리는 txt 하나니까 필요없어서 삭제.
            openFileDialog.RestoreDirectory = true; // 마지막으로 열었던 폴더를 기억하고 다음에 다시 열때 그 폴더에서 열게함.


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Code to handle the file open.
                string filePath = openFileDialog.FileName;
                // Read the file content into a string.
                string fileContents = File.ReadAllText(filePath);
                // Display file content in a text box.
                textbox.Text = fileContents;
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFileDialog = new();
            // Start in the "My Documents" folder.
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Code to handle the file save.
                string filePath = saveFileDialog.FileName;
                // Example content to save.
                string fileContents = "This is an example content to save in the file.";
                // Write the content to the file.
                File.WriteAllText(filePath, textbox.Text);
                MessageBox.Show("File saved successfully.", "Save File");
            }
        }

        /// <summary>
        /// Encrypts the input string using a Caesar cipher by shifting each letter forward.
        /// Non-letter characters remain unchanged.
        /// </summary>
        /// <param name="input">The plain text to encrypt.</param>
        /// <returns>The encrypted string.</returns>
        private string Encrypt(string input)
        {
            // Constant for the Caesar cipher shift value.
            const int CaesarShift = 3;

            // Constant for the number of letters in the English alphabet.
            const int AlphabetLength = 26;
            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    // Determine if the character is uppercase or lowercase.
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    // Shift the character and wrap around using the alphabet length.
                    result.Append((char)(((c - offset + CaesarShift) % AlphabetLength) + offset));
                }
                else
                {
                    // Non-letter characters are added unchanged.
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        /// <summary>
        /// Decrypts the input string that was encrypted using a Caesar cipher by shifting each letter backward.
        /// Non-letter characters remain unchanged.
        /// </summary>
        /// <param name="input">The encrypted text to decrypt.</param>
        /// <returns>The decrypted string.</returns>
        private string Decrypt(string input)
        {
            // Constant for the Caesar cipher shift value.
            const int CaesarShift = 3;

            // Constant for the number of letters in the English alphabet.
            const int AlphabetLength = 26;

            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    // Determine if the character is uppercase or lowercase.
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    // Shift the character back by subtracting the shift value. Adding AlphabetLength ensures a positive modulo result.
                    result.Append((char)(((c - offset - CaesarShift + AlphabetLength) % AlphabetLength) + offset));
                }
                else
                {
                    // Non-letter characters are added unchanged.
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textbox.Text))
            {
                textbox.Text = Encrypt(textbox.Text);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textbox.Text))
            {
                textbox.Text = Decrypt(textbox.Text);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textbox.Text))
            {
                MessageBox.Show("Please select a file");
            }
            else 
            {
                textbox.Text = string.Empty;
            }
           
        }
    }
}
