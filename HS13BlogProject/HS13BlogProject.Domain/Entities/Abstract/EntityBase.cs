using HS13BlogProject.Domain.Entities.Interfaces;
using HS13BlogProject.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS13BlogProject.Domain.Entities.Abstract
{
    public abstract class EntityBase : IEntity<Guid>,IEntityBase
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int AutoId { get; set; }
      
    }
}
