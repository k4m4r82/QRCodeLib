using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ThoughtWorks.QRCode.Codec.Data
{
    public class QRCodeBitmapImageVB6 : QRCodeImage
    {
        object image;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="image">Bitmap image/param>
        public QRCodeBitmapImageVB6(object image)
        {
            this.image = image;
        }

        virtual public int Width
        {
            get
            {
                return image.Width;
            }

        }
        virtual public int Height
        {
            get
            {
                return image.Height;
            }

        }
     

        public virtual int getPixel(int x, int y)
        {
            return image.GetPixel(x, y).ToArgb();
        }
    }
}
