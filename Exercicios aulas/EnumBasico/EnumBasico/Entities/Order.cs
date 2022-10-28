using System;
using EnumBasico.Entities.Enums;

namespace EnumBasico.Entities
{
    internal class Order
    {

        public int Id { get; set; }
        public DateTime Moment  { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return 
                "Numero do cliente: "
                + Id
                + ", "
                + "Data do pedido: "
                + Moment
                + ", "
                + "Status de pagamento: "
                + Status;
        }

    }
}
