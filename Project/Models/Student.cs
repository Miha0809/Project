using System.ComponentModel.DataAnnotations;

namespace Project.Models;
public class Student
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    [DataType(DataType.Text)]
    public string Name { get; set; }
}