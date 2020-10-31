using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{

    public class InvoiceSummary
    {
        public double totalFare;

        // Variables.
        private int numberOfRides;
        private double Fare;
        private double averageFare;

        /// <summary>
        /// Parameter Constructor For Setting Data.
        /// </summary>
        /// <param name="numberOfRides"></param>
        /// <param name="totalFare"></param>
        public InvoiceSummary(int numberOfRides, double totalFare)
        {
            //Setting Data.
            this.numberOfRides = numberOfRides;
            this.Fare = totalFare;
            this.averageFare = this.Fare / this.numberOfRides;
        }

        /// <summary>
        /// Overriding Equals Method.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is InvoiceSummary)) return false;

            InvoiceSummary inputedObject = (InvoiceSummary)obj;
            return this.numberOfRides == inputedObject.numberOfRides && this.Fare == inputedObject.Fare && this.averageFare == inputedObject.averageFare;
        }

        /// <summary>
        /// Overriding GetHashCode Method.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.numberOfRides.GetHashCode() ^ this.Fare.GetHashCode() ^ this.averageFare.GetHashCode();
        }
    }


}
