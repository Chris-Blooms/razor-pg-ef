using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace razor_pg_ef.Models
{

    public class Game
    {

        public int GameId { get; set; }
        public string Title { get; set; }

        [Display(Name = "Realease Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
    }
}