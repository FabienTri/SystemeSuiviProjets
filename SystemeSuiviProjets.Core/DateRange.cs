﻿using System;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class DateRange(DateTime dateDébut, DateTime dateFin) : ValueObject
    {
        public DateTime DateDébut { get; set; } = dateDébut;
        public DateTime DateFin { get; set; } = dateFin;
    }
}