//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SRMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class lineworkinfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lineworkinfo()
        {
            this.sampletime = "0";
            this.totalnum = 0;
            this.finishnum = 0;
            this.errornum = 0;
            this.workdetail = new HashSet<workdetail>();
        }
    
        public int Id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string sampletime { get; set; }
        public int totalnum { get; set; }
        public int finishnum { get; set; }
        public int errornum { get; set; }
        public System.DateTime bulidtime { get; set; }
        public int lineinfoSetId { get; set; }
        public int productinfoSetId { get; set; }
    
        public virtual lineinfoSet lineinfoSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<workdetail> workdetail { get; set; }
        public virtual productinfoSet productinfoSet { get; set; }
    }
}
