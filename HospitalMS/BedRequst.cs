//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class BedRequst
    {
        public int ID { get; set; }
        public string PatientID { get; set; }
        public string PatientName { get; set; }
        public string PatientStatus { get; set; }
        public Nullable<System.DateTime> AssignFor { get; set; }
        public string Physician { get; set; }
    }
}
