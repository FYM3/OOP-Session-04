using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_05_OOP_04.Driver
{
    public class Driver
    {
		private int _DriverId;

		private string _FullName = string.Empty;

		private int _PhoneNumber;

		public int DriverId
        {
			get { return _DriverId; }
			set
			{
				if (value > 0)
					_DriverId = value;
			}
		}

        public string FullName
        {
            get { return _FullName; }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                    _FullName = value;
            }
        }

        public int PhoneNumber
        {
            get { return _PhoneNumber; }
            set
            {
                if (value > 0)
                    _PhoneNumber = value;
            }
        }
    }
}
