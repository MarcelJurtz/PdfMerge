namespace PdfMerge.Models
{
    public class Chapter
    {
        public string FileName { get; set; }
        public string Path { get; set; }
        public int Position { get; set; }

        public static int CompareChaptersByPosition(Chapter x, Chapter y)
        {
            if (x == null)
            {
                if (y == null) return 0;
                else return -1; 
            }
            else
            {
                if (y == null) return 1;
                else return x.Position.CompareTo(y.Position);
            }
        }
    }
}
