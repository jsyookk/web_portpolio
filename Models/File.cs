using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProj_TreeView.Models
{
    public class File
    {
        [Key]
        public int FileID { get; set; }

        public int CategoryID { get; set; }

        public String PreFixPath { get; set; }

        public string OrignalFileName { get; set; }

        public string FIleName { get; set; }

        public DateTime RegDate { get; set; }

    }
}
