using System.ComponentModel.DataAnnotations;

public class Movies {

     [Key]

    public int ID { get; set; }
    public string? Title { get; set; }
    public string? Director { get; set; }
    public double? Summary { get; set; }
}