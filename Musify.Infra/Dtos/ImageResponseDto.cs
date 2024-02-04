using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify.Infra.Dtos
{
    public class ImageResponseDto
    {
        public required string FileName { get; set; }
        public required bool Succeeded { get; set; }
    }
}
