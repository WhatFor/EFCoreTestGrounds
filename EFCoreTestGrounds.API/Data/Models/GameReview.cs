using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreTestGrounds.API.Data.Models
{
    public class GameReview
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }

        public int Stars { get; set; }

        public string ReviewContent { get; set; }

        public virtual Game Game { get; set; }
    }
}
