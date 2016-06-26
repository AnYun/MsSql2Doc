using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;

namespace MsSql2Doc.Core
{
    /// <summary>
    /// 資料庫資訊轉換
    /// </summary>
    public class DatabaseInfo
    {
        /// <summary>
        /// 連接字串
        /// </summary>
        private string _connectionString { get; set; }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="connectionString">連接字串</param>
        public DatabaseInfo(string connectionString)
        {
            this._connectionString = connectionString;
        }

        /// <summary>
        /// 轉為 Xml
        /// </summary>
        /// <returns></returns>
        public XmlDocument ToXml()
        {
            try
            {
                // Prepare XML document
                var xmlDoc = new XmlDocument();

                // Process database info
                xmlDoc.AppendChild(xmlDoc.CreateElement("database"));
                xmlDoc.DocumentElement.SetAttribute("dateGenerated", XmlConvert.ToString(DateTime.Now, XmlDateTimeSerializationMode.RoundtripKind));
                DatabaseHelper.RenderDatabase(this._connectionString,xmlDoc.DocumentElement);

                // Process schemas
                DatabaseHelper.RenderSchemas(this._connectionString,xmlDoc.DocumentElement);

                // Process top-level objects
                DatabaseHelper.RenderChildObjects(this._connectionString, xmlDoc.DocumentElement, 0);
                
                return xmlDoc;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
