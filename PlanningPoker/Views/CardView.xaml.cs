// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CardView.xaml.cs">
//   Copyright (c) Marco Ravicini. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace PlanningPoker.Views
{
    using System.Windows;

    using Microsoft.Phone.Controls;

    using PlanningPoker.Helpers;

    /// <summary>
    /// Page for displaying a whole card.
    /// </summary>
    public partial class CardView : PhoneApplicationPage
    {
        /// <summary>
        /// Card set in view.
        /// </summary>
        public static readonly DependencyProperty CardProperty =
            DependencyProperty.Register("Card", typeof(Card), typeof(CardView), new PropertyMetadata(default(Card)));

        /// <summary>
        /// Initializes a new instance of the <see cref="CardView"/> class.
        /// </summary>
        public CardView()
        {
            InitializeComponent();
        }
    }
}