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
    }
}