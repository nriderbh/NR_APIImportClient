using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRApiClient.Models
{
    public class JSONModel
    {
        public JSONModel()
        {
            this.ImportContext = new _ImportContext();
            this.MetaData = new List<_MetaData>();
            this.CaseData = new List<_CaseData>();
        }

        public ICollection<_CaseData> CaseData { get; set; }
        public ICollection<_MetaData> MetaData { get; set; }
        public _ImportContext ImportContext { get; set; }

        public class _MetaData
        {
            public class AnswerAlternative
            {
                public string Code { get; set; }
                public string Text { get; set; }
            }
            public string Code { get; set; }
            public string Text { get; set; }
            public string Type { get; set; }
            public ICollection<AnswerAlternative> AnswerAlternatives { get; set; }
        }

        public class _CaseData
        {
            public string RespondentID { get; set; }
            public string InterviewDate { get; set; }
            public string Weight { get; set; }
            public string Hfilter { get; set; }
            public string BgSubscrType { get; set; }
            public string BgAgegroup { get; set; }
            public string BgGender { get; set; }
            public string BgIncome { get; set; }
            public string[] BrAwaToM { get; set; }
            public string[] AwaAdRecToM { get; set; }
            public string[] Cons1 { get; set; }
            public string[] Cons2 { get; set; }
            public string[] Cons3 { get; set; }
            public string[] Cons4 { get; set; }
            public string[] Cons5 { get; set; }
            public string[] Cons6 { get; set; }
            public string[] Cons7 { get; set; }
            public string[] Cons8 { get; set; }
            public string[] Cons9 { get; set; }
            public string[] Cons10 { get; set; }

        }
        public class _ImportContext
        {
            public int ImportType { get; set; }
            public int ImportSource { get; set; }
            public bool StackedData { get; set; }
            public bool OverwriteMetadata { get; set; }
            public bool UpdateData { get; set; }
            public int ActiveMappingId { get; set; }
            public string DateFormat { get; set; }
            public string ResponseDateVariable { get; set; }

            public _ImportContext() 
            {
                this.ImportType = 2;
                this.ImportSource = 6;
                this.StackedData = false;
                this.OverwriteMetadata = true;
                this.UpdateData = false;
                this.ActiveMappingId = 0;
                this.DateFormat = "yyyy-M-d";
                this.ResponseDateVariable = "InterviewDate";
                
            }
        }

    }
}
