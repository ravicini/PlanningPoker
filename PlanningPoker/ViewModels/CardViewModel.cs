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

        private readonly ColorSetting colorSetting;

        private Card card;

        private string cardPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="CardViewModel"/> class.
        /// </summary>
        /// <param name="navigationService">The navigation service.</param>
        /// <param name="colorSetting">The color setting.</param>
        public CardViewModel(INavigationService navigationService, ColorSetting colorSetting)
        {
            this.navigationService = navigationService;
            this.colorSetting = colorSetting;
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
                this.SetCardPath();
            }
        }

        public string CardBacksidePath
        {
            get
            {
                return Constants.BacksideCardPath;
            }
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
        
        public void Close()
        {
            this.navigationService.GoBack();
        }

        private void SetCardPath()
        {
            this.CardPath = Constants.CardImagePath + this.colorSetting.Color.PathAddition + this.Card.ImagePath();
        }
    }
}