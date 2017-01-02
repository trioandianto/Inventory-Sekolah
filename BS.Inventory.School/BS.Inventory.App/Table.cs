using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BS.Inventory.App
{
    class Table : IInventory
    {
        protected const string prefixID = "Tbl";
        public Table(int iID, string name, Point largeMeter, char iconString = '=') {
            this.iID = string.Concat(prefixID, iID);
            this.name = name;
            this.largeMeter = largeMeter;
            this.iconString = iconString;
        }

        public string name { get;set;}

        private DateTime _buyDate;
        public DateTime buyDate
        {
            get
            {
                return _buyDate;
            }

            set
            {
                this._buyDate = value;
            }
        }

        private string _iID;
        public string iID
        {
            get
            {
                return _iID;
            }

            set
            {
                this._iID = value;
            }
        }

        private Point _largeMeter;
        public Point largeMeter
        {
            get
            {
                return _largeMeter;
            }

            set
            {
                value.X = Math.Round(value.X, 1);
                value.Y = Math.Round(value.Y, 1);
                this._largeMeter = value;
            }
        }

        private int _warrant;
        public int warrant
        {
            get
            {
                return _warrant;
            }

            set
            {
                this._warrant = value;
            }
        }

        public char iconString { get; set; }
    }
}
