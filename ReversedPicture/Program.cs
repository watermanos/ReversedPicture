using System;
using System.IO;
using System.Linq;
using HtmlAgilityPack;

class Program
{
    [STAThread] // run files
    static void Main()
    {
        // create open file dialog
        OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Filter = "HTML files (*.html)|*.html",
            Title = "choose file HTML"
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string inputFilePath = openFileDialog.FileName;

            // create folder browser
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Choose Folder"
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string outputFolder = folderBrowserDialog.SelectedPath;
                string outputFilePath = Path.Combine(outputFolder, "reversed_pictures.html");

                // loaad the input file
                ReverseHtmlImageOrder(inputFilePath, outputFilePath);
                Console.WriteLine("The file created: " + outputFilePath);
            }
            else
            {
                Console.WriteLine("Don't choose Folder");
            }
        }
        else
        {
            Console.WriteLine("Dont choose file input");
        }
    }

    static void ReverseHtmlImageOrder(string inputFilePath, string outputFilePath)
    {
        HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
        htmlDoc.Load(inputFilePath);


        // find `owl-carousel`
        var carouselDiv = htmlDoc.DocumentNode.SelectSingleNode("//div[contains(@class, 'owl-carousel')]");

        if (carouselDiv != null)
        {
            // reverse 
            var items = carouselDiv.SelectNodes(".//div[contains(@class, 'item')]").ToList();
            carouselDiv.RemoveAllChildren();
            foreach (var item in items.AsEnumerable().Reverse())
            {
                carouselDiv.AppendChild(item);
            }

            // save
            htmlDoc.Save(outputFilePath);
        }
        else
        {
            Console.WriteLine("Dont find div class");
        }
    }
}
