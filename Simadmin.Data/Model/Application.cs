using NodaTime;

namespace Simadmin.Data.Model;

public class Application
{
    public int ApplicationId { get; set; }

    public string Email { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Quota { get; set; }

    public int RemainingQuota { get; set; }

    public LocalDateTime CreatedAt { get; set; }
}