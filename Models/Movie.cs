using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models;

public class Movie
{
    public int Id { get; set; }
    
    [StringLength(60, MinimumLength = 3, ErrorMessage = "The field Title must be a string with a minimum length of 3 and a maximum length of 60.")]
    [Required(ErrorMessage = "The Title field is required.")]
    [Display(Name = "Title")]
    public string Title { get; set; } = string.Empty;

    [Display(Name = "Release Date"), DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    [StringLength(30)]
    [Display(Name = "Genre")]
    public string Genre { get; set; } = string.Empty;

    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    [Display(Name = "Price")]
    public decimal Price { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    [StringLength(5)]
    [Required]
    [Display(Name = "Rating")]
    public string Rating { get; set; } = string.Empty;
}