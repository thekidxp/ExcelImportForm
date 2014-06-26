using Microsoft.Office.Interop.Excel;
using System;
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
