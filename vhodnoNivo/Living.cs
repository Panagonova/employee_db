using System;
using System.Collections.Generic;
using System.Text;

namespace vhodnoNivo
{
    class Living
    {
        private string city;
        private string street;
        private string streetNumber;
        private string block;
        private string entrance;
        private string floor;
        private string apartment;

        public Living(string city)
        {
            this.city = city;
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public string Street
        {
            get { return this.street; }
            set { this.street = value; }
        }

        public string StreetNumber
        {
            get { return this.streetNumber; }
            set { this.streetNumber = value; }
        }

        public string Block
        {
            get { return this.block; }
            set { this.block = value; }
        }

        public string Entance
        {
            get { return this.entrance; }
            set { this.entrance = value; }
        }

        public string Floor
        {
            get { return this.floor; }
            set { this.floor = value; }
        }

        public string Apartment
        {
            get { return this.apartment; }
            set { this.apartment = value; }
        }

    }
}

