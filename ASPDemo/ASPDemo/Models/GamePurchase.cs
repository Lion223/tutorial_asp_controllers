using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDemo.Models
{
    public class GamePurchase
    {
        public int GamePurchaseId { get; set; }
        public string Person { get; set; }
        public string Address { get; set; }
        public int GameId { get; set; }
        public DateTime Date { get; set; }
    }
}