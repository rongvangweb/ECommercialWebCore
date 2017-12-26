using ECommercial.Data.Enums;

namespace ECommercial.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}