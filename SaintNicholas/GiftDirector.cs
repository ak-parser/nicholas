using System;
using System.Collections.Generic;
using System.Text;

namespace SaintNicholas
{
    class GiftDirector
    {
        private GiftBuilder _builder;

        public GiftDirector(GiftBuilder builder)
        {
            if (builder == null)
                throw new ArgumentNullException("Builder is not set");
            _builder = builder;
        }

        public Gift MakeGift()
        {
            _builder.SetToy();
            _builder.SetSweet();
            _builder.SetWish();

            return _builder.GetGift;
        }
    }
}
