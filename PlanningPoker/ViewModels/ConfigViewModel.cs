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

    public class ConfigViewModel : PropertyChangedBase
    {
        private readonly ColorSetting colorSetting;

        public ConfigViewModel(ColorSetting colorSetting)
        {
            this.colorSetting = colorSetting;
        }

        public IEnumerable<CardColor> CardColors
        {
            get
            {
                return this.colorSetting.AvailableColors;
            }
        }

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