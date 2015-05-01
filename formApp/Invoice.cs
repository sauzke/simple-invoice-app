using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formApp
{
    public class Invoice
    {
        private List<ServiceItem> services;
        private long invoiceId;
        private long customerId;

        public Invoice() { }

        public List<ServiceItem> Services
        {
            get
            {
                return this.services;
            }
            set
            {
                this.services = value;
            }
        }

        public long InvoiceId
        {
            get
            {
                return this.invoiceId;
            }
            set
            {
                this.invoiceId = value;
            }
        }

        public long CustomerId
        {
            get
            {
                return this.customerId;
            }
            set
            {
                this.customerId = value;
            }
        }
    }
}
