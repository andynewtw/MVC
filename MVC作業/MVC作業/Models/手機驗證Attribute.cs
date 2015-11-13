using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC作業.Models
{
    public class 手機驗證Attribute : DataTypeAttribute
    {
        public 手機驗證Attribute() : base(DataType.Text)
        {
            this.ErrorMessage = "請輸入正確的手機格式(09XX-XXXXXX)";
        }
        public override bool IsValid(object value)
        {
            string str = Convert.ToString(value);
            return System.Text.RegularExpressions.Regex.IsMatch(str, @"\d{4}-\d{6}");
        }
    }
}