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
    
    public partial class family
    {
        public int familyID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public string FamilyHistory { get; set; }
        public Nullable<bool> Normal { get; set; }
        public Nullable<bool> Abnormal { get; set; }
        public string Remarks { get; set; }
    }
}
