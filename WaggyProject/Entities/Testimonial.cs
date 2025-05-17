using System.ComponentModel.DataAnnotations;

namespace WaggyProject.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        // [MaxLength(50, ErrorMessage = "Max 50 karakter girebilirsiniz.")] bu şekilde de yapabiliriz clean code olması adına validator oluşturup yapıyoruz.
        public string? Name { get; set; }
        public string? Comment { get; set; }
    }
}
