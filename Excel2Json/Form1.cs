using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MyExcelTool;

namespace Excel2Json
{
    public partial class Excel2JSON工具 : Form
    {
        private MyExcelTool.Excel2Json excel;

        public Excel2JSON工具()
        {
            InitializeComponent();
            this.SingleOrMul.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void SelectExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "1|*.xls|2|*.xlsx*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = fileDialog.FileName;
                this.Tips.Text = "当前选择的文件是:";
                this.Tips.Text += filePath;
                ///打开excel文件
                List<string> sheetNames = GetSheetNames(filePath);
                this.Tips.Text += "\r\n该文件的表单有：";
                foreach (var item in sheetNames)
                {
                    this.Tips.Text += item + "、";
                }

                ///读取每个表单的内容，并写入JSON文件
                if (this.SingleOrMul.Checked)
                {
                    foreach (var item in sheetNames)
                    {
                        this.Tips.Text += string.Format("\r\n正在转换-->{0}<--表单", item);
                        excel.CreateJsonFile(item);
                    }
                }
                else
                {
                    excel.CreateJsonFile();
                }
                this.Tips.Text += "\r\n转换完成";
                excel.Close();
            }
        }
        /// <summary>
        /// 获取表单的名字
        /// </summary>
        private List<string> GetSheetNames(string path)
        {
            excel = new MyExcelTool.Excel2Json(path);
            return excel.GetExecelSheetNames();
        }
    }
}
