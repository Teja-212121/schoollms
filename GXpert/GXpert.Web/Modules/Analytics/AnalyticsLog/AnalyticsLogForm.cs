using Serenity.ComponentModel;
using System;

namespace GXpert.Analytics.Forms;

[FormScript("Analytics.AnalyticsLog")]
[BasedOnRow(typeof(AnalyticsLogRow), CheckNames = true)]
public class AnalyticsLogForm
{
    [HalfWidth]
    public int ContentId { get; set; }
    [HalfWidth]
    public int ActivationId { get; set; }
    [HalfWidth]
    public int StudentId { get; set; }
    [HalfWidth]
    public DateTime StartDatetime { get; set; }
    [HalfWidth]
    public DateTime EndDateTime { get; set; }
    [HalfWidth]
    public int TimeSpent { get; set; }
}