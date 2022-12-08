using System;
using System.Globalization;

namespace ContractServiceInterface.Entities
{
    class Installment
    {

        public DateTime DueDate { get; set; }
        public double Amount { get; set; }
        public int Mounth { get; set; }

        public Installment(DateTime dueDate, double amount, int mounth)
        {
            DueDate = dueDate;
            Amount = amount;
            Mounth = mounth;
        }

        public override string ToString()
        {
            return " Installment: "
                + Mounth
                + " -> "
                + DueDate.ToString("dd/MM/yyyy")
                + " R$:"
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}