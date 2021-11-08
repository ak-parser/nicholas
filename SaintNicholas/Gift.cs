using System;
using System.Collections.Generic;
using System.Text;

namespace SaintNicholas
{
    abstract class Gift
    {
        protected Enum _toy;
        protected Enum _sweet;
        protected string _wish;

        public abstract Enum Toy { get; set; }
        public abstract Enum Sweet { get; set; }
        public abstract string Wish { get; set; }

        public override string ToString()
        {
            return $"Toy: {Toy}, Sweet: {Sweet}, Wish: {Wish}";
        }
    }
}
