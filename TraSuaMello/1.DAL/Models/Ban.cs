using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSuaMello._1.DAL.Models
{
    public class Ban
    {
        
        [Key]
        public int MaBan { get; set; }
        public int SoBan { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }

    }
}
