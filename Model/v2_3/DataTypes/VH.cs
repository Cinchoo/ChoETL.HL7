using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("VH: Visiting Hours")]
    public class VH : ChoHL7AbstractField
    {
        public ID StartDayRange
        {
            get { return GetValueAt<ID>(0); }
        }
        public ID EndDayRange
        {
            get { return GetValueAt<ID>(1); }
        }
        public TM StartHourRange
        {
            get { return GetValueAt<TM>(2); }
        }
        public TM EndHourRange
        {
            get { return GetValueAt<TM>(3); }
        }

        public VH(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public VH(ChoHL7Field field) : base(field)
        {
        }
    }
}
