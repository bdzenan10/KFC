using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC
{

    public class GlavnaMasterMenuItem
    {
        public GlavnaMasterMenuItem()
        {
            TargetType = typeof(GlavnaMasterMenuItem);
            this.Title = "KFC";
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}