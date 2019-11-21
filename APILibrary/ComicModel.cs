using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary
{
    public class ComicModel
    {
        public int Num { get; set; }
        public string Img { get; set; }

        public bool btnNextDisabled { get; set; }
        public bool btnPrevDisabled { get; set; }
    }
}
