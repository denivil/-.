using System.Drawing;
using System.Windows.Forms;

namespace lab1.Iterator
{
    internal class ImageIterator : IIterator
    {
        private ImageCollection _images;

        private int _count;

        private PictureBox _pictureBox;

        public ImageIterator(ImageCollection imageCollection, PictureBox pictureBox)
        {
            _pictureBox = pictureBox;

            _images = imageCollection;
        }

        public bool HasNext()
        {
            if (_count + 1 > _images.Images.Count)
                return false;
            else
                return true;
        }

        public object Next()
        {
            return GetImage(true);
        }

        public object Previous()
        {
            return GetImage(false);
        }

        private Image GetImage(bool lORr)
        {
            if (_images.Images.Count > 0)
            {
                if (lORr)
                    _count++;
                else
                    _count--;

                if (_count < 0)
                    _count++;

                if (_count == _images.Images.Count)
                    _count--;

                return _images.Images[_count];
            }

            return null;
        }
    }
}
