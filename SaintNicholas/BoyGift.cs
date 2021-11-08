using System;
using System.Collections.Generic;
using System.Text;

namespace SaintNicholas
{
    class BoyGift : Gift
    {
        public override Enum Toy
        {
            get => _toy;
            set
            {
                if (value.GetType() != typeof(BoyToy) && value.GetType() != typeof(Punishment))
                    throw new ArgumentException($"Toy type must be {_toy.GetType().Name} or {nameof(Punishment)} type");
                _toy = value;
            }
        }
        public override Enum Sweet
        {
            get => _sweet;
            set
            {
                if (value.GetType() != typeof(Sweet) && value.GetType() != typeof(Punishment))
                    throw new ArgumentException($"Sweet type must be {_sweet.GetType().Name} or {nameof(Punishment)} type");
                _sweet = value;
            }
        }
        public override string Wish
        {
            get => _wish;
            set
            {
                if (value == null || value == "")
                    throw new ArgumentException($"Wish cannot be null");
                _wish = value;
            }
        }
        public BoyGift()
        {
            _toy = _sweet = null;
            _wish = null;
        }

        public BoyGift(BoyToy toy, Sweet sweet, string wish)
        {
            Toy = toy;
            Sweet = sweet;
            Wish = wish;
        }
    }
}
