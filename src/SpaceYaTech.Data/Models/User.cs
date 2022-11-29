namespace SpaceYaTech.Data.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public string VerificationCode { get; set; }
    public DateTime CreatedAt { get; set; }
    public int NumberOfVerificationRequests { get; set; }
}