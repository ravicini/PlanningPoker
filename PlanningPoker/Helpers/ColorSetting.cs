// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ColorSetting.cs">
//     Copyright (c) Marco Ravicini. All rights reserved.  
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace PlanningPoker.Helpers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Media;

    using Caliburn.Micro;

    /// <summary>
    /// Helper class for card color settings.
    /// </summary>
    public class ColorSetting
    {
        private const string Red = "red";
        private const string Green = "green";
        private const string Blue = "blue";
        private const string Yellow = "yellow";
        private const string CardColorSettingsKey = "CardColor";

        private readonly IEnumerable<CardColor> cardColors = new List<CardColor>
            {
                new CardColor(new SolidColorBrush(Colors.Red), Red, "o"),
                new CardColor(new SolidColorBrush(Colors.Green), Green, "g"),
                new CardColor(new SolidColorBrush(Colors.Blue), Blue, "b"),
                new CardColor(new SolidColorBrush(Colors.Yellow), Yellow, "y"),
            }; 

        private readonly AppSettingsStorageMechanism storageMechanism;

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorSetting"/> class.
        /// </summary>
        /// <param name="storageMechanism">The storage mechanism.</param>
        public ColorSetting(AppSettingsStorageMechanism storageMechanism)
        {
            this.storageMechanism = storageMechanism;
        }

        /// <summary>
        /// Gets the available colors.
        /// </summary>
        public IEnumerable<CardColor> AvailableColors
        {
            get
            {
                return this.cardColors;
            }
        }

        /// <summary>
        /// Gets or sets the configured color.
        /// </summary>
        public CardColor Color
        {
            get
            {
                CardColor color = null;
                object savedColor;
                if (this.storageMechanism.TryGet(CardColorSettingsKey, out savedColor))
                {
                    color = this.cardColors.SingleOrDefault(c => c.Description == (string)savedColor);
                }

                return color ?? this.AvailableColors.First();
            }

            set
            {
                if (value != null)
                {
                    this.storageMechanism.BeginStoring();
                    this.storageMechanism.Store(CardColorSettingsKey, value.Description);
                    this.storageMechanism.EndStoring();
                }
            }
        }
    }
}