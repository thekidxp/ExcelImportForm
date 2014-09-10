using Microsoft.Office.Interop.Excel;
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using TestingExcelImport.Models;

namespace CustomImport
{
    class ImportData
    {
        public void ImportDataFromExcel(string FilePath)
        {
            Application Excel = new Application();
            Workbook WrkBook = Excel.Workbooks.Open(FilePath);
            try
            {
                    Worksheet WrkSheet = WrkBook.Sheets[1];
                    Range r = WrkSheet.UsedRange;
                    object[,] arr = r.Value[XlRangeValueDataType.xlRangeValueDefault];

                    if (arr != null)
                    {
                        IterateThroughExcelSheet(arr);
                    }                
            }
            catch (Exception ex)
            {

            }
            finally
            {
                WrkBook.Close();
            }
        }

        public void ImportDataFromNotePad(string filepath)
        {
            string text = System.IO.File.ReadAllText(filepath);
            System.Windows.Forms.MessageBox.Show(text);

        }

        public void ClearFile(string filepath)
        {
            //File.WriteAllText(filepath, String.Empty);
            using (FileStream fs = File.Create(filepath))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("filename\tfunction name\tHR model attribute\r\n");
                fs.Write(info, 0, info.Length);
            }
        }

        //JCM, PL 09/10/2014: we're in ur git, forkin' ur repos.
        public void WalkDirectories(DirectoryInfo root, string logfilepath)
        {
            Regex getSubs = new Regex(@"(Sub|Function) ([\w\W]*?)(End Sub|End Function)");
            Regex getFuncName = new Regex(@"(Sub|Function) (?<name>[\w]*)");
            Regex getHRAttributes = new Regex(@"UserModel\.HR\.([^ ^.^)^,^}^\n^\r]*)");

            DirectoryInfo[] subDirectories = root.GetDirectories();
            FileInfo[] files = root.GetFiles("*.vb");

            foreach (var file in files)
            {
                string filepath = file.Directory.ToString() + "\\" + file.ToString();
                string text = File.ReadAllText(filepath);
                MatchCollection matches = getSubs.Matches(text);
                foreach (Match theMatch in matches)
                {
                    string thefunc = theMatch.Value.ToString();
                    Match funcMatch = getFuncName.Match(thefunc);
                    string funcName = funcMatch.Groups[2].ToString();

                    MatchCollection HRAtrributes = getHRAttributes.Matches(thefunc);
                    foreach (Match attributeMatch in HRAtrributes)
                    {
                        string attribute = attributeMatch.Groups[1].ToString();
                        File.AppendAllText(logfilepath, file.ToString() + "\t" + funcName + "\t" + attribute + "\r\n");
                    }

                }
            }
            foreach (var subDir in subDirectories)
            {
                WalkDirectories(subDir, logfilepath);
            }
        }


        private static void IterateThroughExcelSheet(object[,] arr)
        {
            int bound0 = arr.GetUpperBound(0);

            for (int j = 2; j <= bound0; j++)
            {
                FileTypeMap FTRow = new FileTypeMap();

                for (int x = 1; x < 5; x++)
                {
                    switch (x)
                    {
                        case 1: FTRow.IFileType = (string)arr[j, 1]; break;
                        case 2: FTRow.IDocType = (string)arr[j, 2]; break;
                        case 3: FTRow.ANAFileType = (string)arr[j, 3]; break;
                        case 4: FTRow.ANADocType = (string)arr[j, 4]; break;
                    }
                }
                System.Windows.Forms.MessageBox.Show(FTRow.IFileType + " " + FTRow.IDocType + " " + FTRow.ANAFileType + " " + FTRow.ANADocType);
                //If I do more with this I'd like to save the file from here to the new docmapping table I'd like to make on grandcentral for the imports. For now I think this is enough of a proof of concept.
            }
        }    
    }
}
