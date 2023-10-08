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
    public class ExamClassEval : CaseClassEval
    {
        public string Exam_Name;
        public int Exam_UID;
        public void set_exam_info(ExaminationClass exam)
        {
            Exam_Name = exam.ExamName;
            Exam_UID = exam.Exam_UID;
        }
    }
    public class RegionOfInterestBaseEval : ExamClassEval
    {
        public string ROI_Name;
        public int RS_Number;
        public string Type;
        public int Base_ROI_UID;
        public void set_roi_base_info(RegionOfInterestBase roi_base)
        {
            ROI_Name = roi_base.Name;
            RS_Number = roi_base.RS_Number;
            Type = roi_base.Type;
            Base_ROI_UID = roi_base.Base_ROI_UID;
        }
    }
    public class RegionOfInterestVolumeEval : RegionOfInterestBaseEval
    {
        public double Volume;
        public double HU_Min;
        public double HU_Max;
        public double HU_Average;
        public bool Defined;
        public int ROI_UID;
        public void set_roi_info(RegionOfInterest roi)
        {
            ROI_Name = roi.Name;
            Volume = roi.Volume;
            HU_Max = roi.HU_Max;
            HU_Average = roi.HU_Average;
            HU_Min = roi.HU_Min;
            ROI_UID = roi.ROI_UID;
        }
    }
}
