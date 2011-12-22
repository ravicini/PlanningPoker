// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SelectCardViewModel.cs">
//   Copyright (c) Marco Ravicini. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace PlanningPoker.ViewModels
{
    using System;

    using Caliburn.Micro;

    using PlanningPoker.Helpers;

    /// <summary>
    /// View model for card selection screen.
    /// </summary>
    public class SelectCardViewModel
    {
        private readonly INavigationService navigationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectCardViewModel"/> class.
        /// </summary>
        /// <param name="navigationService">The navigation service.</param>
        public SelectCardViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        /// <summary>
        /// Gets the action which will be performed when a tile gets selected.
        /// </summary>
        public Action<Card> TileSelected
        { 
            get
            {
                return this.Navigate;
            }
        }

        private void Navigate(Card card)
        {
            this.navigationService
                .UriFor<CardViewModel>()
                .WithParam(viewModel => viewModel.Card, card)
                .Navigate();
        }
    }
}