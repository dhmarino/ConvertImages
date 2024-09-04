using Svg;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ConvertJpgToIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            // Crea y configurar el OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JPG Files (*.jpg)|*.jpg",
                Title = "Seleccionar un archivo JPG"
            };

            // Mostrar el diálogo para seleccionar el archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string inputPath = openFileDialog.FileName;

                // Definir la ruta de salida para el archivo .ico
                string outputPath = Path.ChangeExtension(inputPath, ".ico");

                // Convertir JPG a ICO
                ConvertJpgToIcon(inputPath, outputPath);

                // Mostrar un mensaje al usuario
                MessageBox.Show($"Archivo ICO guardado en: {outputPath}", "Conversión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ConvertJpgToIcon(string inputPath, string outputPath)
        {
            using (Bitmap bitmap = new Bitmap(inputPath))
            {
                // Crear un nuevo archivo ICO
                using (FileStream fs = new FileStream(outputPath, FileMode.Create))
                {
                    // Escribir el header del icono
                    fs.WriteByte(0); fs.WriteByte(0); // Reserved
                    fs.WriteByte(1); fs.WriteByte(0); // Type (1 = ICON)
                    fs.WriteByte(1); fs.WriteByte(0); // Image count

                    // Escribir la entrada de directorio para el icono
                    fs.WriteByte(32); // Width
                    fs.WriteByte(32); // Height
                    fs.WriteByte(0); // Color count (0 = no palette)
                    fs.WriteByte(0); // Reserved
                    fs.WriteByte(1); fs.WriteByte(0); // Planes
                    fs.WriteByte(32); fs.WriteByte(0); // Bit count
                    byte[] bitmapData;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Bitmap iconBitmap = new Bitmap(bitmap, new Size(32, 32));
                        iconBitmap.Save(ms, ImageFormat.Png);
                        bitmapData = ms.ToArray();
                    }
                    fs.Write(BitConverter.GetBytes(bitmapData.Length), 0, 4); // Size of image data
                    fs.Write(BitConverter.GetBytes(22), 0, 4); // Offset to image data

                    // Escribir los datos de la imagen
                    fs.Write(bitmapData, 0, bitmapData.Length);
                }
            }
        }

        private void buttonConvert2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PNG Files (*.png)|*.png",
                Title = "Seleccionar un archivo PNG"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string inputPath = openFileDialog.FileName;
                string outputPath = Path.ChangeExtension(inputPath, ".ico");

                ConvertPngToIcon(inputPath, outputPath);

                MessageBox.Show($"Archivo ICO guardado en: {outputPath}", "Conversión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ConvertPngToIcon(string inputPath, string outputPath)
        {
            using (Bitmap bitmap = new Bitmap(inputPath))
            {
                // Crear un nuevo archivo ICO
                using (FileStream fs = new FileStream(outputPath, FileMode.Create))
                {
                    // Escribir el header del icono
                    fs.WriteByte(0); fs.WriteByte(0); // Reserved
                    fs.WriteByte(1); fs.WriteByte(0); // Type (1 = ICON)
                    fs.WriteByte(1); fs.WriteByte(0); // Image count

                    // Escribir la entrada de directorio para el icono
                    fs.WriteByte(32); // Width
                    fs.WriteByte(32); // Height
                    fs.WriteByte(0); // Color count (0 = no palette)
                    fs.WriteByte(0); // Reserved
                    fs.WriteByte(1); fs.WriteByte(0); // Planes
                    fs.WriteByte(32); fs.WriteByte(0); // Bit count
                    byte[] bitmapData;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Bitmap iconBitmap = new Bitmap(bitmap, new Size(32, 32));
                        iconBitmap.Save(ms, ImageFormat.Png);
                        bitmapData = ms.ToArray();
                    }
                    fs.Write(BitConverter.GetBytes(bitmapData.Length), 0, 4); // Size of image data
                    fs.Write(BitConverter.GetBytes(22), 0, 4); // Offset to image data

                    // Escribir los datos de la imagen
                    fs.Write(bitmapData, 0, bitmapData.Length);
                }
            }
        }

        private void btnSvgToJpg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "SVG Files (*.svg)|*.svg",
                Title = "Seleccionar un archivo SVG"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string inputPath = openFileDialog.FileName;
                string outputPath = Path.ChangeExtension(inputPath, ".jpg");

                ConvertSvgToJpg(inputPath, outputPath);

                MessageBox.Show($"Archivo JPG guardado en: {outputPath}", "Conversión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ConvertSvgToJpg(string inputPath, string outputPath)
        {
            // Cargar el archivo SVG
            SvgDocument svgDocument = SvgDocument.Open(inputPath);

            // Especificar el tamaño de salida del JPG
            Bitmap bitmap = new Bitmap((int)svgDocument.Width, (int)svgDocument.Height);

            // Renderizar el SVG en un bitmap
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                svgDocument.Draw(graphics);
            }

            // Guardar el bitmap como archivo JPG
            bitmap.Save(outputPath, ImageFormat.Jpeg);
        }
    }
}
