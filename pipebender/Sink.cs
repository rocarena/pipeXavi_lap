﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pipebender
{
    class Sink : Component
    {
        private int quantity; // This is default flow. We can change it later.
        private int isInAvailable = -1;

        
        public Sink(int id, Point coord, int quantity, int eType) : base(id, coord, eType)
        {
            Id = id;
            Coord = coord;
            this.quantity = quantity;
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public int IsInAvailable
        {
            get
            {
                return isInAvailable;
            }

            set
            {
                isInAvailable = value;
            }
        }

        override public int isComponentConnectionAvailable(Point p, ImageList iL)
        {
            return isInAvailable;
        }

        override public int whatKindOfCoennectionIs(Point p, ImageList iL)
        {
            return (int)TypeOfConnection.MiddleInput;
        }

        override public void invalidateConnectionValidateConnection(int typeOfConnection, int op)
        {
            isInAvailable = op;
        }

        override public void configureValues(ref List<Component> compList, ref List<Pipe> pipeList)
        {
            MessageBox.Show("Nothing can be configured here");
        }

        override public void recalcFlow(ref List<Component> compList, ref List<Pipe> pipeList) { }

        override public void FlowIn(int typeOfConnection, int flow)
        {
        }

        override public int FlowOut(int typeOfConnection)
        {
            return 0;
        }

        override public String giveMeYourValuesInText()
        {
            String resume = EType + " " + id + " " + coord.X + " " + coord.Y;
            return resume;
        }
    }
}
