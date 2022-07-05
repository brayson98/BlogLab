using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace BlogLab.Modules.Blog
{
    public class BlogCreate
    {
        public int BlogId { get; set; }
        [Required(ErrorMessage = "Title is Required")]
        [MinLength(10, ErrorMessage = "Has to be between 10 and 50 characters")]
        [MaxLength(50, ErrorMessage = "Has to be between 10 and 50 characters")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Content is Required")]
        [MinLength(300, ErrorMessage = "Has to be between 300 and 5000 characters")]
        [MaxLength(5000, ErrorMessage = "Has to be between 300 and 5000 characters")]
        public string Content { get; set; }
        public int? PhotoId { get; set; }
    }
}
