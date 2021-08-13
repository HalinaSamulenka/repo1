using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    public class Car
    {
        //record details of car (properties)
        public int bay;
        private string regnumber;
        private string make;
        private string model;
        private int year;
        private int price;
        private string filename;

        public Car()
        {
        }
        //create car
        public Car(int bay, string regnumber, string make, string model, int year, int price, string filename)
        {
            this.bay = bay;
            this.regnumber = regnumber;
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
            this.filename = filename;
        }

        public void SetBay(int newValue)
        {
            //set a new value
            bay = newValue;
        }
        public int GetBay()
        {
            //return property vallue
            return bay;
        }
        public void SetRegnumber(string newValue)
        {
            regnumber = newValue;
        }
        public string GetRegnumber()
        {
            return regnumber;
        }

        public void SetMake(string newValue)
        {
            make = newValue;
        }
        public string GetMake()
        {
            return make;
        }
        public void SetModel(string newValue)
        {
            model = newValue;
        }
        public string GetModel()
        {
            return model;
        }
        public void SetYear(int newValue)
        {
            year = newValue;
        }
        public int GetYear()
        {
            return year;
        }
        public void SetPrice(int newValue)
        {
            price = newValue;
        }
        public int GetPrice()
        {
            return price;
        }
        public void SetFilename(string newValue)
        {
            filename = newValue;
        }
        public string GetFilename()
        {
            return filename;
        }
        public override string ToString()
        {
            //override properties in subclass
            return $"[Bay: {bay}], registration number: {regnumber}, make: {make}, model: {model}, year: {year}, price: {price}, photo {filename}";
        }

    }
}

