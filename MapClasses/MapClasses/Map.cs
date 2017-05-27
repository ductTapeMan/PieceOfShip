using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;
using ShipClasses;
using System.Windows;
using System.Media;



namespace MapClasses
{
    public class Map
    {
        private int playerLocationX;
        private int playerLocationY;
        private KeyValuePair<int, int>[] portLocations;
        private KeyValuePair<int, int>[] landLocations;
        private ArrayList playerShips;

        public Map()
        {
            playerLocationX = 0;
            playerLocationY = 0;
            portLocations = new KeyValuePair<int, int>[0];
            landLocations = new KeyValuePair<int, int>[0];
            playerShips = new ArrayList();
        }

        public string getCurrentMapTileLocation()
        {
            return "../Images/x" + playerLocationX + "y" + playerLocationY + ".png";
        }

        public void panMapUp(int speed)
        {

        }

        public void panMapDown(int speed)
        {

        }

        public void panMapLeft(int speed)
        {

        }

        public void panMapRight(int speed)
        {

        }

        public Image loadTile(int locationX, int locationY)
        {
            return null;
        }

        private Ship[] checkForNPCShipLocations()
        {
            return null;
        }

        //TODO change return type to port class
        private void checkForPortLocations()
        {

        }
    }
}
