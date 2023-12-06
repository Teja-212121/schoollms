using Serenity.ComponentModel;
using System;

namespace GXpert.Analytics.Forms;

[FormScript("Analytics.AnalyticsLog")]
[BasedOnRow(typeof(AnalyticsLogRow), CheckNames = true)]
public class AnalyticsLogForm
{
    public int ContentId { get; set; }
    public int ActivationId { get; set; }
    public int StudentId { get; set; }
    public DateTime StartDatetime { get; set; }
    public DateTime EndDateTime { get; set; }
    public int TimeSpent { get; set; }
}