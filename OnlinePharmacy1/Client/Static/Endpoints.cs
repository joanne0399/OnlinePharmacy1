using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy1.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string ConsultationsEndpoint = $"{Prefix}/consultations";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
        public static readonly string MedicationsEndpoint = $"{Prefix}/medications";
        public static readonly string OrdersEndpoint = $"{Prefix}/orders";
        public static readonly string OrderItemEndpoint = $"{Prefix}/orderitems";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
    }
}
