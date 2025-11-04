using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSQ_RBillCoreAPIWeb.Models
{
    [Table("Electricity")]
    public class Electricity
    {
        public DateTime? CreationDate { get; set; }

        [Column("Online PMNT Refrence")]
        public string? OnlinePMNTRefrence { get; set; }

        public string? NewRefrence { get; set; }
        public string? UD { get; set; }
        public string? OldRefrence { get; set; }
        public DateTime? ReadingDate { get; set; }
        public DateTime? Issuedate { get; set; }
        public DateTime? DateDue { get; set; }

        [Column("CONN#DATE")]
        public DateTime? ConnDate { get; set; }

        public string? BillingMonth { get; set; }
        public double? BilllingYear { get; set; }

        [Column("jan-year")] public double? JanYear { get; set; }
        [Column("jan-units")] public double? JanUnits { get; set; }
        [Column("jan-amount")] public double? JanAmount { get; set; }
        [Column("jan-status")] public double? JanStatus { get; set; }

        [Column("feb-year")] public double? FebYear { get; set; }
        [Column("feb-units")] public double? FebUnits { get; set; }
        [Column("feb-amount")] public double? FebAmount { get; set; }
        [Column("feb-status")] public double? FebStatus { get; set; }

        [Column("mar-year")] public double? MarYear { get; set; }
        [Column("mar-units")] public double? MarUnits { get; set; }
        [Column("mar-amount")] public double? MarAmount { get; set; }
        [Column("mar-status")] public double? MarStatus { get; set; }

        [Column("april-year")] public double? AprilYear { get; set; }
        [Column("april-units")] public double? AprilUnits { get; set; }
        [Column("april-amount")] public double? AprilAmount { get; set; }
        [Column("april-status")] public double? AprilStatus { get; set; }

        [Column("may-year")] public double? MayYear { get; set; }
        [Column("may-units")] public double? MayUnits { get; set; }
        [Column("may-amount")] public double? MayAmount { get; set; }
        [Column("may-status")] public double? MayStatus { get; set; }

        [Column("june-year")] public double? JuneYear { get; set; }
        [Column("june-units")] public double? JuneUnits { get; set; }
        [Column("june-amount")] public double? JuneAmount { get; set; }
        [Column("jane-status")] public double? JaneStatus { get; set; }

        [Column("july-year")] public double? JulyYear { get; set; }
        [Column("july-units")] public double? JulyUnits { get; set; }
        [Column("july-amount")] public double? JulyAmount { get; set; }
        [Column("july-status")] public double? JulyStatus { get; set; }

        [Column("aug-year")] public double? AugYear { get; set; }
        [Column("aug-units")] public double? AugUnits { get; set; }
        [Column("aug-amount")] public double? AugAmount { get; set; }
        [Column("aug-status")] public double? AugStatus { get; set; }

        [Column("sep-year")] public double? SepYear { get; set; }
        [Column("sep-units")] public double? SepUnits { get; set; }
        [Column("sep-amount")] public double? SepAmount { get; set; }
        [Column("sep-status")] public string? SepStatus { get; set; }

        [Column("oct-year")] public double? OctYear { get; set; }
        [Column("oct-units")] public double? OctUnits { get; set; }
        [Column("oct-amount")] public double? OctAmount { get; set; }
        [Column("oct-status")] public double? OctStatus { get; set; }

        [Column("nov-year")] public double? NovYear { get; set; }
        [Column("nov-units")] public double? NovUnits { get; set; }
        [Column("nov-amount")] public double? NovAmount { get; set; }
        [Column("nov-status")] public double? NovStatus { get; set; }

        [Column("dec-year")] public double? DecYear { get; set; }
        [Column("dec-units")] public double? DecUnits { get; set; }
        [Column("dec-amount")] public double? DecAmount { get; set; }
        [Column("dec-status")] public double? DecStatus { get; set; }

        public string? Tarrif { get; set; }
        public string? Load { get; set; }
        public string? Meter_Type { get; set; }

        [Column("Customer-Name")] public string? CustomerName { get; set; }
        [Column("Plot-Number")] public string? PlotNumber { get; set; }
        [Column("Street-Number")] public string? StreetNumber { get; set; }
        public string? Sector { get; set; }
        public string? MeterNo { get; set; }

        public double? Previous { get; set; }
        public double? Present { get; set; }
        public double? MF { get; set; }

        [Column("Total Unit")] public double? TotalUnit { get; set; }
        public double? Previouspeak { get; set; }
        public double? Previousoffpeak { get; set; }
        public double? Presentpeak { get; set; }
        public double? Presentoffpeak { get; set; }
        public double? Peaktotalunit { get; set; }
        public double? Offpeaktotal { get; set; }

        public string? Status { get; set; }
        public double? COE { get; set; }
        public double? NJ { get; set; }
        public double? Advance { get; set; }
        public double? Incometax { get; set; }
        public double? ED { get; set; }
        public double? TRSurcharge { get; set; }
        public double? BillAdjustment { get; set; }
        public double? ExtraTax { get; set; }
        public double? FPA { get; set; }

        [Column("Current Bill")] public double? CurrentBill { get; set; }
        public double? Arrears { get; set; }

        [Column("PTV Fees")] public double? PTVFees { get; set; }
        public double? GST { get; set; }

        [Column("Furthur Tax")] public double? FurthurTax { get; set; }
        public double? AdvanceTax { get; set; }
        public double? FCSurcharge { get; set; }
        public double? Feeder { get; set; }

        public double? Unitsrate1 { get; set; }
        public double? Unitsubsidy1 { get; set; }
        public double? Appliedunitrate1 { get; set; }
        public double? Appliedunit1 { get; set; }

        public double? Unitsrate2 { get; set; }
        public double? Unitsubsidy2 { get; set; }
        public double? Appliedunitrate2 { get; set; }
        public double? Appliedunit2 { get; set; }

        [Column("Amount Due dATE")] public double? AmountDueDate { get; set; }
        public double? Surcharges { get; set; }
        public double? Amountafterdate { get; set; }
        public string? Phase { get; set; }

        public double? PreviousPeakSolar { get; set; }
        public double? PreviousOffPeakSolar { get; set; }
        public double? PreviousExport { get; set; }
        public double? CurrentPeakSolar { get; set; }
        public double? CurrentOffPeakSolar { get; set; }
        public double? CurrentExport { get; set; }

        public double? Qtr { get; set; }
        public double? Tarrifadj { get; set; }
        public double? FixedCharges { get; set; }
        public string? TotalBill { get; set; }

        public double? Misc { get; set; }
        public double? ArrearMisc { get; set; }
        public double? Expoffpeak { get; set; }
        public double? Impoffpeak { get; set; }
        public double? Netoffpeak { get; set; }
        public string? Exppeak { get; set; }
        public double? Imppeak { get; set; }
        public double? Netpeak { get; set; }
        public string? Counter { get; set; }
        public double? Previousop { get; set; }
        public string? Previousp { get; set; }
        public double? Presentop { get; set; }
        public string? Presentp { get; set; }
        public string? Creditunit { get; set; }
        public string? Fpamessage { get; set; }
        public double? UnitsDiff_OffPH { get; set; }
        public double? UnitsDiff_PH { get; set; }
        public double? UnitDiff_solar { get; set; }
        public double? Installment { get; set; }
        public string? Readingby { get; set; }
        public string? Installmentno { get; set; }
    }
}
