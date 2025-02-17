using Aspose.BarCode.BarCodeRecognition;
using IronBarCode;
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
            var versiones = typeof(Form1).Assembly.GetName().Version;
            lblVersion.Text = "Versión " + versiones.ToString();
        }
        private void BtnConvertJpgToIco_Click(object sender, EventArgs e)
        {
            FormTamañoIcono formTamaño = new FormTamañoIcono();
            if (formTamaño.ShowDialog() == DialogResult.OK)
            {
                string tamañoIcono = formTamaño.TamañoIcono;
                int x = int.Parse(tamañoIcono.Split('x')[0]);
                int y = (byte)int.Parse(tamañoIcono.Split('x')[1]);
                
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
                    string filename = Path.GetFileName(inputPath).ToLower();
                    string nuevoNombre = filename.Insert(filename.IndexOf(".jpg"), "_" + x + "x" + y);

                    string carpeta = Path.GetDirectoryName(inputPath);
                    string outputPath = Path.ChangeExtension(carpeta + "\\" + nuevoNombre, ".ico");

                    // Convertir JPG a ICO
                    ConvertJpgToIcon(inputPath, outputPath, x, y);

                    // Mostrar un mensaje al usuario
                    MessageBox.Show($"Archivo ICO guardado en: {outputPath}", "Conversión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void ConvertJpgToIcon(string inputPath, string outputPath, int x, int y)
        {
            using (Bitmap bitmap = new Bitmap(inputPath))
            {
                // Crear un nuevo archivo ICO
                using (FileStream fs = new FileStream(outputPath, FileMode.Create))
                {
                    // Escribir el header del icono
                    fs.WriteByte(0); fs.WriteByte(0); // Reserved
                    fs.WriteByte(1); fs.WriteByte(0); // Type (1 = ICON)
                    fs.WriteByte(1); fs.WriteByte(0); // Image co
                    // Escribir la entrada de directorio para el icono
                    fs.WriteByte((byte)x); // Width
                    fs.WriteByte((byte)y); // Height
                    fs.WriteByte(0); // Color count (0 = no palette)
                    fs.WriteByte(0); // Reserved
                    fs.WriteByte(1); fs.WriteByte(0); // Planes
                    fs.WriteByte(32); fs.WriteByte(0); // Bit count - Profundidad de bits
                    byte[] bitmapData;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Bitmap iconBitmap = new Bitmap(bitmap, new Size(x, y));
                        iconBitmap.Save(ms, ImageFormat.Png);
                        bitmapData = ms.ToArray();
                    }
                    fs.Write(BitConverter.GetBytes(bitmapData.Length), 0, 4); // Size of image data
                    fs.Write(BitConverter.GetBytes(22), 0, 4); // Offset to image d
                    // Escribir los datos de la imagen
                    fs.Write(bitmapData, 0, bitmapData.Length);
                }
            }
        }
        private void BtnConvertPngToIco_Click(object sender, EventArgs e)
        {
            FormTamañoIcono formTamaño = new FormTamañoIcono();

            if (formTamaño.ShowDialog() == DialogResult.OK)
            {
                string tamañoIcono = formTamaño.TamañoIcono;
                int x = int.Parse(tamañoIcono.Split('x')[0]);
                int y = (byte)int.Parse(tamañoIcono.Split('x')[1]);

                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "PNG Files (*.png)|*.png",
                    Title = "Seleccionar un archivo PNG"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string inputPath = openFileDialog.FileName;
                    string outputPath = Path.ChangeExtension(inputPath, ".ico");

                    ConvertPngToIcon(inputPath, outputPath, x, y );

                    MessageBox.Show($"Archivo ICO guardado en: {outputPath}", "Conversión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void ConvertPngToIcon(string inputPath, string outputPath, int x, int y)
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
                    fs.WriteByte((byte)x); // Width
                    fs.WriteByte((byte)y); // Height
                    fs.WriteByte(0); // Color count (0 = no palette)
                    fs.WriteByte(0); // Reserved
                    fs.WriteByte(1); fs.WriteByte(0); // Planes
                    fs.WriteByte(32); fs.WriteByte(0); // Bit count
                    byte[] bitmapData;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Bitmap iconBitmap = new Bitmap(bitmap, new Size(x, y));
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
        private void BtnSvgToJpg_Click(object sender, EventArgs e)
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

        private void BtnTiffToJpg_Click(object sender, EventArgs e)
        {
            // Ruta del archivo TIFF multipágina
            string tiffFilePath = @"C:\temp\MultiTiff\multipage_tiff_example.tif";
            // Carpeta de salida para los archivos JPG
            string outputFolder = @"C:\temp\Jpgs";

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Tif Files (*.tif)|*.tif",
                Title = "Seleccionar un archivo multi TIF"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tiffFilePath = openFileDialog.FileName;
                string directoryPath = Path.GetDirectoryName(openFileDialog.FileName);
                outputFolder = directoryPath;
                ConvertTiffToJpg(tiffFilePath, outputFolder);
                ReadBarcodesFromJpgs(outputFolder);
            }
        }
        private void ConvertTiffToJpg(string tiffFilePath, string outputFolder)
        {
            Image tiffImage = Image.FromFile(tiffFilePath);
            FrameDimension frameDimension = new FrameDimension(tiffImage.FrameDimensionsList[0]);
            int frameCount = tiffImage.GetFrameCount(frameDimension);

            for (int i = 0; i < frameCount; i++)
            {
                tiffImage.SelectActiveFrame(frameDimension, i);
                string outputFilePath = System.IO.Path.Combine(outputFolder, $"page_{i + 1}.jpg");
                tiffImage.Save(outputFilePath, ImageFormat.Jpeg);
            }

            tiffImage.Dispose();
            MessageBox.Show($"Conversión completada. Los archivos jpg se encuentran en {outputFolder}");
        }
        private void ReadBarcodesFromJpgs(string outputFolder)
        {
            
            string[] jpgFiles = System.IO.Directory.GetFiles(outputFolder, "*.jpeg");

            foreach (var jpgFile in jpgFiles)
            {
                try
                {
                    string filePath = jpgFile;
                    Bitmap bitmap = new Bitmap(filePath);

                    bitmap = EnhanceImage(bitmap);
                    BarcodeResult result;
                    result = BarcodeReader.ReadASingleBarcode(bitmap, BarcodeEncoding.All);

                    if (result != null)
                    {
                        MessageBox.Show($"Código Detectado: {result.Text}\n" +
                                            $"Formato: {result.BarcodeType}", "Resultado");
                    }
                    else
                    {
                        MessageBox.Show("No se detectó ningún código de barras en la imagen.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer el código de barras: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        Bitmap EnhanceImage(Bitmap original)
        {
            // Convertir a escala de grises
            Bitmap grayscale = new Bitmap(original.Width, original.Height);
            using (Graphics g = Graphics.FromImage(grayscale))
            {
                ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
            new float[] {0.3f, 0.3f, 0.3f, 0, 0},
            new float[] {0.59f, 0.59f, 0.59f, 0, 0},
            new float[] {0.11f, 0.11f, 0.11f, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {0, 0, 0, 0, 1}
                });

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(colorMatrix);

                g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
                    0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
            }
            return grayscale;
        }
    }
}
