using System;
using System.Collections.Generic;
using System.Text;

namespace SaintNicholas
{
    class Child
    {
        public string Name { get; private set; }
        public Gender GenderType { get; private set; }
        public int GoodActions { get; private set; }
        public int BadActions { get; private set; }

        public Child(string name, Gender gender, int goodActions, int badActions)
        {
            if (name == null)
                throw new ArgumentNullException("Name cannot be null");
            if (goodActions < 0 || badActions < 0)
                throw new ArgumentNullException("Good or bad actions cannot be less than 0");

            Name = name;
            GenderType = gender;
            GoodActions = goodActions;
            BadActions = badActions;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
