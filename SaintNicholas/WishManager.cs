using System;
using System.Collections.Generic;
using System.Text;

namespace SaintNicholas
{
    class WishManager
    {
        private List<string> _girlWishes;
        public List<string> GirlWishes
        {
            get
            {
                return new List<string>(_girlWishes);
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Girl wishes cannot be empty");
                }
                _girlWishes = value;
            }
        }

        private List<string> _boyWishes;
        public List<string> BoyWishes
        {
            get
            {
                return new List<string>(_boyWishes);
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Boy wishes cannot be empty");
                }
                _boyWishes = value;
            }
        }

        public WishManager(List<string> boyWishes, List<string> girlWishes)
        {
            BoyWishes = boyWishes;
            GirlWishes = girlWishes;
        }
    }
}
