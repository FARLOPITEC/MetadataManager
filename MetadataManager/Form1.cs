using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace MetadataManager
{
    public partial class Form1 : Form
    {
        private string selectedFilePath = string.Empty; // Inicializar con un valor por defecto

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Examine_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new())
            {
                openDialog.Filter = "All files|*.*";
                openDialog.Title = "Open a file to be hashed";
                openDialog.Multiselect = false;

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = openDialog.FileName;
                    this.textBox1.Text = selectedFilePath; // Mostrar la ruta del archivo en textBox1

                    // Obtener metadatos del archivo
                    FileInfo fileInfo = new FileInfo(selectedFilePath);
                    var metadata = new List<string>
                    {
                        $"Name: {fileInfo.Name}",
                        $"Full Path: {fileInfo.FullName}",
                        $"Extension: {fileInfo.Extension}",
                        $"Size: {fileInfo.Length} bytes",
                        $"Created: {fileInfo.CreationTime}",
                        $"Modified: {fileInfo.LastWriteTime}",
                        $"Accessed: {fileInfo.LastAccessTime}",
                        $"Read-Only: {fileInfo.IsReadOnly}",
                        $"Attributes: {fileInfo.Attributes}",
                    };

                    // Si el archivo es una imagen, obtener metadatos EXIF
                    if (fileInfo.Extension.ToLower() == ".jpg" || fileInfo.Extension.ToLower() == ".jpeg" || fileInfo.Extension.ToLower() == ".png")
                    {
                        metadata.AddRange(GetImageMetadata(selectedFilePath));
                    }

                    // Limpiar el ListBox antes de agregar nuevos ítems
                    this.listBox1.Items.Clear();

                    // Agregar metadatos al ListBox
                    foreach (string data in metadata)
                    {
                        this.listBox1.Items.Add(data);
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Please select a file first.");
                return;
            }

            if (!File.Exists(selectedFilePath))
            {
                MessageBox.Show($"The file '{selectedFilePath}' does not exist.");
                return;
            }

            FileInfo fileInfo = new FileInfo(selectedFilePath);

            // Modificar los metadatos del archivo con los valores de los TextBox
            if (DateTime.TryParse(textBox_created.Text, out DateTime creationTime))
            {
                fileInfo.CreationTime = creationTime;
            }

            if (DateTime.TryParse(textBox_modified.Text, out DateTime lastWriteTime))
            {
                fileInfo.LastWriteTime = lastWriteTime;
            }
            else
            {
                MessageBox.Show("Remember to change the access and/or modification date if you have made changes as it will be altered");
            }

            DateTime lastAccessTime = fileInfo.LastAccessTime;
            if (DateTime.TryParse(textBox_accessed.Text, out DateTime parsedLastAccessTime))
            {
                lastAccessTime = parsedLastAccessTime;
            }

            // Cambiar el nombre del archivo si es diferente
            string newFileName = textBox_name.Text;
            if (!string.IsNullOrEmpty(newFileName) && newFileName != fileInfo.Name)
            {
                string? directoryName = fileInfo.DirectoryName;
                if (directoryName != null)
                {
                    string newFilePath = Path.Combine(directoryName, newFileName);
                    File.Move(selectedFilePath, newFilePath);
                    selectedFilePath = newFilePath;
                    fileInfo = new FileInfo(selectedFilePath); // Actualizar fileInfo con la nueva ruta
                }
            }

            // Actualizar la fecha de último acceso
            fileInfo.LastAccessTime = lastAccessTime;

            MessageBox.Show("Metadata updated successfully.");
        }


        private void button_recharge_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Please select a file first.");
                return;
            }

            // Obtener metadatos del archivo
            FileInfo fileInfo = new FileInfo(selectedFilePath);
            var metadata = new List<string>
            {
                $"Name: {fileInfo.Name}",
                $"Full Path: {fileInfo.FullName}",
                $"Extension: {fileInfo.Extension}",
                $"Size: {fileInfo.Length} bytes",
                $"Created: {fileInfo.CreationTime}",
                $"Modified: {fileInfo.LastWriteTime}",
                $"Accessed: {fileInfo.LastAccessTime}",
                $"Read-Only: {fileInfo.IsReadOnly}",
                $"Attributes: {fileInfo.Attributes}",
            };

            // Si el archivo es una imagen, obtener metadatos EXIF
            if (fileInfo.Extension.ToLower() == ".jpg" || fileInfo.Extension.ToLower() == ".jpeg" || fileInfo.Extension.ToLower() == ".png")
            {
                metadata.AddRange(GetImageMetadata(selectedFilePath));
            }

            // Limpiar el ListBox antes de agregar nuevos ítems
            this.listBox1.Items.Clear();

            // Agregar metadatos al ListBox
            foreach (string data in metadata)
            {
                this.listBox1.Items.Add(data);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            // Limpiar los TextBox y el ListBox
            textBox1.Clear();
            textBox_created.Clear();
            textBox_modified.Clear();
            textBox_accessed.Clear();
            textBox_name.Clear();
            listBox1.Items.Clear();
        }

        private IEnumerable<string> GetImageMetadata(string filePath)
        {
            var metadata = new List<string>();
            using (Image image = Image.FromFile(filePath))
            {
                foreach (PropertyItem propItem in image.PropertyItems)
                {
                    if (propItem.Id == 0x010F && propItem.Value != null) // Make
                    {
                        metadata.Add($"Dispositivo: {Encoding.UTF8.GetString(propItem.Value).Trim('\0')}");
                    }
                    if (propItem.Id == 0x0110 && propItem.Value != null) // Model
                    {
                        metadata.Add($"Modelo: {Encoding.UTF8.GetString(propItem.Value).Trim('\0')}");
                    }
                }
            }
            return metadata;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
