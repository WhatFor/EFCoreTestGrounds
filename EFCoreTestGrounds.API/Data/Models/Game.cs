using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCoreTestGrounds.API.Data.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public virtual ICollection<GameReview> Reviews { get; set; }
    }
}
