using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProj_TreeView.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "카테고리 명을 입력해주세요")]
        public string CategoryName { get; set; }

        public int ParentId { get; set; }

        public int OrderNum { get; set; }

        public int UserNo { get; set; }

        //[ForeignKey("UserNo")]
        //public virtual User User { get; set; }
    }
}
