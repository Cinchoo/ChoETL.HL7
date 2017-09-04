using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [ChoHL7Group(1, typeof(ORU_R01_PATIENT_GROUP), Optional = true)]
    [ChoHL7Group(2, typeof(ORU_R01_ORDER_GROUP), Repeatable = true)]
    public class ORU_R01_RESULTS_GROUP : ChoHL7AbstractGroup
    {
    }
}
