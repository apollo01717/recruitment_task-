using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareInterative_API.Dto
{
    public class QuestionDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public IList<OptionDto> Options { get; set; }
    }
}
