﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DataMiningMonitor.Models;

public partial class TwbrokerStockDeal
{
    public DateOnly Date { get; set; }

    public string Pid { get; set; }

    public string BrokerId { get; set; }

    public double Price { get; set; }

    public double Blotsum { get; set; }

    public double Slotsum { get; set; }
}