// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ImageAttribute.cs">
//   Copyright (c) Marco Ravicini. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace PlanningPoker.Helpers
{
    using System;

    /// <summary>
    /// Attribute definition for an image path
    /// </summary>
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
    internal sealed class ImageAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageAttribute"/> class.
        /// </summary>
        /// <param name="path">The path.</param>
        public ImageAttribute(string path)
        {
            this.Path = path;
        }

        /// <summary>
        /// Gets the path.
        /// </summary>
        public string Path { get; private set; }
    }
}