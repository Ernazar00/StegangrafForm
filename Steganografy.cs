using System;
using System.Drawing;
using System.Collections;
namespace SteganForm
{
    public class Steganografy
    {
        private int getIntFromBitArray(BitArray bitArray)
        {
            int result = 0;

            for (int i = 0; i < bitArray.Count; i++)
                if(bitArray[i])result += (int)Math.Pow(2, i);

            return result;
        }

        BitArray from_int(int c)
        {
            BitArray bitArray = new BitArray(8);
            BitArray cArray = new BitArray(new int[] { c });
            for (int i = 0; i < 8; i++)
                bitArray[i] = false;

            for (int i = 0; i < 8; i++)
                bitArray[i] = cArray[i];

            return bitArray;
        }
        public Bitmap HiddenMessage(Bitmap sourse)
        {
            int w = sourse.Width;
            int h = sourse.Height;
            Bitmap result = new(w,h);

            for(int i = 0;i<w;i++)
            {
                for(int j = 0; j < h; j++)
                {
                    int r = sourse.GetPixel(i, j).R;
                    int g = sourse.GetPixel(i, j).G;
                    int b = sourse.GetPixel(i, j).B;

                    var bitArrR = from_int(r);
                    var bitArrG = from_int(g);
                    var bitArrB = from_int(b);

                    for(int k=4;k<8;k++)
                    {
                        bitArrR[k] = bitArrR[8 - k];
                        bitArrG[k] = bitArrG[8 - k];
                        bitArrB[k] = bitArrB[8 - k];
                    }

                    r = getIntFromBitArray(bitArrR);
                    g = getIntFromBitArray(bitArrG);
                    b = getIntFromBitArray(bitArrB);

                    Color c = Color.FromArgb(r, g, b);
                    result.SetPixel(i, j, c);
                } 
            }

            return result;
        }
        public Bitmap Message(Bitmap sourse, Bitmap message)
        {
            int width = Math.Min(sourse.Width, message.Width);
            int height = Math.Min(sourse.Height, message.Height);

            Bitmap result = new(width, height);

            for(int i=0;i<width;i++)
            {
                for(int j = 0; j < height; j++)
                {
                    BitArray redSourse   = from_int (sourse.GetPixel(i, j).R);
                    BitArray greenSourse = from_int(sourse.GetPixel(i, j).G);
                    BitArray blueSourse  = from_int(sourse.GetPixel(i, j).B);

                    BitArray redMessage =   from_int(message.GetPixel(i, j).R);
                    BitArray greenMessage = from_int(message.GetPixel(i, j).G);
                    BitArray blueMessage = from_int(message.GetPixel(i, j).B);

                    for(int n = 4;n<8;n++)
                    {
                        redSourse[8 - n] = redMessage[n];
                        greenSourse[8 - n] = greenMessage[n];
                        blueSourse[8 - n] = blueMessage[n];
                    }
                    byte red = (byte)getIntFromBitArray(redSourse);
                    byte green = (byte)getIntFromBitArray(greenSourse);
                    byte blue = (byte)getIntFromBitArray(blueSourse);

                    Color resultColor = Color.FromArgb(red, green, blue);
                    result.SetPixel( i, j, resultColor);
                }
            }

            return result;
        }
    }
}
