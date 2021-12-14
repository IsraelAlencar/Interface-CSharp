using System;
using System.Collections.Generic;
using System.Text;

namespace PagamentoOnline.Entities {
    class Installment {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime date, double amount) {
            DueDate = date;
            Amount = amount;
        }

        public override string ToString() {
            return DueDate
                + " - "
                + Amount;
        }
    }
}
