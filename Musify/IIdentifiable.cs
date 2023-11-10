using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify
{
    public interface IIdentifiable
    {
        public Guid Id { get; set; }
    }
}
