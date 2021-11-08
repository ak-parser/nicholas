using System;
using System.Collections.Generic;
using System.Text;

namespace SaintNicholas
{
    abstract class GiftBuilder
    {
        protected Gift _result;
        protected Child _child;
        protected bool _ignoreBadActions;
        protected int _giftIndex;

        public Gift GetGift { get => _result; }

        public abstract void SetToy();
        public abstract void SetSweet();
        public abstract void SetWish();
    }
}
