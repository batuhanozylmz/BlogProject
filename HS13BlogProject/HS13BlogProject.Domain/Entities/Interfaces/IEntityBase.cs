using HS13BlogProject.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS13BlogProject.Domain.Entities.Interfaces
{
    public interface IEntityBase
    {
       
        Status Status { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
        int AutoId { get; set; }

    }
}
