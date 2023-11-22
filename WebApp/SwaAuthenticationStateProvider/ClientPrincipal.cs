using System.Security.Claims;
public class ClientPrincipal
{
    public required string IdentityProvider { get; set; }
    public required string UserId { get; set; }
    public required string UserDetails { get; set; }
    public IEnumerable<string>? UserRoles { get; set; }
    public required IEnumerable<Dictionary<String, String>> Claims { get; set; }
}