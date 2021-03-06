﻿namespace EquipmentLibrary
{
    /// <summary>
    /// Aggeregates all information about an Equipment Manufacturer
    /// </summary>
    public class Manufacturer
    {
        Address mnfctrrAdd;
        static Manufacturer manufacturerInstance;
        string email_add;
        string contact_number;
        string name;

        public Address MnfctrrAdd
        {
            get { return mnfctrrAdd; }
            set { mnfctrrAdd = value; }
        }
        public string Email_add
        {
            get { return email_add; }
            set { email_add = value; }
        }
        public string Contact_number
        {
            get { return contact_number; }
            set { contact_number = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Creates an instance of the manufacturer class
        /// </summary>
        /// <param name="name">The name of the manufacturing company</param>
        /// <param name="add">Address of the company</param>
        /// <param name="email">Service/Helpdesk e-mail address</param>
        /// <param name="contact">Hotline/Service number</param>
        public Manufacturer(string name, Address add, string email, string contact)
        {
            this.Name = name;
            MnfctrrAdd = add;
            Email_add = email;
            Contact_number = contact;
        }

        /// <summary>
        /// Creates an instance of the manufacturer class
        /// </summary>
        /// <param name="name">The manufacturing company's name.</param>
        public Manufacturer(string name, Address address)
        {
            this.Name = name;
            this.mnfctrrAdd = address;
        }

        public static Manufacturer CreateManufacturer(string name, Address add, string email, string contact)
        {
            if (manufacturerInstance == null)
            {
                manufacturerInstance = new Manufacturer(name, add, email, contact);
            }

            return manufacturerInstance;
        }

        public static Manufacturer CreateManufacturer(string name, Address address)
        {
            if (manufacturerInstance == null)
            {
                manufacturerInstance = new Manufacturer(name, address);
            }

            return manufacturerInstance;
        }
    }
}
