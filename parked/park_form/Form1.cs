using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace park_form
{
    public partial class Form1 : Form
    {
        private Parking parking;
        private List<Car> cars = new List<Car>();
        private Thread simulationThread;
        private bool isRunning = true;

        public Form1()
        {
            InitializeComponent();

            parking = new Parking(this);

            for (int i = 1, j = 11; i <= 10; i++, j++)
            {
                Car newCar = new Car(i+j, parking);
                cars.Add(newCar);
                parking.CarsAwaiting.Add(newCar);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1200, 800);
        }

        public void UpdateLists()
        {
            if (InvokeRequired)
            {
                Invoke((Action)(() => UpdateLists()));
                return;
            }

            awaitingList.Items.Clear();
            foreach (Car c in parking.CarsAwaiting)
            {
                awaitingList.Items.Add(c.Id);
            }

            slots.Items.Clear();
            foreach (Car c in parking.CarsInside)
            {
                slots.Items.Add(c.Id);
            }

            exited.Items.Clear();
            foreach (Car c in parking.CarsExited)
            {
                exited.Items.Add(c.Id);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            simulationThread = new Thread(() =>
            {
                while (isRunning && parking.CarsAwaiting.Count > 0)
                {
                    if (parking.SlotSemaphore.WaitOne(0))
                    {
                        Car nextCar = parking.CarsAwaiting[0];
                        nextCar.Start();
                        Thread.Sleep(1000);
                    }

                    Thread.Sleep(100);
                }
            });

            simulationThread.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRunning = false;
            simulationThread?.Join(1000);
        }
    }
}
