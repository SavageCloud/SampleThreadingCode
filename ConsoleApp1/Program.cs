using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("process started at: " + DateTime.Now.ToString());

            var hotelTask = Task.Factory.StartNew(BookHotel);
            var carTask = Task.Factory.StartNew(BookCar);
            var planeTask = Task.Factory.StartNew(BookPlane);

            Task.WaitAll(hotelTask, carTask, planeTask);
            
            Console.WriteLine("process ended at: " + DateTime.Now.ToString());

            Console.ReadLine();

        }

        static Random rand = new Random();

        private static void BookHotel()
        {

            Console.WriteLine("Booking hotel......");
            Thread.Sleep(2000);
            Console.WriteLine("Hotel Booked :" + " " + rand.Next(100).ToString());


        }

        private static void BookCar()
        {

            Console.WriteLine("Booking car......");
            Thread.Sleep(3000);
            Console.WriteLine("Car Booked :" + " " + rand.Next(200).ToString());
        }

        private static void BookPlane()
        {

            Console.WriteLine("Booking plane......");
            Thread.Sleep(5000);
            Console.WriteLine("Plane Booked :" + " " + rand.Next(300).ToString());
        }
    }
}
