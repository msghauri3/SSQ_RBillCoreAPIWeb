using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSQ_RBillCoreAPIWeb.Models
{
    [Table("Maintenance")]
    public class Maintenance
    {
        public DateTime? CreationDate { get; set; }

        [Column("Online PMNT Refrence")]
        public double? OnlinePMNTRefrence { get; set; }

        public double? GST { get; set; }
        public double? NewRefrence { get; set; }
        public double? UD { get; set; }
        public string? OldRefrence { get; set; }
        public DateTime? Issuedate { get; set; }
        public DateTime? DateDue { get; set; }
        public string? BillingMonth { get; set; }
        public double? BillingYear { get; set; }

        [Column("jan-year")]
        public double? JanYear { get; set; }
        public double? janmentcharges { get; set; }
        public double? billamountjan { get; set; }

        [Column("jan-status")]
        public double? JanStatus { get; set; }

        [Column("feb-year")]
        public double? FebYear { get; set; }
        public double? febmentcharges { get; set; }
        public double? billamountfeb { get; set; }

        [Column("feb-status")]
        public double? FebStatus { get; set; }

        [Column("mar-year")]
        public double? MarYear { get; set; }
        public double? marmentcharges { get; set; }
        public double? billamountmar { get; set; }

        [Column("mar-status")]
        public double? MarStatus { get; set; }

        [Column("april-year")]
        public double? AprilYear { get; set; }
        public double? aprilmentcharges { get; set; }
        public double? billamountapril { get; set; }

        [Column("april-status")]
        public double? AprilStatus { get; set; }

        [Column("may-year")]
        public double? MayYear { get; set; }
        [Column("maymentcharges")]
        public double? Maymentcharges { get; set; }
        public double? billamountmay { get; set; }

        [Column("may-status")]
        public double? MayStatus { get; set; }

        [Column("june-year")]
        public double? JuneYear { get; set; }
        public double? junementcharges { get; set; }
        public double? billamountjune { get; set; }

        [Column("june-status")]
        public double? JuneStatus { get; set; }

        [Column("july-year")]
        public double? JulyYear { get; set; }
        public double? julymentcharges { get; set; }
        public double? billamountjuly { get; set; }

        [Column("july-status")]
        public double? JulyStatus { get; set; }

        [Column("aug-year")]
        public double? AugYear { get; set; }
        public double? augmentcharges { get; set; }
        public double? billamountaug { get; set; }

        [Column("aug-status")]
        public double? AugStatus { get; set; }

        [Column("sep-year")]
        public double? SepYear { get; set; }
        public double? sepmentcharges { get; set; }
        public double? billamountsep { get; set; }

        [Column("sep-status")]
        public double? SepStatus { get; set; }

        [Column("oct-year")]
        public double? OctYear { get; set; }
        public double? octmentcharges { get; set; }
        public double? billamountoct { get; set; }

        [Column("oct-status")]
        public double? OctStatus { get; set; }

        [Column("nov-year")]
        public double? NovYear { get; set; }
        public double? novmentcharges { get; set; }
        public double? billamountnov { get; set; }

        [Column("nov-status")]
        public double? NovStatus { get; set; }

        [Column("dec-year")]
        public double? DecYear { get; set; }
        public double? decmentcharges { get; set; }
        public double? billamountdec { get; set; }

        [Column("dec-status")]
        public double? DecStatus { get; set; }

        [Column("Customer-Name")]
        public string? CustomerName { get; set; }

        [Column("Plot-Number")]
        public string? PlotNumber { get; set; }

        [Column("Street-Number")]
        public string? StreetNumber { get; set; }

        public string? Sector { get; set; }

        public double? watercharges { get; set; }
        public double? mentcharges { get; set; }
        public double? othercharges { get; set; }
        public double? foodsafety { get; set; }
        public double? insurance { get; set; }
        public double? advance { get; set; }

        public string? adleft { get; set; }
        public string? adjustment { get; set; }
        public double? arrears { get; set; }

        [Column("Amount Due dATE")]
        public double? AmountDueDate { get; set; }

        public double? surcharges { get; set; }
        public double? Amountafterdate { get; set; }
        public string? Phase { get; set; }
        public double? misccharges { get; set; }

        [Column("diesel cost")]
        public double? DieselCost { get; set; }
    }
}
