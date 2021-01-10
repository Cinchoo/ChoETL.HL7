using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("0125: Value type")]
    public enum ValueType
    {
        [Description("AD")]
        Address,
        [Description("CE")]
        CodedEntry,
        [Description("CF")]
        CodedElementWithFormattedValues,
        [Description("CK")]
        CompositeIDWithCheckDigit,
        [Description("CN")]
        CompositeIDAndName,
        [Description("CP")]
        CompositePrice,
        [Description("CX")]
        ExtendedCompositeIDWithCheckDigit,
        [Description("DT")]
        Date,
        [Description("ED")]
        EncapsulatedData,
        [Description("FT")]
        FormattedText,
        [Description("ID")]
        CodedValue,
        [Description("MO")]
        Money,
        [Description("NM")]
        Numeric,
        [Description("PN")]
        PersonName,
        [Description("RP")]
        ReferencePointer,
        [Description("SN")]
        StructuredNumeric,
        [Description("ST")]
        StringData,
        [Description("TM")]
        Time,
        [Description("TN")]
        TelephoneNumber,
        [Description("TS")]
        TimeStamp,
        [Description("TX")]
        TextData,
        [Description("XAD")]
        ExtendedAddress,
        [Description("XCN")]
        ExtendedCompositeNameAndNumberForPersons,
        [Description("XON")]
        ExtendedCompositeNameAndNumberForOrganizations,
        [Description("XPN")]
        ExtendedPersonName,
        [Description("XTN")]
        ExtendedTelecommunicationsNumber
    }
}
