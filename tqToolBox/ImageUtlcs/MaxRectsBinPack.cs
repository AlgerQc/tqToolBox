using System;
using System.Collections;
using System.Drawing;
using tqToolBox.Generator;

namespace tqToolBox.ImageUtlcs
{
    public class SpliceRect
    {
        public int x;
        public int y;
        public int width;
        public int height;
    }

    class MaxRectsBinPack
    {
        private static int binWidth = 0;
        private static int binHeight = 0;
        private static ArrayList usedRectangles = new ArrayList();//已经添加的矩形
        private static ArrayList freeRectangles = new ArrayList();//剩余面积
        public static void init(int width, int height)
        {
            binHeight = height;
            binWidth = width;
            SpliceRect rect = new SpliceRect();
            rect.x = 0;
            rect.y = 0;
            rect.width = width;
            rect.height = height;

            usedRectangles.Clear();
            freeRectangles.Clear();

            freeRectangles.Add(rect);
        }

        public static void ClearBinPack()
        {
            usedRectangles.Clear();
            freeRectangles.Clear();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public static Size Insert(int width, int height)
        {
            SpliceRect newNode;
            Size psize = new Size();
            //TODO 暂时只完成一种算法
            //newNode = FindPositionForNewNodeBestShortSideFit(width, height);
            newNode = FindPositionForNewNodeBestLongSideFit(width, height);
            //newNode = FindPositionForNewNodeContactPoint(width, height);

            if (newNode.height == 0)
                return psize;

            int numRectanglesToProcess = freeRectangles.Count;

            for (int i = 0; i < numRectanglesToProcess; ++i)
            {
                SpliceRect freeNode = (SpliceRect)freeRectangles[i];
                if (SplitFreeNode(freeNode, newNode))
                {
                    freeRectangles.RemoveAt(i);
                    --i;
                    --numRectanglesToProcess;
                }
            }

            PruneFreeList();
            usedRectangles.Add(newNode);
            psize.Width = newNode.x;
            psize.Height = newNode.y;
            return psize;
        }

        private static SpliceRect FindPositionForNewNodeBestShortSideFit(int width, int height)
        {
            SpliceRect bestNode = new SpliceRect();
            bool is_can_store = false;//能否放下

            int bestShortSideFit = System.Int32.MaxValue;
            int bestLongSideFit = System.Int32.MaxValue;
            for (int i = 0; i < freeRectangles.Count; ++i)
            {
                SpliceRect freeRect = (SpliceRect)freeRectangles[i];
                //判断剩余面积能否放下当前矩形
                if (freeRect.width >= width && freeRect.height >= height)
                {
                    int leftoverHoriz = Math.Abs(freeRect.width - width);//水平方向剩余
                    int leftoverVert = Math.Abs(freeRect.height - height);//垂直方向剩余

                    //用于存储当前未填充区域剩余的量   
                    int shortSideFit = Math.Min(leftoverHoriz, leftoverVert);
                    int longSideFit = Math.Max(leftoverHoriz, leftoverVert);

                    //当为填充区域剩余的面积小于上个区域时将散图放到此区域
                    if (shortSideFit < bestShortSideFit || (shortSideFit == bestShortSideFit && longSideFit < bestLongSideFit))
                    {
                        bestNode.x = freeRect.x;
                        bestNode.y = freeRect.y;
                        bestNode.width = width;
                        bestNode.height = height;
                        bestShortSideFit = shortSideFit;
                        bestLongSideFit = longSideFit;
                        is_can_store = true;
                    }
                }
            }

            if (!is_can_store)
            {
                //放不下多余的散图，扩充大图面积
                for (int i = 0; i < freeRectangles.Count; ++i)
                {
                    SpliceRect freeRect = (SpliceRect)freeRectangles[i];
                    if (freeRect.x + freeRect.width >= binWidth)
                    {
                        freeRect.width += width;
                    }
                    if (freeRect.y + freeRect.height >= binHeight)
                    {
                        freeRect.height += height;
                    }
                }
                binWidth += width;
                binHeight += height;
                return FindPositionForNewNodeBestShortSideFit(width, height);
            }
            return bestNode;
        }

        private static SpliceRect FindPositionForNewNodeBestLongSideFit(int width, int height, int bestShortSideFit = Int32.MaxValue, int bestLongSideFit = Int32.MaxValue)
        {
            SpliceRect bestNode = new SpliceRect();
            bestShortSideFit = Int32.MaxValue;
            bestLongSideFit = Int32.MaxValue;
            bool is_can_store = false;//能否放下

            for (int i = 0; i < freeRectangles.Count; ++i)
            {
                SpliceRect freeRect = (SpliceRect)freeRectangles[i];
                if (freeRect.width >= width && freeRect.height >= height)
                {
                    int leftoverHoriz = Math.Abs(freeRect.width - width);
                    int leftoverVert = Math.Abs(freeRect.height - height);
                    int shortSideFit = Math.Min(leftoverHoriz, leftoverVert);
                    int longSideFit = Math.Max(leftoverHoriz, leftoverVert);

                    if (longSideFit < bestLongSideFit || (longSideFit == bestLongSideFit && shortSideFit < bestShortSideFit))
                    {
                        bestNode.x = freeRect.x;
                        bestNode.y = freeRect.y;
                        bestNode.width = width;
                        bestNode.height = height;
                        bestShortSideFit = shortSideFit;
                        bestLongSideFit = longSideFit;
                        is_can_store = true;
                    }
                }
            }
            if (!is_can_store)
            {
                //放不下多余的散图，扩充大图面积
                for (int i = 0; i < freeRectangles.Count; ++i)
                {
                    SpliceRect freeRect = (SpliceRect)freeRectangles[i];
                    if (freeRect.x + freeRect.width >= binWidth)
                    {
                        freeRect.width += width;
                    }
                    if (freeRect.y + freeRect.height >= binHeight)
                    {
                        freeRect.height += height;
                    }
                }
                binWidth += width;
                binHeight += height;
                return FindPositionForNewNodeBestLongSideFit(width, height);
            }
            return bestNode;
        }

        private static SpliceRect FindPositionForNewNodeContactPoint(int width, int height, int bestContactScore = Int32.MaxValue)
        {
            SpliceRect bestNode = new SpliceRect();
            bestContactScore = -1;
            for (int i = 0; i < freeRectangles.Count; ++i)
            {
                SpliceRect freeRect = (SpliceRect)freeRectangles[i];
                if (freeRect.width >= width && freeRect.height >= height)
                {
                    int score = ContactPointScoreNode(freeRect.x, freeRect.y, width, height);
                    if (score > bestContactScore)
                    {
                        bestNode.x = freeRect.x;
                        bestNode.y = freeRect.y;
                        bestNode.width = width;
                        bestNode.height = height;
                        bestContactScore = score;
                    }
                }
            }
            return bestNode;
        }

        /// Returns 0 if the two intervals i1 and i2 are disjoint, or the length of their overlap otherwise.
        private static int CommonIntervalLength(int i1start, int i1end, int i2start, int i2end)
        {
            if (i1end < i2start || i2end < i1start)
                return 0;
            return Math.Min(i1end, i2end) - Math.Max(i1start, i2start);
        }

        private static int ContactPointScoreNode(int x, int y, int width, int height)
        {
            int score = 0;
            if (x == 0 || x + width == binWidth)
                score += height;
            if (y == 0 || y + height == binHeight)
                score += width;

            for (int i = 0; i < usedRectangles.Count; i++)
            {
                SpliceRect userRect = (SpliceRect)usedRectangles[i];
                if (userRect.x == x + width || userRect.x + userRect.width == x)
                    score += CommonIntervalLength(userRect.y, userRect.y + userRect.height, y, y + height);
                if (userRect.y == y + height || userRect.y + userRect.height == y)
                    score += CommonIntervalLength(userRect.x, userRect.x + userRect.width, x, x + width);
            }
            return score;
        }

        private static bool SplitFreeNode(SpliceRect freeNode, SpliceRect usedNode)
        {
            //判断散图是否在该未填充区域内
            if (usedNode.x >= freeNode.x + freeNode.width || usedNode.x + usedNode.width <= freeNode.x ||
               usedNode.y >= freeNode.y + freeNode.height || usedNode.y + usedNode.height <= freeNode.y)
                return false;
            //判断x轴方向是否在矩形内
            if (usedNode.x < freeNode.x + freeNode.width && usedNode.x + usedNode.width > freeNode.x)
            {
                //判断为填充区域下方能否切割
                if (usedNode.y > freeNode.y && usedNode.y < freeNode.y + freeNode.height)
                {
                    SpliceRect newNode = Utlcs.Clone(freeNode);

                    newNode.height = usedNode.y - newNode.y;
                    freeRectangles.Add(newNode);
                }

                //判断为填充区域上方能否切割
                if (usedNode.y + usedNode.height < freeNode.y + freeNode.height)
                {

                    SpliceRect newNode = Utlcs.Clone(freeNode);

                    newNode.y = usedNode.y + usedNode.height;
                    newNode.height = freeNode.y + freeNode.height - (usedNode.y + usedNode.height);
                    freeRectangles.Add(newNode);
                }
            }
            if (usedNode.y < freeNode.y + freeNode.height && usedNode.y + usedNode.height > freeNode.y)
            {
                // New node at the left side of the used node.
                if (usedNode.x > freeNode.x && usedNode.x < freeNode.x + freeNode.width)
                {

                    SpliceRect newNode = Utlcs.Clone(freeNode);

                    newNode.width = usedNode.x - newNode.x;
                    freeRectangles.Add(newNode);
                }
                // New node at the right side of the used node.
                if (usedNode.x + usedNode.width < freeNode.x + freeNode.width)
                {
                    SpliceRect newNode = Utlcs.Clone(freeNode);

                    newNode.x = usedNode.x + usedNode.width;
                    newNode.width = freeNode.x + freeNode.width - (usedNode.x + usedNode.width);
                    freeRectangles.Add(newNode);
                }
            }
            return true;
        }

        private static void PruneFreeList()
        {
            for (int i = 0; i < freeRectangles.Count; ++i)
            {
                for (int j = i + 1; j < freeRectangles.Count; ++j)
                {
                    if (IsContainedIn((SpliceRect)freeRectangles[i], (SpliceRect)freeRectangles[j]))
                    {
                        freeRectangles.RemoveAt(i);
                        --i;
                        break;
                    }
                    if (IsContainedIn((SpliceRect)freeRectangles[j], (SpliceRect)freeRectangles[i]))
                    {
                        freeRectangles.RemoveAt(j);
                        --j;
                    }
                }
            }
        }
        //判断两个区域是否有重合
        private static bool IsContainedIn(SpliceRect a, SpliceRect b)
        {
            return a.x >= b.x && a.y >= b.y && a.x + a.width <= b.x + b.width && a.y + a.height <= b.y + b.height;
        }
        //获取最小能装下的矩形边长
        public static int MinRectangle(int setArea)
        {
            int count = 5;
            int sidelength = 0;
            while (true)
            {
                sidelength = (int)Math.Pow(2, count);
                if (sidelength * sidelength >= setArea)
                    break;
                count++;
            }
            init(sidelength, sidelength);
            return sidelength;
        }
    }
}
