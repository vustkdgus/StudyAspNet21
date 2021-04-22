using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortpolio.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "이메일을 입력하세요")]
        [DataType(DataType.Text)]
        [StringLength(125)]
        public string Email { get; set; }
        [Required(ErrorMessage = "패스워드를 입력하세요")]
        [DataType(DataType.Text)]
        [StringLength(20)]
        public string Password { get; set; }
        public string Grade { get; set; }
    }
}
