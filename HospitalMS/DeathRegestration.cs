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
    
    public partial class DeathRegestration
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public string PatientID { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public Nullable<int> Age { get; set; }
        public string PhesetianName { get; set; }
        public string Department { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string DeathCase { get; set; }
    }
}
