//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MASTER_WILAYAH
    {
        public decimal WILAYAH_ID { get; set; }
        public Nullable<decimal> WILAYAH_PARENT_ID { get; set; }
        public string WILAYAH_KODE { get; set; }
        public string WILAYAH_NAMA { get; set; }
        public Nullable<decimal> WILAYAH_CREATE_BY { get; set; }
        public Nullable<System.DateTime> WILAYAH_CREATE_DATE { get; set; }
        public Nullable<decimal> WILAYAH_UPDATE_BY { get; set; }
        public Nullable<System.DateTime> WILAYAH_UPDATE_DATE { get; set; }
        public Nullable<decimal> WILAYAH_STATUS { get; set; }
        public string WILAYAH_LOG_CODE { get; set; }
    }
}