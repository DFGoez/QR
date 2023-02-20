using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace CreateQR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            String datos;
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();


            var client = new Client
            {
                Name = label1.Text.Trim(),
                LastName = label2.Text.Trim(),
                ID = label3.Text.Trim(),
                Phone = label4.Text.Trim()
            };

            String jsonString = JsonConvert.SerializeObject(client, Formatting.Indented);
            //qrEncoder.TryEncode(jsonString, out qrCode);

            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(jsonString);
            result = Convert.ToBase64String(encryted);

            qrEncoder.TryEncode(result, out qrCode);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemporal = new Bitmap(ms);
            var imagen = new Bitmap(imageTemporal, new Size(new Point(200, 200)));

            imgQR.BackgroundImage = imagen;
            imagen.Save("imagen.png", ImageFormat.Png);

            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Image image = (Image)imgQR.BackgroundImage.Clone();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "Image PNG (*.png)|*.png";
            saveFileDialog.ShowDialog();
            if (!String.IsNullOrEmpty(saveFileDialog.FileName))
            {
                image.Save(saveFileDialog.FileName, ImageFormat.Png);
            }
            image.Dispose();
        }
    }
}


/*

/// Encripta una cadena
public static string Encriptar(this string _cadenaAencriptar)
{
string result = string.Empty;
byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
result = Convert.ToBase64String(encryted);
return result;
}

/// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
public static string DesEncriptar(this string _cadenaAdesencriptar)
{
string result = string.Empty;
byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
//result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
result = System.Text.Encoding.Unicode.GetString(decryted);
return result;
}
}
En el siguiente código podemos ver cómo usar la clase anterior:

protected void btnInicio_Click(object sender, EventArgs e)
        {     
//encriptamos la cadena inicial       
            txtcadenaencriptada.Text = Seguridad.Encriptar(txtcadenainicial.Text);
//ahora desencriptamos
            txtcadenafinal.Text = Seguridad.DesEncriptar(txtcadenaencriptada.Text);
//Vereis que despues de estas instrucciones txtcadenainial y txtcadenafinal contienen lo mismo.

        }

*/