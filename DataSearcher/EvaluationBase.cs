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
    public class PrescriptionROIEval : RegionOfInterestVolumeEval
    {
        public int Prescription_UID;
        public double DoseAbsoluteVolume_cc;
        public double DoseValue_cGy;
        public double DoseVolume_percent;
        public double RelativePrescriptionLevel;
        public string PrescriptionType;
        public int NumberOfFractions;
        public double Dose_per_Fraction;
        public void set_rx_info(PrescriptionClass prescription)
        {
            Prescription_UID = prescription.Prescription_UID;
            DoseAbsoluteVolume_cc = prescription.DoseAbsoluteVolume_cc;
            DoseValue_cGy = prescription.DoseValue_cGy;
            DoseVolume_percent = prescription.DoseVolume_percent;
            RelativePrescriptionLevel = prescription.RelativePrescriptionLevel;
            PrescriptionType = prescription.PrescriptionType;
            NumberOfFractions = prescription.NumberOfFractions;
            Dose_per_Fraction = prescription.Dose_per_Fraction;
            set_roi_info(prescription.Referenced_ROI_Structure);
        }
    }
    public class DataBaseEvaluation
    {
        public PatientDatabase Patient_DataBase;
        public DataBaseEvaluation(PatientDatabase patient_DataBase)
        {
            Patient_DataBase = patient_DataBase;
        }
        public (PatientClass, CaseClass) return_all_info_from_roi_base(RegionOfInterestBase wanted_roi)
        {
            foreach(PatientClass patient in Patient_DataBase.Patients.Values)
            {
                foreach(CaseClass case_class in patient.Cases.Values)
                {
                    foreach(RegionOfInterestBase roi_base in case_class.Base_ROIs.Values)
                    {
                        if (roi_base.Base_ROI_UID == wanted_roi.Base_ROI_UID)
                        {
                            return (patient, case_class);
                        }
                    }
                }
            }
            return (null, null);
        }
        public (PatientClass, CaseClass) return_all_info_from_poi_base(PointOfInterestBase wanted_poi)
        {
            foreach (PatientClass patient in Patient_DataBase.Patients.Values)
            {
                foreach (CaseClass case_class in patient.Cases.Values)
                {
                    foreach (PointOfInterestBase poi_base in case_class.Base_POIs.Values)
                    {
                        if (poi_base.Base_POI_UID == wanted_poi.Base_POI_UID)
                        {
                            return (patient, case_class);
                        }
                    }
                }
            }
            return (null, null);
        }
    }
}
