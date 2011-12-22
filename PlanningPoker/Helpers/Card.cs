// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Card.cs">
//   Copyright (c) Marco Ravicini. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace PlanningPoker.Helpers
{
    /// <summary>
    /// Defines possible cards and the image extension.
    /// </summary>
    public enum Card
    {
        /// <summary>
        /// No card.
        /// </summary>
        [Image("")]
        None,

        /// <summary>
        /// Card 0 SP.
        /// </summary>
        [Image("0.png")]
        Zero,

        /// <summary>
        /// Card 1/2 SP.
        /// </summary>
        [Image("1_2.png")]
        Half,

        /// <summary>
        /// Card 1 SP.
        /// </summary>
        [Image("1.png")]
        One,

        /// <summary>
        /// Card 2 SP.
        /// </summary>
        [Image("2.png")]
        Two,

        /// <summary>
        /// Card 3 SP.
        /// </summary>
        [Image("3.png")]
        Three,

        /// <summary>
        /// Card 5 SP.
        /// </summary>
        [Image("5.png")]
        Five,

        /// <summary>
        /// Card 8 SP.
        /// </summary>
        [Image("8.png")]
        Eight,

        /// <summary>
        /// Card 13 SP.
        /// </summary>
        [Image("13.png")]
        Thirteen,

        /// <summary>
        /// Card 20 SP.
        /// </summary>
        [Image("20.png")]
        Twenty,

        /// <summary>
        /// Card 40 SP.
        /// </summary>
        [Image("40.png")]
        Forty,

        /// <summary>
        /// Card Break.
        /// </summary>
        [Image("break.png")]
        Break,

        /// <summary>
        /// Card more questions.
        /// </summary>
        [Image("questionmark.png")]
        Question,

        /// <summary>
        /// Card infinte (not estimatable).
        /// </summary>
        [Image("infinite.png")]
        Infinite
    }
}