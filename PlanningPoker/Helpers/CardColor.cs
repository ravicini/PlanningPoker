// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CardColor.cs">
//     Copyright (c) Marco Ravicini. All rights reserved.  
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace PlanningPoker.Helpers
{
    using System.Windows.Media;

    /// <summary>
    /// Defines a card color.
    /// </summary>
    public class CardColor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardColor"/> class.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <param name="description">The description.</param>
        /// <param name="pathAddition">The path addition.</param>
        public CardColor(Brush color, string description, string pathAddition)
        {
            this.Color = color;
            this.Description = description;
            this.PathAddition = pathAddition;
        }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        public Brush Color { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the path addition.
        /// </summary>
        public string PathAddition { get; set; }
    }
}