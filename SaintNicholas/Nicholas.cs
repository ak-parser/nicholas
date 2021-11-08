using System;
using System.Collections.Generic;
using System.Text;

namespace SaintNicholas
{
    class Nicholas
    {
        private static Nicholas _instance = null;

        public static Nicholas Instance 
        {
            get
            {
                if (_instance == null)
                    _instance = new Nicholas();

                return _instance;
            }
        }

        public int GiftCount { get; private set; }

        private WishManager _wishes;
        public WishManager Wishes
        {
            get => _wishes;
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Wish list cannot be null");
                _wishes = value;
            }
        }

        private Nicholas()
        {
            GiftCount = 0;
            _wishes = null;
        }

        public Gift GiveGift(Child child, bool ignoreBadActions)
        {
            GiftDirector giftDirector;

            if (child.GenderType == Gender.Male)
                giftDirector = new GiftDirector(new BoyGiftBuilder(child, ignoreBadActions, GiftCount));
            else
                giftDirector = new GiftDirector(new GirlGiftBuilder(child, ignoreBadActions, GiftCount));
            
            Gift gift = giftDirector.MakeGift();
            GiftCount++;

            return gift;
        }
    }
}
