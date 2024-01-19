using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify.Infra
{
    public interface IIdentifiable
    {
        public int Id { get; set; }
    }
}
