﻿using System;

namespace P04.Recharge
{
    public class Robot : Worker, IRechargeable,IWorker
    {
        private int capacity;
        private int currentPower;

        public Robot(string id, int capacity) : base(id)
        {
            this.capacity = capacity;
        }

        public int Capacity
        {
            get { return this.capacity; }
        }

        public int CurrentPower
        {
            get { return this.currentPower; }
            set { this.currentPower = value; }
        }

        public override void Work(int hours)
        {
            if (hours > this.currentPower)
            {
                hours = currentPower;
            }

            this.workingHours += hours;
            this.currentPower -= hours;
        }

        public void Recharge()
        {
            this.currentPower = this.capacity;
        }

    }
}