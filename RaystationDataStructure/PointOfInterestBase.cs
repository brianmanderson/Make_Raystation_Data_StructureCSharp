using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaystationDataStructure
{
    internal class PointOfInterestBase
    {
        public class PointOfInterestBaseClass
        {
            public string Name { get; set; }
            public int RS_Number { get; set; }
            public string Type { get; set; }
            public int Base_POI_UID { get; set; }
            public string OrganType { get; set; }
            public ROIMaterial.ROIMaterialClass ROI_Material { get; set; }
            public OrganData.OrganDataClass OrganData { get; set; }

            public PointOfInterestBaseClass()
            {

            }
        }
    }
}
