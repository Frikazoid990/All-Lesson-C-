using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace To_DoList
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        public string text { get; set; }
        public bool isdone { get; set; } = false;


    }
}
