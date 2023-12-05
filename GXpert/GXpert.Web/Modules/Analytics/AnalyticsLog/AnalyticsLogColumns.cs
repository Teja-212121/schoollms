using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Analytics.Columns;

[ColumnsScript("Analytics.AnalyticsLog")]
[BasedOnRow(typeof(AnalyticsLogRow), CheckNames = true)]
public class AnalyticsLogColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string ContentTitle { get; set; }
    public string ActivationDeviceId { get; set; }
    public string StudentPrn { get; set; }
    public DateTime StartDatetime { get; set; }
    public DateTime EndDateTime { get; set; }
    public int TimeSpent { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}