using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareInterative_API.Entities
{
    public class Answer : BaseEntity
    {
        public string UserName { get; set; }
        public int OptionId { get; set; }
        public virtual Option Option { get; set; }
    }
}
