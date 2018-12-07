using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Gener { get; set; }

        [MaxLength(2000)]
        public byte[] Thumbnail { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
    }
}
