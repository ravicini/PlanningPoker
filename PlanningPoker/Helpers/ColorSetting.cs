// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ColorSetting.cs">
//     Copyright (c) Marco Ravicini. All rights reserved.  
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
// 
namespace PlanningPoker.Helpers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Media;

    using Caliburn.Micro;

    public class ColorSetting
    {
        private const string CardColorSettingsKey = "CardColor";

        public const string Red = "red";
        public const string Green = "green";
        public const string Blue = "blue";
        public const string Yellow = "yellow";

        private readonly IEnumerable<CardColor> cardColors = new List<CardColor>
            {
                new CardColor(new SolidColorBrush(Colors.Red), Red, "o"),
                new CardColor(new SolidColorBrush(Colors.Green), Green, "g"),
                new CardColor(new SolidColorBrush(Colors.Blue), Blue, "b"),
                new CardColor(new SolidColorBrush(Colors.Yellow), Yellow, "y"),
            }; 

        private readonly AppSettingsStorageMechanism storageMechanism;

        public ColorSetting(AppSettingsStorageMechanism storageMechanism)
        {
            this.storageMechanism = storageMechanism;
        }

        public IEnumerable<CardColor> AvailableColors
        {
            get
            {
                return this.cardColors;
            }
        }

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

                return color ?? AvailableColors.First();
            }

            set
            {
                this.storageMechanism.BeginStoring();
                this.storageMechanism.Store(CardColorSettingsKey, value.Description);
                this.storageMechanism.EndStoring();
            }
        }
    }
}