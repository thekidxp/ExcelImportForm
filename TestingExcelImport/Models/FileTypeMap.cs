using System;
using System.Data;

namespace TestingExcelImport.Models
{
    class FileTypeMap : GrandCentral.Model.ModelBase
    {
        #region Privates

        private string _IFileType;
        private string _IDocType;
        private string _ANAFileType;
        private string _ANADocType;

        #endregion

        #region Properties
        public string IFileType 
        {
            get
            {
                return _IFileType;
            }
            set {
                _IFileType = value;
            }
        }
        public string IDocType
        {
            get
            {
                return _IDocType;
            }
            set
            {
                _IDocType = value;
            }
        }
        public string ANAFileType
        {
            get
            {
                return _ANAFileType;
            }
            set
            {
                _ANAFileType = value;
            }
        }
        public string ANADocType
        {
            get
            {
                return _ANADocType;
            }
            set
            {
                _ANADocType = value;
            }
        }
        #endregion

        #region Constructors
        public FileTypeMap()
        {
            _IFileType = string.Empty;
            _IDocType = string.Empty;
            _ANAFileType = string.Empty;
            _ANADocType = string.Empty;
        }
        public FileTypeMap(DataRow dr) : this()
        {
            InitFromDB(dr);
        }
        new public void InitFromDB(DataRow dr)
        {
            if (!(DBNull.Value == dr["IFileType"]))
                _IDocType = Convert.ToString(dr["IFileType"]);
            if (!(DBNull.Value == dr["IDocType"]))
                _IDocType = Convert.ToString(dr["IDocType"]);
            if (!(DBNull.Value == dr["ANAFileType"]))
                _IDocType = Convert.ToString(dr["ANAFileType"]);
            if (!(DBNull.Value == dr["ANADocType"]))
                _IDocType = Convert.ToString(dr["ANADocType"]); 
        }
        #endregion
    }
}