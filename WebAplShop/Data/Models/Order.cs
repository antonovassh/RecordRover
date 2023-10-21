using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace VinylRecords.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }
        [Display(Name = "Enter your name")]
        [StringLength(15, MinimumLength = 3)]
        [Required(ErrorMessage = "Name length is shold be longer that 3 symbols")]
        public string name { get; set; }
        [Display(Name = "Enter your surname")]
        [StringLength(15, MinimumLength = 5)]
        [Required(ErrorMessage = "Surname length is shold be longer that 5 symbols")]
        public string surname { get; set; }
        [Display(Name = "Enter your adress")]
        [StringLength(15, MinimumLength = 5)]
        [Required(ErrorMessage = "Surname length is shold be longer that 5 symbols")]
        public string adress { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Enter your phone")]
        [StringLength(15, MinimumLength = 7)]
        [Required(ErrorMessage = "Surname length is shold be longer that 7 symbols")]
        public string phone { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Enter your email")]
        [StringLength(15, MinimumLength = 5)]
        [Required(ErrorMessage = "Surname length is shold be longer that 5 symbols")]
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
