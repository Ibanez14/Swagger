using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Swagger.Learning.Controllers
{
    public class PersonModel
    {
        /// <summary>
        /// Simple Name Simple NameSimple NameSimple Name
        /// </summary>
        [Required]
        public string Name { get; set; }
        [Range(10, 20)]
        public int Age { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Address must be in the following template Countr/City
        /// </summary>
        [Required]
        public string Address { get; set; }


        [DefaultValue("Uknown")]
        public string Alias { get; set; }
    }
}
