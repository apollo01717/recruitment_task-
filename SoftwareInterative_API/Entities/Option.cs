using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareInterative_API.Entities
{
    public class Option : BaseEntity
    {
        public string Content { get; set; }
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}
