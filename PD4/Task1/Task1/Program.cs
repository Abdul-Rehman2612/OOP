using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            List<Ship> shipList = new List<Ship>();
            while(true)
            {
                Console.Clear();
                string option = Menu();
                if(option=="1")
                {
                    Console.Clear();
                    Ship s = AddShip();
                    if(ShipCheck(shipList,s.SerialNumber)==false)
                    {
                        shipList.Add(s);
                        Console.WriteLine("Ship Added successfully!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Ship already exist!");
                        Console.ReadKey();
                    }    
                }
                else if (option=="2")
                {
                    Console.Clear();
                    ViewShipPosition(shipList);
                }
                else if (option=="3")
                {
                    Console.Clear();
                    ViewSerialNumber(shipList);
                }
                else if (option=="4")
                {
                    Console.Clear();
                    UpdatePosition(shipList);
                }
                else if (option=="5")
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Wrong user Input!");
                    Console.ReadKey();
                }
            }
        }
        static string Menu()
        {
            Console.WriteLine("1.Add Ship");
            Console.WriteLine("2.View Ship Position");
            Console.WriteLine("3.View Ship Serial Number");
            Console.WriteLine("4.Change Ship Position");
            Console.WriteLine("5.Exit");
            Console.Write("Enter option...");
            return Console.ReadLine();
        }
        static Ship AddShip()
        {
            Console.Write("Enter Ship Number: ");
            string ShipName=Console.ReadLine();
            Console.WriteLine("Enter Ship Latitude: ");
            Console.Write("Enter Latitude’s Degree: ");
            int LatitudeDegree=int.Parse(Console.ReadLine());
            Console.Write("Enter Latitude’s Minute: ");
            float LatitudeMinutes=float.Parse(Console.ReadLine());
            Console.Write("Enter Latitude’s Direction: ");
            char LatitudeDirection=char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ship Longitude: ");
            Console.Write("Enter Longitude’s Degree: ");
            int LongitudeDegree=int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude’s Minute: ");
            float LongitudeMinutes = float.Parse(Console.ReadLine());
            Console.Write("Enter Longitude’s Direction: ");
            char LongitudeDirection = char.Parse(Console.ReadLine());
            Ship s=new Ship(ShipName,LatitudeDegree,LatitudeMinutes,LatitudeDirection,LongitudeDegree,LongitudeMinutes,LongitudeDirection);
            return s;
        }
        static bool ShipCheck(List<Ship> shipsList,string shipName)
        {
            foreach (Ship ship in shipsList)
            {
                if(ship.SerialNumber == shipName)
                {
                    return true;
                }
            }
            return false;
        }
        static int IndexCheck(List<Ship> shipList, string shipName)
        {
            for (int i=0;i<shipList.Count; i++)
            {
                if (shipList[i].SerialNumber == shipName)
                {
                    return i;
                }
            }
            return -1;
        }
        static void ViewShipPosition(List<Ship> shipsList)
        {
            Console.Write("Enter Ship Serial Number: ");
            string shipnumber=Console.ReadLine();
            if(ShipCheck(shipsList, shipnumber)==true)
            {
                int i=IndexCheck(shipsList,shipnumber);
                Console.WriteLine($"{"Ship is at: "}{shipsList[i].Latitude.degree+"\u00b0"+shipsList[i].Latitude.minutes+"'"+shipsList[i].Latitude.direction+" and "+shipsList[i].Longitude.degree+"\u00b0"+shipsList[i].Longitude.minutes+"'"+shipsList[i].Longitude.direction}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ship not found!");
                Console.ReadKey();
            }
        }
        static int Index(Angle Latitude, Angle Longitude, List<Ship> shipsList)
        {
            for (int i = 0; i<shipsList.Count; i++)
            {
                if (Latitude.degree==shipsList[i].Latitude.degree && Latitude.minutes==shipsList[i].Latitude.minutes && Latitude.direction==shipsList[i].Latitude.direction)
                {
                    if(Longitude.degree==shipsList[i].Longitude.degree && Longitude.minutes==shipsList[i].Longitude.minutes && Longitude.direction==shipsList[i].Longitude.direction)
                    {
                        return i;
                    }
                }
            }
            return -1;
         }
        static void ViewSerialNumber(List<Ship> shipList)
        {
            Console.WriteLine("Enter Ship Latitude: ");
            Console.Write("Enter Latitude’s Degree: ");
            int LatitudeDegree = int.Parse(Console.ReadLine());
            Console.Write("Enter Latitude’s Minute: ");
            float LatitudeMinutes = float.Parse(Console.ReadLine());
            Console.Write("Enter Latitude’s Direction: ");
            char LatitudeDirection = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ship Longitude: ");
            Console.Write("Enter Longitude’s Degree: ");
            int LongitudeDegree = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude’s Minute: ");
            float LongitudeMinutes = float.Parse(Console.ReadLine());
            Console.Write("Enter Longitude’s Direction: ");
            char LongitudeDirection = char.Parse(Console.ReadLine());
            Angle Latitude = new Angle(LatitudeDegree, LatitudeMinutes, LatitudeDirection);
            Angle Longitude = new Angle(LongitudeDegree, LongitudeMinutes, LongitudeDirection);
            int idx = Index(Latitude, Longitude, shipList);
            if(idx>-1)
            {
                Console.WriteLine("Serial Number: "+shipList[idx].SerialNumber);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ship not found!");
                Console.ReadKey();
            }
        }
        static void UpdatePosition(List<Ship> shipList)
        {
            Console.WriteLine("Enter Ship Number: ");
            string ShipName = Console.ReadLine();
            if(ShipCheck(shipList,ShipName)==true)
            {
                int idx = IndexCheck(shipList, ShipName);
                Console.WriteLine("Enter Ship Latitude: ");
                Console.Write("Enter Latitude’s Degree: ");
                int LatitudeDegree = int.Parse(Console.ReadLine());
                Console.Write("Enter Latitude’s Minute: ");
                float LatitudeMinutes = float.Parse(Console.ReadLine());
                Console.Write("Enter Latitude’s Direction: ");
                char LatitudeDirection = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter Ship Longitude: ");
                Console.Write("Enter Longitude’s Degree: ");
                int LongitudeDegree = int.Parse(Console.ReadLine());
                Console.Write("Enter Longitude’s Minute: ");
                float LongitudeMinutes = float.Parse(Console.ReadLine());
                Console.Write("Enter Longitude’s Direction: ");
                char LongitudeDirection = char.Parse(Console.ReadLine());
                Angle Latitude = new Angle(LatitudeDegree, LatitudeMinutes, LatitudeDirection);
                Angle Longitude = new Angle(LongitudeDegree, LongitudeMinutes, LongitudeDirection);
                shipList[idx].ChangeShipPosition(Latitude, Longitude);
                Console.WriteLine("Ship position updated!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ship not found!");
                Console.ReadKey();
            }
        }
    }
}
