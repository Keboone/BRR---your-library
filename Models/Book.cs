using System.ComponentModel.DataAnnotations;

namespace LibraryFinal.Models
{
    public class Book
    {
        public Book(int id, string title, string author, int pages, string description, string image)
        {
            Id = id;
            Title = title;
            Author = author;
            Pages = pages;
            Description = description;
            Image = image;
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string Author { get; set; }

        [Required]
        public int Pages { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        public string Image { get; set; }
    }
}
