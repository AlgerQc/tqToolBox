using System.Drawing;

namespace tqToolBox.ImageUtlcs
{
    class Rect
    {
        public int x;
        public int y;
        public Image image;

        public void SetImage(Image image)
        {
            this.image = image;
            this.x = 0;
            this.y = 0;
        }
    }
}
