using System;
using System.Collections.Generic;
using System.Text;

namespace SaintNicholas
{
    class GirlGiftBuilder: GiftBuilder
    {
        public GirlGiftBuilder(Child child, bool ignoreBadActions, int giftIndex)
        {
            if (child == null)
                throw new ArgumentNullException("Child cannot be null");

            _child = child;
            _ignoreBadActions = ignoreBadActions;
            _giftIndex = giftIndex;
            _result = new GirlGift();
        }

        public override void SetToy()
        {
            string[] list = Enum.GetNames(typeof(GirlToy));

            if (_ignoreBadActions)
            {
                Random random = new Random();
                _result.Toy = (GirlToy)Enum.Parse(typeof(GirlToy), list[random.Next(0, list.Length - 1)]);
            }
            else
            {
                if (_child.GoodActions > _child.BadActions)
                {
                    _result.Toy = (GirlToy)Enum.Parse(typeof(GirlToy), list[_giftIndex % list.Length]);
                }
                else
                {
                    _result.Toy = Punishment.Rod;
                }
            }
        }

        public override void SetSweet()
        {
            string[] list = Enum.GetNames(typeof(Sweet));

            if (_ignoreBadActions)
            {
                Random random = new Random();
                _result.Sweet = (Sweet)Enum.Parse(typeof(Sweet), list[random.Next(0, list.Length - 1)]);
            }
            else
            {
                if (_child.GoodActions > _child.BadActions)
                {
                    _result.Sweet = (Sweet)Enum.Parse(typeof(Sweet), list[_giftIndex % list.Length]); ;
                }
                else
                {
                    _result.Sweet = Punishment.None;
                }
            }
        }

        public override void SetWish()
        {
            string punishmentWish = "Be obedient";
            List<string> list = Nicholas.Instance.Wishes?.GirlWishes ?? new List<string>() { punishmentWish };

            if (_ignoreBadActions)
            {
                Random random = new Random();
                _result.Wish = list[random.Next(0, list.Count - 1)];
            }
            else
            {
                if (_child.GoodActions > _child.BadActions)
                {
                    _result.Wish = list[_giftIndex % list.Count];
                }
                else
                {
                    _result.Wish = punishmentWish;
                }
            }
        }
    }
}
