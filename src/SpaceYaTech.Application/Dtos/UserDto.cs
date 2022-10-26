namespace SpaceYaTech.BusinessLayerLogic.Dtos;

public class UserDto
{
    public Guid Id { get; set; }
    public string Names { get; set; }
    public string PreferredName { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
}