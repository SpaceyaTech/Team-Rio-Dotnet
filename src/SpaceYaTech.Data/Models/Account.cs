namespace SpaceYaTech.Data.Models;

public class Account
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string DisplayPhoto { get; set; }
    public string BioData { get; set; }

    public User User { get; set; }
}