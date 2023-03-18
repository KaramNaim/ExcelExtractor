using System;
using System.Collections.Generic;

namespace ExcelExtractor.Models;

public partial class ExcelDatum
{
    public int Id { get; set; }

    public string ExcelName { get; set; }

    public string ExcelValue { get; set; }

    public string CreatedOn { get; set; }
}
