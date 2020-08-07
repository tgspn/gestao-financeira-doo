﻿using GestaoFinanceira.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Model
{
    public class EntryExpenses
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Categories Categories { get; set; }
        public bool Reapeat { get; set; }
        public DateTime RepeatUntil { get; set; }
        public EntryType EntryType{ get; set; }

    }
}