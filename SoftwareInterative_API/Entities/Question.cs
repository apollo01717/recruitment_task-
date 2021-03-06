using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareInterative_API.Entities
{
    public class Question : BaseEntity
    {
        public string Content { get; set; }
        public virtual List<Option> Options { get; set; }
    }
}
