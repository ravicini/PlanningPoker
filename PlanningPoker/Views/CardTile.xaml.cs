// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CardTile.xaml.cs">
//   Copyright (c) Marco Ravicini. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace PlanningPoker.Views
{
    using System;
    using System.Windows;
    using System.Windows.Media.Imaging;

    using PlanningPoker.Helpers;

    /// <summary>
    /// User control for a card tile on the selection screen.
    /// </summary>
    public partial class CardTile
    {
        /// <summary>
        /// Dependency property for a card.
        /// </summary>
        public static readonly DependencyProperty CardProperty =
            DependencyProperty.Register("Card", typeof(Card), typeof(CardTile), new PropertyMetadata(default(Card)));

        /// <summary>
        /// Dependency property for click command action.
        /// </summary>
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof(Action<Card>), typeof(CardTile), new PropertyMetadata(default(Action<Card>)));

        /// <summary>
        /// Initializes a new instance of the <see cref="CardTile"/> class.
        /// </summary>
        public CardTile()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the card.
        /// </summary>
        public Card Card
        {
            get
            {
                return (Card)GetValue(CardProperty);
            }

            set
            {
                SetValue(CardProperty, value);
                this.SetImage(value);
            }
        }

        /// <summary>
        /// Gets or sets the command.
        /// </summary>
        public Action<Card> Command
        {
            get
            {
                return (Action<Card>)GetValue(CommandProperty);
            }

            set
            {
                SetValue(CommandProperty, value);
            }
        }

        private void OnImageTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            this.Command.Invoke(this.Card);
        }

        private void SetImage(Card card)
        {
            this.image.Source = new BitmapImage(new Uri(ImagePathConstants.TileImagePath + card.ImagePath(), UriKind.Relative));
        }
    }
}
