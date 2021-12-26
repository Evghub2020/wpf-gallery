using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tolik.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string File { get; set; }
        public int FormatId { get; set; }
    }
}
