﻿// --------------------------------------------------------------------------------------------------------------------
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
        [TileInfo("", "")]
        None,

        /// <summary>
        /// Card 0 SP.
        /// </summary>
        [Image("0.png")]
        [TileInfo("0", "already done")]
        Zero,

        /// <summary>
        /// Card 1/2 SP.
        /// </summary>
        [Image("1_2.png")]
        [TileInfo("½", Constants.StoryPoint)]
        Half,

        /// <summary>
        /// Card 1 SP.
        /// </summary>
        [Image("1.png")]
        [TileInfo("1", Constants.StoryPoint)]
        One,

        /// <summary>
        /// Card 2 SP.
        /// </summary>
        [Image("2.png")]
        [TileInfo("2", Constants.StoryPoints)]
        Two,

        /// <summary>
        /// Card 3 SP.
        /// </summary>
        [Image("3.png")]
        [TileInfo("3", Constants.StoryPoints)]
        Three,

        /// <summary>
        /// Card 5 SP.
        /// </summary>
        [Image("5.png")]
        [TileInfo("5", Constants.StoryPoints)]
        Five,

        /// <summary>
        /// Card 8 SP.
        /// </summary>
        [Image("8.png")]
        [TileInfo("8", Constants.StoryPoints)]
        Eight,

        /// <summary>
        /// Card 13 SP.
        /// </summary>
        [Image("13.png")]
        [TileInfo("13", Constants.StoryPoints)]
        Thirteen,

        /// <summary>
        /// Card 20 SP.
        /// </summary>
        [Image("20.png")]
        [TileInfo("20", Constants.StoryPoints)]
        Twenty,

        /// <summary>
        /// Card 40 SP.
        /// </summary>
        [Image("40.png")]
        [TileInfo("40", Constants.StoryPoints)]
        Forty,

        /// <summary>
        /// Card Break.
        /// </summary>
        [Image("break.png")]
        [TileInfo("break", "")]
        Break,

        /// <summary>
        /// Card more questions.
        /// </summary>
        [Image("questionmark.png")]
        [TileInfo("?", "info missing")]
        Question,

        /// <summary>
        /// Card infinte (not estimatable).
        /// </summary>
        [Image("infinite.png")]
        [TileInfo("∞", "infinite")]
        Infinite
    }
}