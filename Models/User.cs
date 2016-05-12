namespace docker_aspnetcore_demo.Models
{
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }

        public string Address { get; set; }

        public int Age { get; set; }
    }
}
