using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CrewClasses;
using System.Windows;
using System.Media;
using System.IO;

namespace ShipClasses
{
    public abstract class Ship
    {
        protected int acceleration;
        protected int topSpeed;
        protected int speed;
        protected int turnRadius;
        protected string hullImgLocation;
        protected int hullHP;
        protected int maxHullHP;
        protected string riggingImgLocation;
        protected int riggingHP;
        protected int maxRiggingHP;
        protected ArrayList crew;   
        protected ArrayList guns;   
        protected ArrayList cargo;
        protected int maxWeight;  
        protected ArrayList captainsQuartersBonuses;    //TODO change this when decided wtf its gonna be
        protected ArrayList upgrades;   
        protected char officersQuarters; //cant remember what this is for, find out later
        protected int water;
        protected int rations; //might change into multiple types
        protected int locationX;
        protected int locationY;
        protected int frontX;
        protected int frontY;

        
        /// <summary>
        /// The configuration for a new ship with no upgrades,
        /// loss of HP or "extras". Basically the newborn baby 
        /// of ships.
        /// </summary>
        /// <param name="acceleration">How fast does it get to full vroom vroom?</param>
        /// <param name="topSpeed">The maximum vroom</param>
        /// <param name="turnRadius">How wide of a turn does this thing have to take?</param>
        /// <param name="hullImgLocation">Where is the image for the hull?</param>
        /// <param name="maxHullHP">How many boo-boos the hull can handle before sinking</param>
        /// <param name="riggingImgLocation">Where the imagry for the rigging is</param>
        /// <param name="maxRiggingHP">How any boo-boos the rigging can take until we have no vroom</param>
        /// <param name="crew">The list of idiots who run this thing</param>
        /// <param name="guns">The list of pew pew and ka-boom stuff</param>
        /// <param name="cargo">The list of crap we are carrying</param>
        /// <param name="maxWeight">How many tons this thing can handle</param>
        /// <param name="officersQuarters">IDK what this is supposed to do yet, but it will be relevant later</param>
        /// <param name="water">How much drinkable water there is (units not determined)</param>
        /// <param name="rations">Either an amount of food, or will later be a list of food and drinks</param>
        /// <param name="locationX">Where is this thing on the map's x axis</param>
        /// <param name="locationY">Where this is on the map's y axis</param>
        /// <param name="frontX">Where the front x position is for rotation purposes</param>
        /// <param name="frontY">where the front y position is for rotation purposes</param>
        public Ship(int acceleration, int topSpeed, int turnRadius, string hullImgLocation, int maxHullHP,
            string riggingImgLocation, int maxRiggingHP, ArrayList crew, ArrayList guns, ArrayList cargo,
            int maxWeight, char officersQuarters, int water, int rations, int locationX, int locationY,
            int frontX, int frontY)
        {
            this.acceleration = acceleration;
            this.topSpeed = topSpeed;
            this.speed = 0; //start not moving in this case
            this.turnRadius = turnRadius;
            this.hullImgLocation = hullImgLocation;
            this.maxHullHP = maxHullHP;
            this.hullHP = maxHullHP; //default to full health in this case
            this.riggingImgLocation = riggingImgLocation;
            this.maxRiggingHP = maxRiggingHP;
            this.riggingHP = maxRiggingHP; //set to full health in this case
            this.crew = crew;
            this.guns = guns;
            this.cargo = cargo;
            this.maxWeight = maxWeight;
            this.officersQuarters = officersQuarters;
            this.water = water;
            this.rations = rations;
            this.locationX = locationX;
            this.locationY = locationY;
            this.frontX = frontX;
            this.frontY = frontY;
        }

        /// <summary>
        /// This will load a ship's stuff from a file
        /// </summary>
        /// <param name="shipFile">The location of the file the ship is contained in</param>
        /// <param name="shipName">The identifying name for the ship within the file</param>
        public Ship(string shipFile, string shipName)
        {
            //do file IO stuff here
        }

        /// <summary>
        /// Will be used to take default values and add mods for that shit
        /// </summary>
        /// <param name="accelerationMod">Whats the vroom change difference</param>
        /// <param name="topSpeedMod">the max vroom difference</param>
        /// <param name="turnRadius">wide turn difference</param>
        /// <param name="hullImgLocation">location for what the hull looks like</param>
        /// <param name="maxHullHPMod">how many more or less boo boos can this handle</param>
        /// <param name="riggingImgLocation">location for what the rigging looks like</param>
        /// <param name="maxRiggingHPMod">how many more or less boo boos this can take before no vroom</param>
        /// <param name="crew">the idiots keeping this afloat</param>
        /// <param name="guns">the list of ka-boom and pew pew devices</param>
        /// <param name="cargo">the shit you are carrying on board</param>
        /// <param name="maxWeightMod">how much more or less this can carry</param>
        /// <param name="officersQuarters">still no clue wtf this does but whatever</param>
        /// <param name="waterMod">how much drinkable water do we have (no, they can't drink seawater idiot)</param>
        /// <param name="rationsMod">sooo more or less food? How nice are you to these people?</param>
        /// <param name="locationX">location on x axis on map</param>
        /// <param name="locationY">location on y axis on map</param>
        /// <param name="frontX">front of the ship on x location</param>
        /// <param name="frontY">front of the ship on y location</param>
        public Ship(float accelerationMod, float topSpeedMod, float turnRadius, string hullImgLocation,
            float maxHullHPMod, string riggingImgLocation, float maxRiggingHPMod, ArrayList crew,
            ArrayList guns, ArrayList cargo, float maxWeightMod, char officersQuarters,
            float waterMod, float rationsMod, int locationX, int locationY, int frontX, int frontY)
        {
            //do shit here for mods n stuff
        }


        protected int calcFreeWeight()
        {
            return this.maxWeight - this.calcTotalCargoWeight();
        }

        protected int calcTotalCargoWeight()
        {
            return 0;
        }

        /*
        This will be to move the ship location forward. This will
        use the acceleration to move forward
        */
        protected abstract bool moveForward();
        protected abstract bool moveBackward();

        /*
        This will decelerate while turning. May need to determine rate
        of deceleration later.
        */
        protected abstract bool moveLeft();
        protected abstract bool moveRight();

        /// <summary>
        /// f = forward
        /// b = backward
        /// l = left
        /// r = right
        /// </summary>
        /// <param name="direction">look at the fucking list I gave</param>
        /// <returns></returns>
        public bool move(char direction)
        {
            switch(direction)
            {
                case 'f':
                     return moveForward();
                case 'b':
                    return moveBackward();
                case 'l':
                    return moveLeft();
                case 'r':
                    return moveRight();
                default:
                    Console.WriteLine("You dun fucked up moving, wrong char value");
                    return false;
            }
        }


    }
}
