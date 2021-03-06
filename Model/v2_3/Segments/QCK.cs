﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// QCK: QCK
    /// </summary>
    public class QCK : ChoHL7Segment
    {
        [Description("Contents")]
        [MaxLength(10000000)]
        public ST Contents
        {
            get { return GetValueAt<ST>(0); }
        }
    }
}
