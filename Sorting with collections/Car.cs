using System;

namespace Sorting_with_collections
{
    public class Car : IComparable
    {
        private int _year;
        private string _model, _regNo;

        public Car(string regNo, string model, int year)
        {
            this._regNo = regNo;
            this._model = model;
            this._year = year;
        }

        public string RegNo
        {
            get { return _regNo; }
        }

        public int Year
        {
            get { return _year; }
        }

        public string Model
        {
            get { return _model; }
        }

        public int CompareTo(object obj)
        {
            Car c = (Car) obj;
            return string.Compare(this.RegNo, c.RegNo);
        }

        public override string ToString()
        {
            return "Registration number: " + RegNo + "\t Model: " + Model + "\t Year: " + Year;
        }
    }
}