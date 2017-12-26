using System;
using System.Collections.Generic;
using System.Text;

namespace ECommercial.Data.Interfaces
{
    public interface ISortable
    {
        int? SortOrder { set; get; }
    }
}
