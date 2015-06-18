using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;

namespace ElevenDEMO.Vendor
{
    [Table("MWVendor")]
    public class TblVendor : Entity//<string>
    {
        [Key]
        [MaxLength(20)]
        public virtual string VendorCode { get; set; }

        [MaxLength(45)]
        public virtual string Vendor { get; set; }

        [MaxLength(128)]
        public virtual string Address { get; set; }
    }
}
