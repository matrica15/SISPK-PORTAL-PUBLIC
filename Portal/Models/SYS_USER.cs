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
    
    public partial class SYS_USER
    {
        public decimal USER_ID { get; set; }
        public Nullable<decimal> USER_ACCESS_ID { get; set; }
        public string USER_NAME { get; set; }
        public string USER_PASSWORD { get; set; }
        public Nullable<decimal> USER_IS_ONLINE { get; set; }
        public Nullable<System.DateTime> USER_LAST_LOGIN { get; set; }
        public Nullable<decimal> USER_CREATE_BY { get; set; }
        public Nullable<System.DateTime> USER_CREATE_DATE { get; set; }
        public Nullable<decimal> USER_UPDATE_BY { get; set; }
        public Nullable<System.DateTime> USER_UPDATE_DATE { get; set; }
        public Nullable<decimal> USER_STATUS { get; set; }
        public string USER_LOG_CODE { get; set; }
        public Nullable<short> USER_TYPE_ID { get; set; }
        public Nullable<decimal> USER_REF_ID { get; set; }
    }
}
