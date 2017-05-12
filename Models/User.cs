using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProj_TreeView.Models
{

    public class User
    {
        [Key]
        public int UserNo { get; set; }
        
        [Required(ErrorMessage ="사용자 이름을 입력해주세요")]
        public  string UserName { get; set; }

        [Required(ErrorMessage ="사용자 ID를 입력해주세요.")]
        public String UserId { get; set; }

        [Required(ErrorMessage ="패스워드를 입력해주세요.")]
        public string UserPassword { get; set; }

        public DateTime RegDate { get; set; }
    }


}
