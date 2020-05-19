using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace StackTool
{
    class Component
    {
        //basic component informations
        public string designator, value, package;
        public decimal posX, posY, rotation;
        public bool isPlaced = false;   //if indicates if the component is matched to a unique part / if a unique part indicates that part is matched to a feeder
        public bool isoverridden = false;


        //members below is used only when working on uniqueParts (unique parts is a collection of the same type of parts)

        //this list is used by the findUniqueParts method. 
        public List<Component> ofSameType = new List<Component>();  //all parts of the same type are in this list

        //if the component is matched to a feeder the ID will be stored here
        public int matchingFeederID=-1;
    }
}
