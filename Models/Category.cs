using System.ComponentModel.DataAnnotations;


namespace First_Project.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, 10, ErrorMessage = "Display Order must be greater than 0 and less than 10")]
        public int DisplayOrder {  get; set; }
    }
}
