// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CardViewModel.cs">
//   Copyright (c) Marco Ravicini. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace PlanningPoker.ViewModels
{
    using Caliburn.Micro;
    
    using PlanningPoker.Helpers;

    /// <summary>
    /// View Model for a card in fullscreen.
    /// </summary>
    public class CardViewModel : Screen
    {
        private readonly INavigationService navigationService;
        private Card card;
        private string cardPath;
        private bool cardIsRevealed;

        /// <summary>
        /// Initializes a new instance of the <see cref="CardViewModel"/> class.
        /// </summary>
        /// <param name="navigationService">The navigation service.</param>
        public CardViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        /// <summary>
        /// Gets or sets the path to the card image.
        /// </summary>
        public string CardPath
        {
            get
            {
                return this.cardPath;
            }

            set
            {
                this.cardPath = value;
                this.NotifyOfPropertyChange(() => this.CardPath);
            }
        }

        /// <summary>
        /// Gets or sets the card.
        /// </summary>
        public Card Card
        {
            get
            {
                return this.card;
            }

            set
            {
                this.card = value;
                this.Reset();
            }
        }

        /// <summary>
        /// Reveals this the card, or navigates back if already revealed.
        /// </summary>
        public void Reveal()
        {
            if (!this.cardIsRevealed)
            {
                this.CardPath = Constants.CardImagePath + "y" + this.Card.ImagePath();
                this.cardIsRevealed = true;
            }
            else
            {
                this.navigationService.GoBack();
            }
        }

        private void Reset()
        {
            this.cardIsRevealed = false;
            this.CardPath = Constants.BacksideCardPath;
        }
    }
}