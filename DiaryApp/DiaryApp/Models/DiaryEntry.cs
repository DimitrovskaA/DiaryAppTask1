using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry 
    {
        public int Id { get; set; }
        [Required (ErrorMessage="Please Enter a Title!")] 
        [StringLength(100, MinimumLength =3, ErrorMessage ="Title must be between 3 - 100 Characters!")] 
        public string Title { get; set; } = String.Empty; 
        [Required]
        [StringLength(1000,MinimumLength =10, ErrorMessage ="Content must be between 10 - 1000 Characters!")]
        public string Content { get; set; } = String.Empty;
        [Required (ErrorMessage = "Please enter the Date!")]
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
