using System;
using System.Collections.Generic;
using System.Text;

namespace TjuvPolisGame
{
    // Kunde jag gett Person en lista "Items" och använt override i subklasserna för att ge dem specifikt namngivna Item-listor?
    // Då hade jag kanske kunnat kolla listornasinnehåll och överföra Items mellan personer utan att göra separata metoder för Belongings, Confiscated och Swag?
    class Person
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public int XDirection { get; set; }
        public int YDirection { get; set; }
        public Person(int xPosition, int yPosition, int xDirection, int yDirection)
        {
            XPosition = xPosition;
            YPosition = yPosition;
            XDirection = xDirection;
            YDirection = yDirection;
        }
    }
    class Citizen : Person
    {
        public List<Item> Belongings { get; set; }
        public Citizen(int xPosition, int yPosition, int xDirection, int yDirection, List<Item> belongings) :
            base(xPosition, yPosition, xDirection, yDirection)
        {
            Belongings = belongings;
        }
    }
    class Police : Person
    {
        public List<Item> ConfiscatedItems { get; set; }
        public Police(int xPosition, int yPosition, int xDirection, int yDirection, List<Item> confiscatedItems) :
            base(xPosition, yPosition, xDirection, yDirection)
        {
            ConfiscatedItems = confiscatedItems;
        }
    }
    class Thief : Person
    {
        public int IdNumber { get; set; }
        public List<Item> Swag { get; set; }
        public bool IsInPrison { get; set; }
        public DateTime TimeOfCapture { get; set; }
        //public double TimeInPrison { get; set; }

        public Thief(int idNumber, int xPosition, int yPosition, int xDirection, int yDirection, List<Item> swag, bool isInPrison, DateTime timeOfCapture/*,*/
            /*double timeInPrison*/) :
            base(xPosition, yPosition, xDirection, yDirection)
        {
            IdNumber = idNumber;
            Swag = swag;
            IsInPrison = isInPrison;
            TimeOfCapture = timeOfCapture;
            //TimeInPrison = timeInPrison;
        }
    }
}
