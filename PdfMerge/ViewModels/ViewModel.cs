using PdfMerge.Models;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Collections.Generic;
using System.Linq;

namespace PdfMerge.ViewModels
{
    public class ViewModel
    {

        private List<Chapter> _chapters;
        public List<Chapter> Chapters { get { return _chapters; } }

        public ViewModel()
        {
            _chapters = new List<Chapter>();
        }

        public void Reset()
        {
            Chapters.Clear();
        }

        public void AddChapterByFileName(string filename)
        {
            Chapter c = new Chapter();
            var parts = filename.Split('\\');
            c.FileName = parts[parts.Length - 1];
            c.Path = filename;
            c.Position = _chapters.Count + 1;
            _chapters.Add(c);
        }

        public void AddChaptersByFileName(string[] filenames)
        {
            foreach (var filename in filenames)
                AddChapterByFileName(filename);
        }

        public void SwapPositions(Chapter chapter, int change)
        {
            if (chapter == null)
                return;

            var swap = _chapters.FirstOrDefault(i => i.Position == chapter.Position + change);
            if (swap == null || swap == chapter)
                return;

            int temp = swap.Position;
            swap.Position = chapter.Position;
            chapter.Position = temp;

            Chapters.Sort(Chapter.CompareChaptersByPosition);
        }

        public void RemoveChapter(Chapter chapter)
        {
            if (!Chapters.Contains(chapter))
                return;

            Chapters.Remove(chapter);
            Chapters.Sort(Chapter.CompareChaptersByPosition);

            for (int i = 0; i < Chapters.Count; i++)
            {
                Chapters[i].Position = i + 1;
            }
        }

        public void Export(string filename)
        {
            List<PdfDocument> docs = new List<PdfDocument>();
            foreach (var item in _chapters)
            {
                docs.Add(PdfReader.Open(item.Path, PdfDocumentOpenMode.Import));
            }

            using (PdfDocument outPdf = new PdfDocument())
            {
                foreach (var chapter in docs)
                    CopyPages(chapter, outPdf);

                outPdf.Save(filename);
            }

            void CopyPages(PdfDocument from, PdfDocument to)
            {
                for (int i = 0; i < from.PageCount; i++)
                {
                    to.AddPage(from.Pages[i]);
                }
            }

            foreach (var item in docs)
            {
                item.Dispose();
            }
        }
    }
}
