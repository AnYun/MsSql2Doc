using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MsSql2Doc.Core
{
    /// <summary>
    /// 存取 DB 的 Helper
    /// Some Code From:http://sqldbdoc.codeplex.com/
    /// </summary>
    internal static class DatabaseHelper
    {
        /// <summary>
        /// 取得資料庫庫資訊成 DataTable
        /// </summary>
        /// <param name="command">SQl 指令</param>
        /// <param name="connectionString">連接字串</param>
        /// <param name="parameter">參數</param>
        /// <param name="parameterValue">參數值</param>
        /// <returns></returns>
        private static DataTable GetDataTable(string command, string connectionString, string parameter = null, int? parameterValue = null)
        {
            var dt = new DataTable();
            using (var da = new SqlDataAdapter(command, connectionString))
            {
                if (parameter != null)
                {
                    da.SelectCommand.Parameters.Add(parameter, SqlDbType.Int).Value = parameterValue.Value;
                }
                da.Fill(dt);
            }
            return dt;
        }

        #region RenderXml
        /// <summary>
        /// RenderSchemas
        /// </summary>
        /// <param name="connectionString">連接字串</param>
        /// <param name="parentElement"></param>
        internal static void RenderSchemas(string connectionString, XmlElement parentElement)
        {
            var dt = GetDataTable(Resources.Commands.GetSchemas, connectionString);

            // Populate schemas
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var e = parentElement.AppendChild(parentElement.OwnerDocument.CreateElement("schema")) as XmlElement;
                e.SetAttribute("name", (string)dt.Rows[i][0]);
            }
        }
        /// <summary>
        /// RenderDatabase
        /// </summary>
        /// <param name="connectionString">連接字串</param>
        /// <param name="parentElement"></param>
        internal static void RenderDatabase(string connectionString, XmlElement parentElement)
        {
            // Get current database info
            var dt = GetDataTable(Resources.Commands.GetDatabase, connectionString);

            // Display database info
            foreach (DataColumn col in dt.Columns)
            {
                var value = dt.Rows[0].ToXmlString(col);
                if (!string.IsNullOrWhiteSpace(value)) parentElement.SetAttribute(col.ColumnName, value);
            }
        }
        /// <summary>
        /// RenderChildObjects
        /// </summary>
        /// <param name="connectionString">連接字串</param>
        /// <param name="parentElement"></param>
        /// <param name="parentObjectId"></param>
        internal static void RenderChildObjects(string connectionString, XmlElement parentElement, int parentObjectId)
        {
            // Get all database objects with given parent
            var dt = GetDataTable(Resources.Commands.GetObjects, connectionString, "@parent_object_id", parentObjectId);

            // Process all objects
            foreach (DataRow row in dt.Rows)
            {
                var objectId = (int)row["id"];

                // Create object element
                var e = parentElement.AppendChild(parentElement.OwnerDocument.CreateElement("object")) as XmlElement;
                foreach (DataColumn col in dt.Columns)
                {
                    var value = row.ToXmlString(col);
                    if (!string.IsNullOrWhiteSpace(value)) e.SetAttribute(col.ColumnName, value);
                }

                // Process columns
                RenderColumns(connectionString, e, objectId);

                // Process child objects
                RenderChildObjects(connectionString, e, objectId);
            }
        }
        /// <summary>
        /// RenderColumns
        /// </summary>
        /// <param name="connectionString">連接字串</param>
        /// <param name="parentElement"></param>
        /// <param name="objectId"></param>
        internal static void RenderColumns(string connectionString, XmlElement parentElement, int objectId)
        {
            // Get all columns object with given parent
            var dt = GetDataTable(Resources.Commands.GetColumns, connectionString, "@object_id", objectId);

            // Process all columns
            foreach (DataRow row in dt.Rows)
            {
                // Create object element
                var e = parentElement.AppendChild(parentElement.OwnerDocument.CreateElement("column")) as XmlElement;
                foreach (DataColumn col in dt.Columns)
                {
                    var value = row.ToXmlString(col);
                    if (string.IsNullOrWhiteSpace(value)) continue;

                    if (col.ColumnName.IndexOf(':') == -1)
                    {
                        // Plain attribute
                        e.SetAttribute(col.ColumnName, value);
                    }
                    else
                    {
                        // Nested element/attribute
                        var names = col.ColumnName.Split(':');
                        var se = (e.SelectSingleNode(names[0]) ?? e.AppendChild(e.OwnerDocument.CreateElement(names[0]))) as XmlElement;
                        se.SetAttribute(names[1], value);
                    }
                }
            }
        }
        #endregion RenderXml
    }
}