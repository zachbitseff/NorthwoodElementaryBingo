namespace NorthwoodElementaryBingo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Number
    {
        public byte NumberID { get; set; }

        public bool IsCalled { get; set; }

        public byte CallSequence { get; set; }

        public bool IsDisabled { get; set; }

        [Required]
        [StringLength(1)]
        public string SortColumn { get; set; }
    }
}
