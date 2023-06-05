using System.ComponentModel.DataAnnotations;

namespace LibraryFinal.Models
{
    public class Order
    {
        [Required(ErrorMessage = "Numer karty jest wymagany")]
        public int ReaderCardNumber { get; set; }

        [Required(ErrorMessage = "Numer telefonu jest wymagany")]
        [Phone(ErrorMessage = "Niepoprawny numer telefonu")]
        [Display(Name = "Numer telefonu")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Adres jest wymagany")]
        [Display(Name = "Adres")]
        public string Address { get; set; }

        [Key]
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public ICollection<OrderBook> OrderBooks { get; set; }
    }
}
