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
    
    public partial class object_value
    {
        public int object_id { get; set; }
        public int value_id { get; set; }
    
        public virtual object_value object_value1 { get; set; }
        public virtual object_value object_value2 { get; set; }
        public virtual userObject userObject { get; set; }
        public virtual valuesShape valuesShape { get; set; }
    }
}
