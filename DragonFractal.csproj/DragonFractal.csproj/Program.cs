using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
// Цей простір імен містить засоби створення віконних програм. Зокрема у ньому знаходиться клас Form.
// Для того, щоб воно стало доступним, проект був підключений на System.Windows.Forms.dll

namespace Fractals
{
    internal static class Program
    {
        private  const int iterationCount = 10000000;
        private static void Main()
        {
            Pixels pixels = new Pixels();
            Bitmap image = new Bitmap(800, 800, PixelFormat.Format24bppRgb);
            using (var g = Graphics.FromImage(image))
            {
                g.Clear(Color.Black);
            }

            DragonPointFinder.DragonFractalDrawer(pixels, iterationCount);
            pixels.DrawToBitmap(image);

            // При бажанні можна зберегти створене зображення у файл так:
             image.Save("dragon.png", ImageFormat.Png);

            ShowImageInWindow(image);
        }

        private static void ShowImageInWindow(Bitmap image)
        {
            // Створення нового вікна заданого розміру: 
            Form form = new Form
            {
                Text = "Harter–Heighway dragon",
                ClientSize = image.Size
            };

            //Додаємо спеціальний елемент керування PictureBox, який вміє відображати створене нами зображення.
            form.Controls.Add(new PictureBox
            {
                Image = image,
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.CenterImage
            });
            form.ShowDialog();
        }
    }
}