using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    public enum FishType {
        Crappie = 0,
        Perch = 1,
        Walleye = 2
    }

    public class Fish
    {
        private FishType _type;
        public Fish(FishType type)
        {
            _type = type;
        }

        public System.Drawing.Bitmap GetResource()
        {
            System.Drawing.Bitmap resource = null;
            switch (_type)
            {
                case FishType.Crappie:
                    resource =  Properties.Resources.Crappie;
                    break;
                case FishType.Perch:
                    resource = Properties.Resources.Perch;
                    break;
                case FishType.Walleye:
                    resource = Properties.Resources.Walleye;
                    break;
            }
            return resource;
        }
    }
}
