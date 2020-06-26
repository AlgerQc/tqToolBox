using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace tqToolBox.ImageUtlcs
{
    class ImageUtilcs
    {
        //每张图片之间的间距
        private static int img_interval = 2;
        private static Bitmap bigImageMap = new Bitmap(1, 1);
        private static Dictionary<string, Rect> ImageDic = new Dictionary<string, Rect>();//文件名对应的Image对象

        //获取合图的面积
        private static Size GetBigImgSize()
        {
            Size bitMapSize = new Size();
            foreach (KeyValuePair<string, Rect> dic in ImageDic)
            {
                Rect rect = dic.Value;
                if (rect.x + rect.image.Width > bitMapSize.Width)
                {
                    bitMapSize.Width = rect.x + rect.image.Width;
                }
                if (dic.Value.y + rect.image.Height > bitMapSize.Height)
                {
                    bitMapSize.Height = rect.y + rect.image.Height;
                }
            }
            bitMapSize.Width += img_interval * 2;
            bitMapSize.Height += img_interval * 2;
            return bitMapSize;
        }
        //对图片进行排序，按照面积大小
        private static void DicSortInArea()
        {
            Dictionary<string, Rect> NewImageDic = new Dictionary<string, Rect>();//文件名对应的Image对象
            int imgCount = ImageDic.Count;
            int all_area = 0;
            for(int i= 0; i < imgCount; i++)
            {
                string p_key = "";
                int p_area = 0;
                foreach (KeyValuePair<string, Rect> dic in ImageDic)  //取出每一张图片
                {
                    int width = dic.Value.image.Width;
                    int height = dic.Value.image.Height;
                    if(p_area < width * height)
                    {
                        p_area = width * height;
                        p_key = dic.Key;
                    }
                    if (i == 0)
                    {
                        all_area = all_area + (width * height);
                    }
                }
                if (ImageDic.ContainsKey(p_key) == true)
                {
                    NewImageDic.Add(p_key, ImageDic[p_key]);
                    ImageDic.Remove(p_key);
                }
            }
            MaxRectsBinPack.MinRectangle(all_area);
            ImageDic.Clear();
            ImageDic = NewImageDic;
        }

        //设置每一张图片所在的位置
        private static void SetImagesPoint()
        {
            DicSortInArea();
            foreach (KeyValuePair<string, Rect> dic in ImageDic)  //取出每一张图片的key
            {
                Size newRect = MaxRectsBinPack.Insert(dic.Value.image.Width, dic.Value.image.Height);
                ImageDic[dic.Key].x = newRect.Width;
                ImageDic[dic.Key].y = newRect.Height;
            }
        }

        public static Bitmap CombinImage(string[] files)
        {
            ImageDic.Clear();
            bigImageMap.Dispose();
            //MaxRectsBinPack.init(128, 128);
            foreach (string srcfile in files)
            {
                //判断是否为文件
                if (File.Exists(srcfile))
                {
                    Rect rect = new Rect();
                    Image img = Image.FromFile(srcfile);
                    string strFileName = System.IO.Path.GetFileName(srcfile);//获取文件名
                    if (ImageDic.ContainsKey(strFileName) == false)
                    {
                        rect.SetImage(img);
                        //Size newRect = MaxRectsBinPack.Insert(img.Width, img.Height);
                        //rect.x = newRect.Width;
                        //rect.y = newRect.Height;
                        ImageDic.Add(strFileName, rect);
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("文件名重复！！");
                        Bitmap bitMap = new Bitmap(0, 0);
                        return bitMap;
                    }
                }
            }
            SetImagesPoint();
            Size bitMapSize = GetBigImgSize();
            Bitmap bitmap = new Bitmap(bitMapSize.Width, bitMapSize.Height);
            //// 初始化画板
            Graphics g1 = Graphics.FromImage(bitmap);
            // 将画布涂为透明
            Brush brush = new SolidBrush(Color.FromArgb(0, 255, 255, 255));
            g1.FillRectangle(brush, new Rectangle(0, 0, bitMapSize.Width, bitMapSize.Height));
            foreach (KeyValuePair<string, Rect> dic in ImageDic)
            {
                Bitmap map1 = new Bitmap(dic.Value.image);
                Size newRect = MaxRectsBinPack.Insert(dic.Value.image.Width, dic.Value.image.Height);

                g1.DrawImage(map1, dic.Value.x + img_interval, dic.Value.y + img_interval, dic.Value.image.Width, dic.Value.image.Height);
                map1.Dispose();
            }
            g1.Dispose();
            MaxRectsBinPack.ClearBinPack();
            bigImageMap = bitmap;
            return bitmap;
        }

        public static void SaveFntFont(string fontName, string path)
        {
            bigImageMap.Save(path + @"\\" + fontName + @".png", System.Drawing.Imaging.ImageFormat.Png);
            //文件写入
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path + @"\\" + fontName + @".fnt"))
            {
                string one_line = "info face = \"Arial\" size = 32 bold = 0 italic = 0 charset = \"\" unicode = 1 stretchH = 100 smooth = 1 aa = 1 padding = 0,0,0,0 spacing = 1,1 outline = 0";
                file.WriteLine(one_line);
                string two_line = @"common lineHeight=32 base=26 scaleW=256 scaleH=256 pages=1 packed=0 alphaChnl=1 redChnl=0 greenChnl=0 blueChnl=0";
                file.WriteLine(two_line);
                string three_line = "page id=0 file=\"" + fontName + ".png\"";
                file.WriteLine(three_line);
                string four_line = @"chars count=" + ImageDic.Count;
                file.WriteLine(four_line);
                foreach (KeyValuePair<string, Rect> dic in ImageDic)
                {
                    int ASCII_value = (int)dic.Key.ToCharArray()[0];  //获取文件名第一个字符的ASCII码
                    int width = dic.Value.image.Width;
                    int height = dic.Value.image.Height;
                    int x = dic.Value.x;
                    int y = dic.Value.y;
                    string str = "char id=" + ASCII_value + "   x=" + x + "     y=" + y + "     width=" + width + "    height=" + height + "    xoffset=0     yoffset=0     xadvance=" + width + "    page=0  chnl=15";
                    file.WriteLine(str);
                }
            }
        }
    }
}
