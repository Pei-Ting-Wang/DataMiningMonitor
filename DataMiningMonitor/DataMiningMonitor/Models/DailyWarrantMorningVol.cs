﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DataMiningMonitor.Models;

public partial class DailyWarrantMorningVol
{
    public DateOnly Date { get; set; }

    public string Pid { get; set; }

    public double MaxBayImplyVol { get; set; }

    public double AvgBayImplyVol { get; set; }

    public double MinBayImplyVol { get; set; }

    public double MaxBayAvgImplyVol { get; set; }

    public double AvgBayAvgImplyVol { get; set; }

    public double MinBayAvgImplyVol { get; set; }

    public double MaxSellImplyVol { get; set; }

    public double AvgSellImplyVol { get; set; }

    public double MinSellImplyVol { get; set; }

    public double MaxSellAvgImplyVol { get; set; }

    public double AvgSellAvgImplyVol { get; set; }

    public double MinSellAvgImplyVol { get; set; }

    public double YetBayImplyVol { get; set; }

    public double YetBayAvgImplyVol { get; set; }

    public double YetSellImplyVol { get; set; }

    public double YetSellAvgImplyVol { get; set; }
}