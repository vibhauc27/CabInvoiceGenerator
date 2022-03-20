using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    //RideRepository class for rides list
    public class RideRepository
    {
        //Dictionary to store user id and rides in the list

        Dictionary<string, List<Ride>> userRides = null;

        //constructor to create dictionary
        public RideRepository()
        {
            this.userRides = new Dictionary<string, List<Ride>>();
        }

        //Function to add ride list to specified user ids
        public void AddRide(string userId, Ride[] rides)
        {
            bool rideList = this.userRides.ContainsKey(userId);
            try
            {
                if (!rideList)
                {
                    List<Ride> list = new List<Ride>();
                    list.AddRange(rides);
                    this.userRides.Add(userId, list);
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDES, "Rides are null");
            }
        }

        //Function to get ride list as an array for specified user ids

        public Ride[] getRides(string userId)
        {
            bool rideList = this.userRides.ContainsKey(userId);
            try
            {
                return this.userRides[userId].ToArray();
            }
            catch (Exception)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_USER_ID, "Invalid user ID");
            }
        }

    }
}
