using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseStructure;
using DataBaseStructure.Base;

namespace DataSearcher
{
    public class PatientClassEval
    {
        public string MRN;
        public string Patient_RS_UID;
        public int Patient_UID;

        public void set_patient_info(PatientClass patient)
        {
            MRN = patient.MRN;
            Patient_RS_UID = patient.RS_UID;
            Patient_UID = patient.Patient_UID;
        }
    }
    public class CaseClassEval : PatientClassEval
    {
        public string Case_Name;
        public int Case_UID;
        public void set_case_info(CaseClass case_class)
        {
            Case_Name = case_class.CaseName;
            Case_UID = case_class.Case_UID;
        }
    }
    public class ExamClassInfo : CaseClassEval
    {
        public string Exam_Name;
        public int Exam_UID;
        public void set_exam_info(ExaminationClass exam)
        {
            Exam_Name = exam.ExamName;
        }
    }
}
