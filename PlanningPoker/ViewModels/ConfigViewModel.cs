// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConfigViewModel.cs">
//     Copyright (c) Marco Ravicini. All rights reserved.  
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
 
namespace PlanningPoker.ViewModels
{
    using System.Collections.Generic;

    using Caliburn.Micro;

    using PlanningPoker.Helpers;

    /// <summary>
    /// View model for configuration page.
    /// </summary>
    public class ConfigViewModel : PropertyChangedBase
    {
        private readonly ColorSetting colorSetting;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigViewModel"/> class.
        /// </summary>
        /// <param name="colorSetting">The color setting.</param>
        public ConfigViewModel(ColorSetting colorSetting)
        {
            this.colorSetting = colorSetting;
        }

        /// <summary>
        /// Gets the available card colors.
        /// </summary>
        public IEnumerable<CardColor> CardColors
        {
            get
            {
                return this.colorSetting.AvailableColors;
            }
        }

        /// <summary>
        /// Gets or sets the configured color.
        /// </summary>
        public CardColor Color
        {
            get
            {
                return this.colorSetting.Color;
            }

            set
            {
                this.colorSetting.Color = value;
                this.NotifyOfPropertyChange(() => this.Color);
            }
        }
    }
}