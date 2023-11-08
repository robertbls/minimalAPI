using System.ComponentModel.DataAnnotations;

namespace minimalAPI
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public  string? Name { get; set; }        
        public bool IsComplete { get; set; }
    }
}

//The preceding code creates the model for this app.
//A model is a class that represents data that the app manages.