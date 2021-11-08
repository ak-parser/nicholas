using System;
using System.Collections.Generic;
using System.Text;

namespace SaintNicholas
{
    class GirlGift: Gift
    {
        public override Enum Toy
        {
            get => _toy;
            set
            {
                if (value.GetType() != typeof(GirlToy) && value.GetType() != typeof(Punishment))
                    throw new ArgumentException($"Toy type must be {nameof(GirlToy)} or {nameof(Punishment)} type");
                _toy = value;
            }
        }
        public override Enum Sweet
        {
            get => _sweet;
            set
            {
                if (value.GetType() != typeof(Sweet) && value.GetType() != typeof(Punishment))
                    throw new ArgumentException($"Sweet type must be {nameof(Sweet)} or {nameof(Punishment)} type");
                _sweet = value;
            }
        }
        public override string Wish
        {
            get => _wish;
            set
            {
                if (value == null || value == "")
                    throw new ArgumentException($"Wish cannot be empty");
                _wish = value;
            }
        }
        public GirlGift()
        {
            _toy = _sweet = null;
            _wish = null;
        }

        public GirlGift(GirlToy toy, Sweet sweet, string wish)
        {
            Toy = toy;
            Sweet = sweet;
            Wish = wish;
        }
    }
}
