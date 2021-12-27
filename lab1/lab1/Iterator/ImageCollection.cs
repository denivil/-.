using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace lab1.Iterator
{
    internal class ImageCollection : IAggregate
    {
        private string _filePath;
        private List<Image> _images = new List<Image>();
        private PictureBox _pictureBox;

        public List<Image> Images => _images;

        public ImageCollection(string filePath, PictureBox pictureBox)
        {
            _filePath = filePath;
        }

        public IIterator GetIterator()
        {
            Setup();

            return new ImageIterator(this, _pictureBox);
        }

        private void Setup()
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(_filePath);

                foreach (var item in dir.GetFiles())
                {
                    Image img = Image.FromFile(item.FullName);

                    _images.Add(img);
                }
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("Ошибка чтения картинки");
            }
        }
    }
}
