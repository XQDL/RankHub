using System.ComponentModel.DataAnnotations.Schema;

namespace API_RankHub.Models;

public class Item
{
    public long Id { get; set; }
    public string? name { get; set; }
    public int? position { get; set; }
    public string? image { get; set; }

    [ForeignKey("RankingForeignKey")]
    public Ranking? Ranking { get; set; }

}
