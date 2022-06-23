namespace AspMVCVuePost.Repository.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Post")]
    public partial class Post
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PostId { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(30)]
        public string Slug { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }
        public string AuthorUserId { get; set; }
        public DateTime? DateCreated { get; set; }
        public virtual User User { get; set; }
    }
}
