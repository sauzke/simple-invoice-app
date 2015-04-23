using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formApp
{
    class ServiceItem
    {
        private long id;
        private String description;
        private double price;

        public ServiceItem(){}

        public ServiceItem(long id, String desc, double price)
        {
            this.id = id;
            this.description = desc;
            this.price = price;
        }

        public long Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public String Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public String ToString()
        {
            return this.id + "," + this.description + "," + this.price;
        }
    }
}
