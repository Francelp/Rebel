//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RebellionDataBaseModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class SpecialOfferProduct
    {
        public SpecialOfferProduct()
        {
            this.SalesOrderDetails = new HashSet<SalesOrderDetail>();
        }
    
        public int SpecialOfferID { get; set; }
        public int ProductID { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
        public virtual SpecialOffer SpecialOffer { get; set; }
    }
}
