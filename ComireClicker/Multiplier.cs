﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ComireClicker
{
    internal class Multiplier
    {
        private string name;
        private string id;
        private string imageURI;
        private double gameMultiplier;
        private double startingCost;
        private double costIncreaseAmount;
        private int totalAmountInGame;
        private double currentCost;
        private double numInGame;
        bool isUnlocked = false;

        // Maple, MapleLeafURI, 0.25, 1000, 100, 25, true

        /*if(Maple.IsUnlocked){
         * }
         * 
         * 
         */

        public string Name { get { return name; } set { name = value; } }
        public string Id { get { return id; } set { id = value; } }
        public string ImageURI { get { return imageURI; } set { imageURI = value; } }
        public double GameMultiplier { get { return gameMultiplier; } set { gameMultiplier = value; } }
        public double StartingCost { get { return startingCost; } set { startingCost = value; } }
        public double CostIncreaseAmount { get { return costIncreaseAmount; } set { costIncreaseAmount = value; } }
        public bool IsUnlocked { get { return isUnlocked; } set { isUnlocked = value; } }
        public double GameCurrentAmount {  get { return currentCost; } set { currentCost = value; } }
        public double NumInGame {  get { return numInGame; } set { numInGame = value; increaseCurrentAmount(); } }

        
        public Multiplier() { }
        public Multiplier(string id, string name, string imageURI, double gameMultiplier, double startCost, double costIncrease, int numInGame, bool isUnlocked)
        {
            Id = id;
            Name= name;
            ImageURI= imageURI;
            GameMultiplier = gameMultiplier;
            StartingCost = startCost;
            CostIncreaseAmount = costIncrease;
            IsUnlocked = isUnlocked;
            NumInGame = numInGame;
            currentCost = startCost;
            
        }
       

        public void increaseCurrentAmount()
        {
            currentCost += CostIncreaseAmount;
        } 

    }
}
