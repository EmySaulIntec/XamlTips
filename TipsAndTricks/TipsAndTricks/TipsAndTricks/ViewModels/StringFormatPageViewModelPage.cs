using System;
using System.Collections.Generic;
using System.Text;

namespace TipsAndTricks.ViewModels
{
    public class StringFormatPageViewModelPage
    {
        public string Name { get; set; } = "Charlin A.";
        public DateTime Date { get; set; } = DateTime.Now;
        public decimal Amount { get; set; } = 540000;
        public int ChildCount { get; set; } = 23;
        public string Company { get; set; } = "INTEC";
    }
}
