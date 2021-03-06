﻿namespace OrderMatcher
{
    public class Order
    {
        public bool IsBuy { get; set; }
        public OrderId OrderId { get; set; }
        public ulong Sequnce { get; set; }
        public Quantity OpenQuantity { get; set; }
        public Price Price { get; set; }
        public bool IsTip { get; set; }
        public bool IsStop { get; set; }
        public int CancelOn { get; set; }
        public Quantity Cost { get; set; }
        public Quantity Fee { get; set; }//TODO serialize fee
        public short FeeId { get; set; }
        public bool IsFilled
        {
            get
            {
                return OpenQuantity == 0;
            }
        }
    }

    public class OrderWrapper
    {
        public Quantity TipQuantity { get; set; }
        public Quantity TotalQuantity { get; set; }
        public Quantity OrderAmount { get; set; }
        public Price StopPrice { get; set; }
        public OrderCondition OrderCondition { get; set; }
        public Order Order { get; set; }
    }

    public class Iceberg
    {
        public Quantity TipQuantity { get; set; }
        public Quantity TotalQuantity { get; set; }
    }
}
