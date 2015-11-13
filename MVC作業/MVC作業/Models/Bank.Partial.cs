namespace MVC作業.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(BankMetaData))]
    public partial class Bank
    {
    }
    
    public partial class BankMetaData
    {
        
        [StringLength(3, ErrorMessage="欄位長度不得大於 3 個字元")]
        [Required]
        public string 銀行代號 { get; set; }
        
        [StringLength(255, ErrorMessage="欄位長度不得大於 255 個字元")]
        public string 銀行名稱 { get; set; }
    }
}
