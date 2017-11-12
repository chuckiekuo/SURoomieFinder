using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SURoomieFinder.Models
{
    public class Guest
    {
        [Key]
        public int Id { get; set; }
		[Required(ErrorMessage = "Must include a valid SeattleU E-mail address!")]
		[DataType(DataType.EmailAddress)]
		[RegularExpression(@"[A-Za-z0-9]+@[seattleu.edu]$", ErrorMessage = "Not a valid SeattleU E-mail address!")]
        public string Email { get; set; }

		[Required(ErrorMessage = "Must include a password!")]
        public string Password { get; set; }

		[Required(ErrorMessage = "Must include your first name!")]
		[Display(Name = "First name")]
        public string FirstName { get; set; }

		[Required(ErrorMessage = "Must include your age!")]
        public string Age { get; set; }
        public string Major { get; set; }
        public string Job { get; set; }

		[Required(ErrorMessage = "Must include a valid phone number!")]
		[DataType(DataType.PhoneNumber)]
		[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
		public string Phone { get; set; }
        public string Gender { get; set; }
        public string Hometown { get; set; }

        [Display(Name = "Which neighborhood do you want to live in?")]
        [Range(0, 9)]
        public int Question1 { get; set; }

        [Display(Name = "How much are you willing to spend per month on rent?")]
        [Range(0, 4)]
        public int Question2 { get; set; }

        [Display(Name = "What type of housing do you prefer?")]
        [Range(0, 3)]
        public int Question3 { get; set; }

        [Display(Name = "What pets do you currently have or plan to acquire?")]
        [Range(0, 8)]
        public int Question4 { get; set; }

        [Display(Name = "Do you drink alcohol?")]
        [Range(0, 3)]
        public int Question5 { get; set; }

        [Display(Name = "Do you smoke cigarettes?")]
        [Range(0, 3)]
        public int Question6 { get; set; }

        [Display(Name = "Are you 420 friendly?")]
        [Range(0, 3)]
        public int Question7 { get; set; }

        [Display(Name = "Do you partake in other substances not previously listed?")]
        [Range(0, 3)]
        public int Question8 { get; set; }

        [Display(Name = "How would you rate your own cleanliness in a living situation?")]
        [Range(0, 4)]
        public int Question9 { get; set; }

        [Display(Name = "What is your comfort with having guests in your living space?")]
        [Range(0, 3)]
        public int Question10 { get; set; }

        [Display(Name = "How much time do you spend at home?")]
        [Range(0, 3)]
        public int Question11 { get; set; }

        [Display(Name = "Do you prefer to live in housing with accomodations for people with disabilities?")]
        [Range(0, 1)]
        public int Question12 { get; set; }

        [Display(Name = "Do you prefer to live in housing with exclusively members of the LGBTQ+ community?")]
        [Range(0, 1)]
        public int Question13 { get; set; }

        [Display(Name = "Do you prefer to live with people of the same gender?")]
        [Range(0, 1)]
        public int Question14 { get; set; }

        [Display(Name = "What noise level are you comfortable with in your living situation?")]
        [Range(0, 4)]
        public int Question15
        {
            get; set;
        }
        public Questions QuestionList = new Questions();

    }

    public class GuestDbContext : DbContext
    {
        public DbSet<Guest> Guests { get; set; }
    }
}
