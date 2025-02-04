﻿using AppShopping.Libary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppShopping.Models
{
    public class Ticket
    {
        public string Number { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public TicketStatus Status { get; set; }
        public Decimal Price { get; set; }

        public string transactionID { get; set; }
    }
}
