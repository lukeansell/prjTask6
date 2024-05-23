using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTask6
{
    internal class FestivalPlanner
    {
        private List<Band> bands = [];
        private int time = 10;


        public void AddBand(Band band)
        {
            bands.Add(band);
        }

        //public  


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Band band in bands)
            {
                sb.AppendLine(band.ToString());
            }
            return sb.ToString();
        }
    }
}
