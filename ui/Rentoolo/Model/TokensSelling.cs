//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentoolo.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TokensSelling
    {
        public int Id { get; set; }
        public long Count { get; set; }
        public System.Guid UserId { get; set; }
        public double CostOneToken { get; set; }
        public double FullCost { get; set; }
        public System.DateTime WhenDate { get; set; }
    }
}
