/*
 * Author: Nathan Bean.
 *  Edity by: William Raymann.
 *  Purpose: To provide controls for increasing and decreasing the number of a
 *           certain type of bill in the cash register.
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
using CashRegister;

namespace MVVMDataBinding
{
    /// <summary>
    /// Interaction logic for BillControl.xaml
    /// </summary>
    public partial class BillControl : UserControl
    {
        /// <summary>
        /// Acts a backing for the Denomination property.
        /// </summary>
        public static readonly DependencyProperty DenominationProperty =
            DependencyProperty.Register(
                "Denomination",                    /* Property name. */
                typeof(Bills),                     /* Type of property represented. */
                typeof(BillControl),               /* Type of control for the represented */
                new PropertyMetadata(Bills.One)    /* Metadata for the represented */
                );

        /// <summary>
        /// Acts as backing for the Quantity property.
        /// </summary>
        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register(
                "Quantity",                        /* Property name. */
                typeof(int),                       /* Type of property represented. */
                typeof(BillControl),               /* Type of control for the represented */
                new FrameworkPropertyMetadata(     /* Metadata for the represented */
                    0,
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault
                    )
                );

        /// <summary>
        /// A property for getting and setting the DenominationProperty.
        /// </summary>
        public Bills Denomination
        {
            get { return (Bills)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }

        /// <summary>
        /// Property for getting and setting the QuantityProperty.
        /// </summary>
        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set { SetValue(QuantityProperty, value); }
        }

        /// <summary>
        /// Returns a WPF that allows the user to adjust the number of one type of 
        /// bills in the cash register.
        /// </summary>
        public BillControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Increases the quantity of the represented bill when the "+"
        /// button is pressed.
        /// </summary>
        /// <param name="sender">The "+" button for the represented bill.</param>
        /// <param name="e">Event args for the "+" button click.</param>
        public void OnAddClicked(object sender, RoutedEventArgs e)
        {
            Quantity++;
        }

        /// <summary>
        /// Decreases the quantity of the represented bill when the "-"
        /// button is pressed.
        /// </summary>
        /// <param name="sender">The "-" button for the represented coin.</param>
        /// <param name="e">Event args for the "-" button click.</param>
        public void OnRemoveClicked(object sender, RoutedEventArgs e)
        {
            Quantity--;
        }
    }
}
