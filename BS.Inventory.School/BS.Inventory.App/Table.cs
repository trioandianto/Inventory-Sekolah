using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Inventory.App
{
    class Table : IInventory
    {
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

        private decimal _largeMeter;
        public decimal largeMeter
        {
            get
            {
                return _largeMeter;
            }

            set
            {
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
    }
}
