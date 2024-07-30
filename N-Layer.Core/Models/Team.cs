using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Layer.Core.Models
{
    public class Team : BaseModel
    {
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
