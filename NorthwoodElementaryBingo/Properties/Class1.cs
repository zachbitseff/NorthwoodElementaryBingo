using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class BingoNums
{
    [Key]
	public Byte NumberID { get; set; }
    
    public Boolean IsCalled { get; set; }

    public Byte CallSequence { get; set; }

    public Boolean IsDisabled { get; set; }

    [Required]
    public Char SortColumn { get; set; }

}
