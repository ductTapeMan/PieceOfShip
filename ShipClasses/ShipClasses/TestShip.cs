using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CrewClasses;

namespace ShipClasses 
{
    class TestShip : Ship
    {
        public TestShip()
        {
            this.acceleration = 50;
            this.cargo = new ArrayList();
            this.crew = new ArrayList();
            this.freeWeight = 20;
            this.guns = new ArrayList();
            this.hullHP = 40;
            this.maxHullHP = 40;
            this.riggingHP = 40;
            this.maxRiggingHP = 40;
            this.officersQuarters = 'n';
            this.rations = 10;
            this.topSpeed = 10;
            this.turnRadius = 10;
            this.upgrades = new ArrayList();

            
        }

        public override bool moveForward()
        {
            throw new NotImplementedException();
        }

        public override bool moveLeft()
        {
            throw new NotImplementedException();
        }

        public override bool moveRight()
        {
            throw new NotImplementedException();
        }
    }
}
