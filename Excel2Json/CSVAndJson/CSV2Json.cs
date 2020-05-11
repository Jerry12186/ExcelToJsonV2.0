using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel2Json.CSVAndJson
{
    class CSV2Json
    {
        public void WriteToJson(string path)
        {

        }

        private DataTable GetCSVContent(string path)
        {
            DataTable myDT = new DataTable();
            int colCount = 0;
            bool flag = true;
            DataColumn myDC;
            DataRow myDR;
            string strLine;
            string[] arrayLine;
            try
            {
                StreamReader reader = new StreamReader(path, Encoding.Default);
                while ((strLine = reader.ReadLine()) != null)
                {
                    arrayLine = strLine.Split(',');
                    if (flag)
                    {
                        flag = false;
                        colCount = arrayLine.Length;
                        for (int i = 0; i < arrayLine.Length; i++)
                        {
                            myDC = new DataColumn(arrayLine[i]);
                            myDT.Columns.Add(myDC);
                        }
                    }

                    myDR = myDT.NewRow();
                    for (int i = 0; i < colCount; i++)
                    {
                        myDR[i] = arrayLine[i];
                    }
                    myDT.Rows.Add(myDR);
                }
                reader.Close();
                return myDT;
            }
            catch (Exception)
            {
                throw new Exception("要转换的文件可能在编辑，请关闭后重试");
            }

        }
    }
}
