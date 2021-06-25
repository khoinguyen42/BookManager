namespace BookManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage ="ID không được để trống")]
        public int ID { get; set; }

        [Required(ErrorMessage ="Tiêu đề không được để trống")]
        [StringLength(100,ErrorMessage ="Tiêu đề không được quá 100 ký tự")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Tác giả không được để trống")]
        [StringLength(30,ErrorMessage ="Tác giả không được quá 30 ký tự")]
        public string Author { get; set; }

        [Required(ErrorMessage ="Nội dung không được để trống")]
        public string Description { get; set; }

        [Required (ErrorMessage ="Hình ảnh không được để trống")]
        public string Image { get; set; }
        
        [Required(ErrorMessage ="Giá không được để trống")]
        [Range(1000, 1000000, ErrorMessage = "Giá sách nằm trong khoảng từ 1k đến 1m")]
        public int Price { get; set; }
    }
}
