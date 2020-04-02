/*
 * Author: Nathan Bean.
 * Edited by: William Raymann.
 * Purpose: To use the BillControl and CoinControl controls to allow the user to 
 *          increment or decrement the number of coins and bills of all types in 
 *          in the cash register.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVMDataBinding
{
    /// <summary>
    /// Interaction logic for CashRegisterControl.xaml
    /// </summary>
    public partial class CashRegisterControl : UserControl
    {
        /// <summary>
        /// Creates a WPF that uses bill and coin controls to allow user to change
        /// all bill and coin amounts in the cash register.
        /// </summary>
        public CashRegisterControl()
        {
            InitializeComponent();
        }
    }
}
