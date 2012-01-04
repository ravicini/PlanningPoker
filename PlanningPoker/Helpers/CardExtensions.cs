// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CardExtensions.cs">
//   Copyright (c) Marco Ravicini. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace PlanningPoker.Helpers
{
    using System.Linq;

    /// <summary>
    /// Extension methods for card enumeration.
    /// </summary>
    public static class CardExtensions
    {
        /// <summary>
        /// Gets the path defined on the ImagePath attribute on the card enumeration member.
        /// </summary>
        /// <param name="card">The card enumeration member.</param>
        /// <returns>The defined path.</returns>
        public static string ImagePath(this Card card)
        {
            return card.GetType()
                .GetMember(card.ToString())[0]
                .GetCustomAttributes(typeof(ImageAttribute), false)
                .Cast<ImageAttribute>()
                .First().Path;
        }

        /// <summary>
        /// Gets the main text defined on the TileInfo attribute on the card enumeration member.
        /// </summary>
        /// <param name="card">The card enumeration member.</param>
        /// <returns>The defined main text.</returns>
        public static string MainText(this Card card)
        {
            return card.GetType()
                .GetMember(card.ToString())[0]
                .GetCustomAttributes(typeof(TileInfoAttribute), false)
                .Cast<TileInfoAttribute>()
                .First().Text;
        }

        /// <summary>
        /// Gets the info text defined on the TileInfo attribute on the card enumeration member.
        /// </summary>
        /// <param name="card">The card enumeration member.</param>
        /// <returns>The defined info text.</returns>
        public static string InfoText(this Card card)
        {
            return card.GetType()
                .GetMember(card.ToString())[0]
                .GetCustomAttributes(typeof(TileInfoAttribute), false)
                .Cast<TileInfoAttribute>()
                .First().Info;
        }
    }
}