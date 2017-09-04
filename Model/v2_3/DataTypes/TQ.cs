using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("TQ: Timing Quantity")]
    public class TQ : ChoHL7AbstractField
    {
        public CQ Quantity
        {
            get { return GetValueAt<CQ>(0); }
        }
        public CM_RI Interval
        {
            get { return GetValueAt<CM_RI>(1); }
        }
        public ST Duration
        {
            get { return GetValueAt<ST>(2); }
        }
        public TS StartDatetime
        {
            get { return GetValueAt<TS>(3); }
        }
        public TS EndDatetime
        {
            get { return GetValueAt<TS>(4); }
        }
        public ST Priority
        {
            get { return GetValueAt<ST>(5); }
        }

        public ST Condition
        {
            get { return GetValueAt<ST>(6); }
        }

        public TX Text
        {
            get { return GetValueAt<TX>(7); }
        }

        public ST Conjunction
        {
            get { return GetValueAt<ST>(8); }
        }

        public CM_OSD OrderSequencing
        {
            get { return GetValueAt<CM_OSD>(9); }
        }

        public TQ(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public TQ(ChoHL7Field field) : base(field)
        {
        }
    }
}
