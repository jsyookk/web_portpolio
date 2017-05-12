using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProj_TreeView.ViewModel
{
    public class UserView
    {
        
        
        [Required(ErrorMessage = "사용자 ID를 입력해주세요.")]
        public String UserId { get; set; }

        [Required(ErrorMessage = "패스워드를 입력해주세요.")]
        public string UserPassword { get; set; }

    }
}
