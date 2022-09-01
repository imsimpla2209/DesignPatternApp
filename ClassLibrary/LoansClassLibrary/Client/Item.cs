using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.Client
{
    public class Item
    {
        public string Name { get; protected set; }
        public double value { get; protected set; }
        public bool Document { get; protected set; }

        public Item(string name, double value, bool document)
        {
            Name = name;
            this.value = value;
            Document = document;
        }

        public Item(string name, double value)
        {
            Name = name;
            this.value = value;
        }

        public override string ToString()
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // convert VND format
            string VnDValue = this.value.ToString("#,###", cul.NumberFormat);
            return $"Name: {Name}, Value: {VnDValue}, Is enough Documents: {(Document ? "Yesir" : "No")}";
        }
    }
}