//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class valuesShape
    {
        public int value_id { get; set; }
        public Nullable<int> class_id { get; set; }
        public Nullable<int> variable_id { get; set; }
        public string value_name { get; set; }
        public string value_image { get; set; }
    
        public virtual classes classes { get; set; }
        public virtual variable variable { get; set; }
    }
}
