using ChoETL.HL7.Model;
using ChoETL.HL7.Model.v2_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7
{
    class Program
    {
        static void Main(string[] args)
        {
            ChoETLFrxBootstrap.TraceLevel = System.Diagnostics.TraceLevel.Verbose;
            ChoETLFramework.Initialize();

            dynamic hl7Message = ChoHL7Message.Parse("Sample1.csv", new ChoHL7Configuration() { Comments = new string[] { ";" } });
            Console.WriteLine(hl7Message.Version);
            Console.WriteLine(hl7Message.MessageType);
            Console.WriteLine(hl7Message.GetType().FullName);
            Console.WriteLine("*** MessageType: " + hl7Message.MessageType);
            Console.WriteLine("*** IsValid: " + hl7Message.IsValid);
            Console.WriteLine("*** Err: " + hl7Message.ErrorMsg);
            Console.WriteLine("*** Err Detail: " + hl7Message.ErrorDetail);
            return;

            MSH msh = hl7Message.MSH;
            Console.WriteLine("*** Encoding Chars: " + msh.MessageType);
            //Console.WriteLine("*** PatientID: " + hl7Message.ORU_R01_RESULTS_GROUP[0]);
            //foreach (var s in hl7Message.MSH)
            Console.WriteLine(hl7Message.MSH);
            Console.WriteLine(hl7Message.EVN);
            return;
            foreach (var g in hl7Message.ORU_R01_RESULTS_GROUP)
            {
                foreach (var g1 in g.ORU_R01_PATIENT_GROUP)
                {
                    Console.WriteLine(g1.PID.PatientID);
                    Console.WriteLine(g1.PID.PatientExternalID);

                    foreach (var pi in g1.PID.PatientInternalID)
                        Console.WriteLine(pi);
                    foreach (var pi in g1.PID.PatientName)
                        Console.WriteLine(pi);

                    Console.WriteLine(g1.PID.DateOfBirth);
                    Console.WriteLine(g1.PID.Sex);

                }
                //Console.WriteLine(g1.PID.PatientID);
            }
            //Console.WriteLine(hl7Message.ToString());
            //var hl7Message = new ChoHL7Message(ChoHL7Version.v2_3);
            //var hl7MSHSegment = new ChoHL7Segment("MSH");
            //hl7MSHSegment.Fields.Add(new ChoHL7Field("1"));

            //hl7Message.Segments.Add(hl7MSHSegment);
            //Console.WriteLine(hl7Message.ToString());

            //using (var p = new ChoHL7Reader("sample1.csv"))
            //{
            //    foreach (var r in p)
            //        Console.WriteLine(r);
            //}
        }
    }
}
