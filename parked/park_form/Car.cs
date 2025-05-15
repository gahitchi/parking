using System;
using System.Threading;

namespace park_form
{
    internal class Car
    {
        public int Id { get; }
        public int stay;
        private Parking park;
        private Thread carT;
        private Random rand = new Random();

        public Car(int id, Parking p)
        {
            Id = id;
            park = p;
            stay = rand.Next(4000, 15000);
            carT = new Thread(Run);
        }

        public void Start()
        {
            carT.Start();
        }

        private void Run()
        {
            park.CarsAwaiting.Remove(this);
            park.CarsInside.Add(this);
            park.Form.UpdateLists();

            Thread.Sleep(stay);

            park.CarsInside.Remove(this);
            park.CarsExited.Add(this);
            park.SlotSemaphore.Release();
            park.Form.UpdateLists();
        }
    }
}
