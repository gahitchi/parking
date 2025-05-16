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
            //Random rnd = new Random();
            //Thread.Sleep(rnd.Next(1000, 3000));

            park.EntranceSemaphore.WaitOne();
            Thread.Sleep(2000);
            park.EntranceSemaphore.Release();

            park.CarsAwaiting.Remove(this);
            park.CarsInside.Add(this);
            park.Form.UpdateLists();

            Thread.Sleep(stay);

            park.CarsInside.Remove(this);
            park.SlotSemaphore.Release();
            park.CarsExited.Add(this);
            park.Form.UpdateLists();
        }
    }
}
