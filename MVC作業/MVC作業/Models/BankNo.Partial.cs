namespace MVC作業.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(BankNoMetaData))]
    public partial class BankNo
    {
    }
    
    public partial class BankNoMetaData
    {
        [Required]
        public int id { get; set; }
        
        [StringLength(3, ErrorMessage="欄位長度不得大於 3 個字元")]
        [Required]
        public string 銀行代號 { get; set; }
        
        [StringLength(4, ErrorMessage="欄位長度不得大於 4 個字元")]
        public string 分行代號 { get; set; }
        [Required]
        public string 分行名稱 { get; set; }
    }
}
