using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTool
{
    public enum tapeSize
    {
        width_8mm,
        width_12mm,
        width_16mm,
        width_24mm
    }

    class Feeder
    {
        //variables
        public ushort feederID = 0;
        public tapeSize width = tapeSize.width_8mm;
        public string component;
        public string value;
        public string package;
        public string alias;

        public short speed,head,feedSpacing;

        public float xOffset, yOffset, height, tapeAngle, xCorrection, yCorrection;
        public bool placeComponent=false, checkVacuum=false, useVision=false, usedInDesign=false;

        public string notes, supplier, orderNumber;
    }
}
