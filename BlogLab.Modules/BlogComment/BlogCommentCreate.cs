using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace BlogLab.Modules.BlogComment
{
    public class BlogCommentCreate
    {
        public int BlogCommentId { get; set; }
        public int? ParentBlogCommentId { get; set; }
        public int BlogId { get; set; }
        [Required(ErrorMessage = "Content is Required")]
        [MinLength(10, ErrorMessage = "Has to be between 10 and 300 characters")]
        [MaxLength(300, ErrorMessage = "Has to be between 10 and 300 characters")]
        public string Content { get; set; }
    }
}
