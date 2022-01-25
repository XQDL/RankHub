using System.ComponentModel.DataAnnotations.Schema;
namespace API_RankHub.Models;

public class Ranking
{
    public long Id { get; set; }
    public string? tittle { get; set; }

    [ForeignKey("UserForeignKey")]
    public User? User { get; set; }
}
