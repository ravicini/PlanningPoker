// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TileInfoAttribute.cs">
//     Copyright (c) Marco Ravicini. All rights reserved.  
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace PlanningPoker.Helpers
{
    using System;

    /// <summary>
    /// Attribute definition for card text and description.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
    public sealed class TileInfoAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TileInfoAttribute"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="info">The info.</param>
        public TileInfoAttribute(string text, string info)
        {
            this.Text = text;
            this.Info = info;
        }

        /// <summary>
        /// Gets the text.
        /// </summary>
        public string Text { get; private set; }

        /// <summary>
        /// Gets the info.
        /// </summary>
        public string Info { get; private set; }
    }
}