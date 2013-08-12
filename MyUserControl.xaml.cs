using System;
using System.Collections.Generic;
using System.Linq;
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

namespace UserControlPattern
{
    /// <summary>
    /// Interaction logic for MyUserControl.xaml
    /// </summary>
    public partial class MyUserControl : UserControl
    {

        #region Label DP

        public Object Label
        {
            get { return (Object)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(Object), typeof(MyUserControl), new UIPropertyMetadata(null));
        
        #endregion

        #region Value DP

        /// <summary>
        /// Gets or sets the Label which is displayed next to the field
        /// </summary>
        public String Value
        {
            get { return (String)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        /// <summary>
        /// Identified the Label dependency property
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(string),
              typeof(MyUserControl), new PropertyMetadata(""));

        #endregion

        public MyUserControl()
        {
            InitializeComponent();
        }
    }
}
