namespace RensBlog.Application.Options;

public class JwtTokenOptions
{
    public string Issuer { get; set; } // api.rensblog.com
    public string Audience { get; set; } // www.rensblog.com
    public string Key { get; set; }
    public int ExpireInMunites { get; set; }

}
