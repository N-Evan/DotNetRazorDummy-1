using System.ComponentModel.DataAnnotations;

namespace DummyRazor.Model
{
    public class Book
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
