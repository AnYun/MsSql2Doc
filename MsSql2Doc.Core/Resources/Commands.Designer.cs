﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsSql2Doc.Core.Resources {
    using System;
    
    
    /// <summary>
    ///   用於查詢當地語系化字串等的強類型資源類別。
    /// </summary>
    // 這個類別是自動產生的，是利用 StronglyTypedResourceBuilder
    // 類別透過 ResGen 或 Visual Studio 這類工具。
    // 若要加入或移除成員，請編輯您的 .ResX 檔，然後重新執行 ResGen
    // (利用 /str 選項)，或重建您的 VS 專案。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Commands {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Commands() {
        }
        
        /// <summary>
        ///   傳回這個類別使用的快取的 ResourceManager 執行個體。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MsSql2Doc.Core.Resources.Commands", typeof(Commands).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   覆寫目前執行緒的 CurrentUICulture 屬性，對象是所有
        ///   使用這個強類型資源類別的資源查閱。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查詢類似 SELECT 
        ///	C.name														AS [name],
        ///	TYPE_NAME(C.system_type_id)									AS [type],
        ///	C.max_length												AS [length],
        ///	C.precision													AS [precision], 
        ///	C.scale														AS [scale], 
        ///	C.is_nullable												AS [nullable], 
        ///	C.is_identity												AS [identity], 
        ///	C.is_computed												AS [computed], 
        ///	P.value														AS [description],
        ///	PK.object_id												AS [primaryKey:refId],
        ///	FK.constraint_object_id										AS [foreignKey:refId],
        ///	FK.referenced_object_id		 [字串的其餘部分已遭截斷]&quot;; 的當地語系化字串。
        /// </summary>
        public static string GetColumns {
            get {
                return ResourceManager.GetString("GetColumns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 SELECT 
        ///	name		AS [name], 
        ///	create_date	AS [dateCreated]
        ///FROM
        ///	sys.databases
        ///WHERE 
        ///	database_id = DB_ID() 的當地語系化字串。
        /// </summary>
        public static string GetDatabase {
            get {
                return ResourceManager.GetString("GetDatabase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 SELECT
        ///	O.object_id		AS [id], 
        ///	S.name			AS [schema], 
        ///	O.name			AS [name], 
        ///	O.type_desc		AS [type], 
        ///	O.create_date	AS [dateCreated], 
        ///	O.modify_date	AS [dateModified], 
        ///	P.value			AS [description]
        ///FROM 
        ///	sys.objects AS O
        ///	LEFT JOIN sys.schemas AS S on S.schema_id = o.schema_id
        ///	LEFT JOIN sys.extended_properties AS P ON P.major_id = O.object_id AND P.minor_id = 0 and P.name = &apos;MS_Description&apos; 
        ///WHERE 
        ///	is_ms_shipped = 0 
        ///	AND parent_object_id = @parent_object_id
        ///
        ///	
        ///
        /// 的當地語系化字串。
        /// </summary>
        public static string GetObjects {
            get {
                return ResourceManager.GetString("GetObjects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 SELECT DISTINCT
        ///	S.name	AS [name]
        ///FROM 
        ///	sys.schemas AS S 
        ///	LEFT JOIN sys.objects AS O ON S.schema_id = O.schema_id
        ///WHERE 
        ///	O.is_ms_shipped = 0 
        ///	AND O.parent_object_id=0
        ///ORDER BY S.name 的當地語系化字串。
        /// </summary>
        public static string GetSchemas {
            get {
                return ResourceManager.GetString("GetSchemas", resourceCulture);
            }
        }
    }
}
