﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseStructure
{
    internal class Base
    {
        public class DateTimeClass
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
            public int hour { get; set; }
            public int minute { get; set; }
            public int second { get; set; }
            public int microsecond { get; set; }
            public int fold { get; set; }
        }
        public class RoiMaterial
        {
            public string Name { get; set; }
            public double MassDensity { get; set; }
        }

        public class OrganDataClass
        {
            public string OrganType { get; set; }
            public string ResponseFunctionTissueName { get; set; }
        }
        public class PointOfInterestBase
        {
            public string Name { get; set; }
            public int RS_Number { get; set; }
            public string Type { get; set; }
            public int Base_POI_UID { get; set; }
            public string OrganType { get; set; }
            public RoiMaterial ROI_Material { get; set; }
            public OrganDataClass OrganData { get; set; }

        }
        public class PointOfInterest
        {
            public string Name { get; set; }
            public int RS_Number { get; set; }
            public int Referenced_Base_POI_UID { get; set; }
            public bool Defined { get; set; }
            public int POI_UID { get; set; }
            public double x { get; set; }
            public double y { get; set; }
            public double z { get; set; }
        }
        public class RegionOfInterestBase
        {
            public string Name { get; set; }
            public int RS_Number { get; set; }
            public string Type { get; set; }
            public int Base_ROI_UID { get; set; }
            public RoiMaterial ROI_Material { get; set; }
            public OrganDataClass OrganData { get; set; }
        }
        public class RegionOfInterest
        {
            public string Name { get; set; }
            public int RS_Number { get; set;}
            public int Referenced_Base_ROI_UID { get; set; }
            public double Volume { get; set; }
            public double HU_Min { get; set; }
            public double HU_Max { get; set; }
            public double HU_Average { get; set; }
            public bool Defined { get; set; }
            public int ROI_UID { get; set; }

        }
        public class ExamInfo
        {
            public string ExamName { get; set; }
            public string SeriesDescription { get; set; }
            public string SeriesInstanceUID { get; set; }
            public string StudyInstanceUID { get; set; }
            public string StudyDescription { get; set; }
            public DateTimeClass Exam_DateTime { get; set; }
        }
        public class EquipmentInfoClass
        {
            public string FrameOfReference { get; set; }
            public string Modality { get; set; }
        }
        public class ExaminationClass : EquipmentInfoClass
        {
            public int Exam_UID { get; set; }
            public EquipmentInfoClass EquipmentInfo { get; set; }
            public Dictionary<int, RegionOfInterest> ROIs { get; set; }
            public Dictionary<int, PointOfInterest> POIs { get; set; }
        }
        public class RegionOfInterestDose
        {
            public List<double> AbsoluteDose { get; set; }
            public List<double> RelativeVolumes { get; set; }
            public double Dose_Min_cGy { get; set; }
            public double Dose_Max_cGy { get; set; }
            public double Dose_Average_cGy { get; set; }
            public int Dose_ROI_UID { get; set; }
            public int Referenced_Volume_ROI_UID { get; set; }
            public int Referenced_Base_ROI_UID { get; set; }
            public int RS_Number { get; set; }
            public string Name { get; set; }

        }
        public class PointOfInterestDose
        {
            public double Dose_cGy { get; set; }
            public string Name { get; set; }
            public int Referenced_POI_UID { get; set; }
            public int Referenced_Base_POI_UID { get; set; }
            public int RS_Number { get; set;}
            public int Dose_POI_UID { get; set; }
        }
        public class DoseSpecificationPointClass
        {
            public string Name { get; set; }
            public double x { get; set; }
            public double y { get; set; }
            public double z { get; set; }
        }
        public class PrescriptionClass
        {
            public int Prescription_UID { get; set; }
            public double DoseAbsoluteVolume_cc { get; set; }
            public double DoseValue_cGy { get; set; }
            public double DoseVolume_percent { get; set; }
            public double RelativePrescriptionLevel { get; set; }
            public string PrescriptionType { get; set; }
            public RegionOfInterest Referenced_ROI_Structure { get; set; }
            public PointOfInterest Referenced_POI_Structure { get; set; }
            public int NumberOfFractions { get; set; }
            public double Dose_per_Fraction { get; set; }
        }
        public class BeamClass
        {
            public string ArcRotationDirection { get; set; }
            public double ArcStopGantryAngle { get; set; }
            public double CollimatorAngle { get; set; }
            public double BeamMU { get; set; }
            public string BeamQualityId { get; set; }
            public double CouchRotationAngle { get; set; }
            public string DeliveryTechnique { get; set; }
            public string Description { get; set; }
            public double GantryAngle { get; set; }
            public string PlanGenerationTechnique { get; set; }
            public string BeamName { get; set; }
            public int RS_BeamNumber { get; set; }
            public int BeamNumber_UID { get; set; }
            public double SSD { get; set; }


            public double GantryAngle { get; set; }
        }
    }
}
