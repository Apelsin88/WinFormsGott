using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGott
{
    internal class Ingredient : IEquatable<Ingredient>
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public Ingredient(string name, double quantity)
        {
            Name = name;
            Quantity = quantity;
            
        }
        public bool Equals(Ingredient? other)
        {
            return this.Name.Equals(other.Name) && this.Quantity >= other.Quantity;
        }
        public static bool operator ==(Ingredient a, Ingredient b)
        {
            return a.Name.Equals(b.Name) && a.Quantity >= b.Quantity;
        }
        public static bool operator !=(Ingredient a, Ingredient b)
        {
            return !(a == b);
        }
    }
}
