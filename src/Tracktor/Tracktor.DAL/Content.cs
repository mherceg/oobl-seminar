namespace Tracktor.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Content
    {
        public int Id { get; set; }

        [Column("content")]
        [Required]
        public string content1 { get; set; }

        public DateTime startTime { get; set; }

        public int User_Id { get; set; }

        public int Reputation_id { get; set; }

        public virtual Reputation Reputation { get; set; }

        public virtual User User { get; set; }

        public virtual Contents_Info Contents_Info { get; set; }

        public virtual Contents_Info Contents_Info1 { get; set; }
    }
}
