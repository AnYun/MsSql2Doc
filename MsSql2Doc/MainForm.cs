using MsSql2Doc.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsSql2Doc
{
    public partial class MainForm : Form
    {
        const string TemplatePath = "Template";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGeneratDoc_Click(object sender, EventArgs e)
        {
            var connectionString = this.textConnectionString.Text;
            var fileName = this.textFileName.Text;
            var dbInfo = new DatabaseInfo(connectionString);
            var selectTemplate = this.listTemplate.SelectedItem.ToString();

            if (selectTemplate == "Xml")
            {
                dbInfo.ToXmlFile();
            }
            else
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), TemplatePath, selectTemplate);
                dbInfo.ToFileWithTemplate(path);
            }

            MessageBox.Show("匯出完成");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var tempList = GetTemplateList();
            this.listTemplate.DataSource = tempList;
        }
        /// <summary>
        /// 取得樣版清單
        /// </summary>
        /// <returns></returns>
        private List<string> GetTemplateList()
        {
            List<string> tempList = new List<string>();
            tempList.Add("Xml");

            if (Directory.Exists(TemplatePath))
            {
                DirectoryInfo d = new DirectoryInfo(TemplatePath);
                var fileList = d.GetFiles("*.xslt");
                foreach (var file in fileList)
                {
                    tempList.Add(file.Name);
                }
            }

            return tempList;
        }
    }
}
