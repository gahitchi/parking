using System;
using System.Collections.Generic;
using System.Threading;

namespace park_form
{
    internal class Parking
    {
        public Form1 Form { get; set; }
        public Semaphore EntranceSemaphore { get; set; } 
        public Semaphore SlotSemaphore { get; set; }   

        private int totSlots;
        public int TotSlots
        {
            get { return totSlots; }
            set
            {
                totSlots = value;
            }
        }

        public List<Car> CarsAwaiting { get; set; } = new List<Car>();
        public List<Car> CarsInside { get; set; } = new List<Car>();
        public List<Car> CarsExited { get; set; } = new List<Car>();

        public Parking(Form1 form)
        {
            Form = form;
            EntranceSemaphore = new Semaphore(1, 1);
            SlotSemaphore= new Semaphore(0, 10); 
            TotSlots = 10; 
        }
    }
}