/*
 * Author: Nathan Bean.
 * Edited by: William Raymann.
 * Purpose: To provide a View-Model for a cash register program. The ChasRegister.CashDrawer
 *          serves as the model and the MainWindow and its various controls serve as the view.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;

namespace MVVMDataBinding
{
    /// <summary>
    /// A class that controls interaction logic between the view and module
    /// for a cash register program.
    /// </summary>
    public class CashRegisterModelView : INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changes in properties in current class.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The class that stores infromation on the money in the cash register drawer
        /// and provides functionality for adding and removing money.
        /// </summary>
        CashDrawer drawer = new CashDrawer();

        /// <summary>
        /// Stores the total amount of money in the cash register.
        /// </summary>
        double TotalValue => drawer.TotalValue;

        /// <summary>
        /// Proxy property for getting and setting the number of pennies in the
        /// cash register.
        /// </summary>
        public int Pennies
        {
            get => drawer.Pennies;
            set
            {
                if (drawer.Pennies == value || value < 0) return;
                int quantity = value - drawer.Pennies;
                if (quantity > 0) drawer.AddCoin(Coins.Penny, quantity);
                else drawer.RemoveCoin(Coins.Penny, -quantity);
                InvokePropertyChanged("Pennies");
            }
        }

        /// <summary>
        /// Proxy property for getting and setting the number of nickels in the
        /// cash register.
        /// </summary>
        public int Nickels
        {
            get => drawer.Nickels;
            set
            {
                if (drawer.Nickels == value || value < 0) return;
                int quantity = value - drawer.Nickels;
                if (quantity > 0) drawer.AddCoin(Coins.Nickel, quantity);
                else drawer.RemoveCoin(Coins.Nickel, -quantity);
                InvokePropertyChanged("Nickels");
            }
        }

        /// <summary>
        /// Proxy property for getting and setting the number of dimes in the
        /// cash register.
        /// </summary>
        public int Dimes
        {
            get => drawer.Dimes;
            set
            {
                if (drawer.Dimes == value || value < 0) return;
                int quantity = value - drawer.Dimes;
                if (quantity > 0) drawer.AddCoin(Coins.Dime, quantity);
                else drawer.RemoveCoin(Coins.Dime, -quantity);
                InvokePropertyChanged("Dimes");
            }
        }

        /// <summary>
        /// Proxy property for getting and setting the number of quarters in the
        /// cash register.
        /// </summary>
        public int Quarters
        {
            get => drawer.Quarters;
            set
            {
                if (drawer.Quarters == value || value < 0) return;
                int quantity = value - drawer.Quarters;
                if (quantity > 0) drawer.AddCoin(Coins.Quarter, quantity);
                else drawer.RemoveCoin(Coins.Quarter, -quantity);
                InvokePropertyChanged("Quarters");
            }
        }

        /// <summary>
        /// Proxy property for getting and setting the number of half dollars in the
        /// cash register.
        /// </summary>
        public int HalfDollar
        {
            get => drawer.HalfDollars;
            set
            {
                if (drawer.HalfDollars == value || value < 0) return;
                int quantity = value - drawer.HalfDollars;
                if (quantity > 0) drawer.AddCoin(Coins.HalfDollar, quantity);
                else drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                InvokePropertyChanged("HalfDollar");
            }
        }

        /// <summary>
        /// Proxy property for getting and setting the number of Dollar in the
        /// cash register.
        /// </summary>
        public int Dollar
        {
            get => drawer.Dollars;
            set
            {
                if (drawer.Dollars == value || value < 0) return;
                int quantity = value - drawer.Dollars;
                if (quantity > 0) drawer.AddCoin(Coins.Dollar, quantity);
                else drawer.RemoveCoin(Coins.Dollar, -quantity);
                InvokePropertyChanged("Dollar");
            }
        }

        /// <summary>
        /// Proxy property for getting and setting the number of ones in the
        /// cash register.
        /// </summary>
        public int Ones
        {
            get => drawer.Ones;
            set
            {
                if (drawer.Ones == value || value < 0) return;
                int quantity = value - drawer.Ones;
                if (quantity > 0) drawer.AddBill(Bills.One, quantity);
                else drawer.RemoveBill(Bills.One, -quantity);
                InvokePropertyChanged("Ones");
            }
        }

        /// <summary>
        /// Proxy property for getting and setting the number of twos in the
        /// cash register.
        /// </summary>
        public int Twos
        {
            get => drawer.Twos;
            set
            {
                if (drawer.Twos == value || value < 0) return;
                int quantity = value - drawer.Twos;
                if (quantity > 0) drawer.AddBill(Bills.Two, quantity);
                else drawer.RemoveBill(Bills.Two, -quantity);
                InvokePropertyChanged("Twos");
            }
        }

        /// <summary>
        /// Proxy property for getting and setting the number of fives in the
        /// cash register.
        /// </summary>
        public int Fives
        {
            get => drawer.Fives;
            set
            {
                if (drawer.Fives == value || value < 0) return;
                int quantity = value - drawer.Fives;
                if (quantity > 0) drawer.AddBill(Bills.Five, quantity);
                else drawer.RemoveBill(Bills.Five, -quantity);
                InvokePropertyChanged("Fives");
            }
        }

        /// <summary>
        /// Proxy property for getting and setting the number of tens in the
        /// cash register.
        /// </summary>
        public int Tens
        {
            get => drawer.Tens;
            set
            {
                if (drawer.Tens == value || value < 0) return;
                int quantity = value - drawer.Tens;
                if (quantity > 0) drawer.AddBill(Bills.Ten, quantity);
                else drawer.RemoveBill(Bills.Ten, -quantity);
                InvokePropertyChanged("Tens");
            }
        }

        /// <summary>
        /// Proxy property for getting and setting the number of Twenties in the
        /// cash register.
        /// </summary>
        public int Twenty
        {
            get => drawer.Twenties;
            set
            {
                if (drawer.Twenties == value || value < 0) return;
                int quantity = value - drawer.Twenties;
                if (quantity > 0) drawer.AddBill(Bills.Twenty, quantity);
                else drawer.RemoveBill(Bills.Twenty, -quantity);
                InvokePropertyChanged("Twenty");
            }
        }

        /// <summary>
        /// Proxy property for getting and setting the number of fifties in the
        /// cash register.
        /// </summary>
        public int Fifty
        {
            get => drawer.Fifties;
            set
            {
                if (drawer.Fifties == value || value < 0) return;
                int quantity = value - drawer.Fifties;
                if (quantity > 0) drawer.AddBill(Bills.Fifty, quantity);
                else drawer.RemoveBill(Bills.Fifty, -quantity);
                InvokePropertyChanged("Fifty");
            }
        }

        /// <summary>
        /// Proxy property for getting and setting the number of hundreds in the
        /// cash register.
        /// </summary>
        public int Hundred
        {
            get => drawer.Hundreds;
            set
            {
                if (drawer.Hundreds == value || value < 0) return;
                int quantity = value - drawer.Hundreds;
                if (quantity > 0) drawer.AddBill(Bills.Hundred, quantity);
                else drawer.RemoveBill(Bills.Hundred, -quantity);
                InvokePropertyChanged("Hundred");
            }
        }

        /// <summary>
        /// Functionality for invoking the PropertyChanged event handler
        /// for all values that change in the current class when money is
        /// added or removed from the cash register.
        /// </summary>
        /// <param name="denomination">The type of money added or removed.</param>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }
    }
}
