using System;
using System.Drawing;
using System.Collections;
namespace SteganForm
{
    public class Steganografy
    {
        private string alphabet = " абвгдеёжзийклмнопрстуфхцчшщъыьэюя.?!,"; // длина должна быть меньше 64
        private string english = " abcdefghijklmnopqrstuvwxyz.?!,"; // длина должна быть меньше 32
        private int GetIntFromBitArray(BitArray bitArray)
        {
            int result = 0;

            for (int i = 0; i < bitArray.Count; i++)
                if(bitArray[i])result += (int)Math.Pow(2, i);

            return result;
        }

        BitArray FromInt(int c)
        {
            BitArray bitArray = new(8);
            BitArray cArray = new(new int[] { c });
            for (int i = 0; i < 8; i++)
                bitArray[i] = false;

            for (int i = 0; i < 8; i++)
                bitArray[i] = cArray[i];

            return bitArray;
        }
        public Bitmap ShowMessage(Bitmap sourse)
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

                    var bitArrR = FromInt(r);
                    var bitArrG = FromInt(g);
                    var bitArrB = FromInt(b);

                    for(int k=4;k<8;k++)
                    {
                        bitArrR[k] = bitArrR[8 - k];
                        bitArrG[k] = bitArrG[8 - k];
                        bitArrB[k] = bitArrB[8 - k];
                    }

                    r = GetIntFromBitArray(bitArrR);
                    g = GetIntFromBitArray(bitArrG);
                    b = GetIntFromBitArray(bitArrB);

                    Color c = Color.FromArgb(r, g, b);
                    result.SetPixel(i, j, c);
                } 
            }

            return result;
        }
        public Bitmap HideMessage(Bitmap sourse, Bitmap message)
        {
            int width = Math.Min(sourse.Width, message.Width);
            int height = Math.Min(sourse.Height, message.Height);

            Bitmap result = new( width, height);

            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    BitArray redSourse   = FromInt (sourse.GetPixel(i, j).R);
                    BitArray greenSourse = FromInt(sourse.GetPixel(i, j).G);
                    BitArray blueSourse  = FromInt(sourse.GetPixel(i, j).B);

                    BitArray redMessage =   FromInt(message.GetPixel(i, j).R);
                    BitArray greenMessage = FromInt(message.GetPixel(i, j).G);
                    BitArray blueMessage = FromInt(message.GetPixel(i, j).B);

                    for(int n = 4;n<8;n++)
                    {
                        redSourse[8 - n] = redMessage[n];
                        greenSourse[8 - n] = greenMessage[n];
                        blueSourse[8 - n] = blueMessage[n];
                    }
                    byte red = (byte)GetIntFromBitArray(redSourse);
                    byte green = (byte)GetIntFromBitArray(greenSourse);
                    byte blue = (byte)GetIntFromBitArray(blueSourse);

                    Color resultColor = Color.FromArgb(red, green, blue);
                    result.SetPixel( i, j, resultColor);
                }
            }

            return result;
        }
        /// <summary>
        /// Номер буквы в алфавите в виде битового массива 
        /// </summary>
        /// <param name="alfabet"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        BitArray FromSymbol(string alfabet, char c)
        {
            int size = alfabet.Length > 32 ? 6 : 5;

            BitArray bitArray = new(size);

            int index = alfabet.IndexOf(c);
            if (index < 0) index = 0;

            BitArray cArray = new(new int[] { index });
            for (int i = 0; i < size; i++)
                bitArray[i] = false;

            for (int i = 0; i < size; i++)
                bitArray[i] = cArray[i];

            return bitArray;
        }
        /// <summary>
        /// Битовый массив из текста, если алфавит русский 6 битов на символ, 5 битов на английский соответсвтенно
        /// </summary>
        /// <param name="text"></param>
        /// <param name="symbolSize"></param>
        /// <returns></returns>
        public BitArray FromText(string text, int symbolSize = 6)
        {
            int length = text.Length;

            int bitArraySize = length * symbolSize;

            BitArray result = new( bitArraySize);

            string Alfabet = symbolSize == 6 ? alphabet : english;

            for(int i = 0;i < length; i++)
            {
                var cArray = FromSymbol( Alfabet, text[i]);
                
                for(int j = 0; j < cArray.Count; j++)
                {
                    result[i * symbolSize + j] = cArray[j];
                }
            }

            return result;
        }
        int BitSize = 6;
        public Bitmap HideMessage(Bitmap sourse, string message,int size)
        {
            int width = sourse.Width;
            int height = sourse.Height;

            Bitmap result = new(width, height);
            BitArray symbolArray = FromText(" " + message, BitSize);

            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    BitArray rSourse = FromInt(sourse.GetPixel(i, j).R);
                    BitArray gSourse = FromInt(sourse.GetPixel(i, j).G);
                    BitArray bSourse = FromInt(sourse.GetPixel(i, j).B);

                    for(int k = 0;k < size; k++)
                    {
                        int pixel_index = i * width + j;

                        int symbol_index = pixel_index * size * 3 + k;

                        if (symbol_index + size * 2 >= symbolArray.Count) 
                        {
                            rSourse[k] = false;
                            gSourse[k] = false;
                            bSourse[k] = false;

                        }
                        else
                        {
                            rSourse[k] = symbolArray[symbol_index + size * 0];
                            gSourse[k] = symbolArray[symbol_index + size * 1];
                            bSourse[k] = symbolArray[symbol_index + size * 2];
                        }
                    }

                    byte r = (byte)GetIntFromBitArray(rSourse);
                    byte g = (byte)GetIntFromBitArray(gSourse);
                    byte b = (byte)GetIntFromBitArray(bSourse);

                    Color resultColor = Color.FromArgb(r, g, b);
                    result.SetPixel( i, j, resultColor);
                }
            }

            return result;
        }

        public string ShowMessage(Bitmap sourse, int size) 
        {
            string result = string.Empty;

            string Alfabet = BitSize == 6 ? alphabet : english;

            int width = sourse.Width;
            int height = sourse.Height;

            BitArray symbolArray = new(width * height * size * 3);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    BitArray rSourse = FromInt(sourse.GetPixel(i, j).R);
                    BitArray gSourse = FromInt(sourse.GetPixel(i, j).G);
                    BitArray bSourse = FromInt(sourse.GetPixel(i, j).B);

                    for (int k = 0; k < size; k++)
                    {
                        int pixel_index = i * width + j;

                        if (pixel_index * size * 3 + k + 2 * size < symbolArray.Count)
                        {
                            symbolArray[pixel_index * size * 3 + k + size * 0] = rSourse[k];
                            symbolArray[pixel_index * size * 3 + k + size * 1] = gSourse[k];
                            symbolArray[pixel_index * size * 3 + k + size * 2] = bSourse[k];
                        }
                        else break;
                    }
                }
            }

            for(int i = BitSize; i <= symbolArray.Count; i+= BitSize)
            {
                BitArray symbol = new(BitSize);

                for(int j = 0; j < BitSize; j++)
                {
                    if (i + j >= symbolArray.Count) return result;

                    symbol[j] = symbolArray[i + j];
                }

                int index = GetIntFromBitArray(symbol);

                char c = Alfabet[index % Alfabet.Length];
                
                result += c;
            }

            return result;
        }
    }
}
