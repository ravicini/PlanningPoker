// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StoryboardStartAction.cs">
//     Copyright (c) Marco Ravicini. All rights reserved.  
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace PlanningPoker.Helpers
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Interactivity;
    using System.Windows.Media.Animation;

    /// <summary>
    /// Trigger action for storyboard start.
    /// </summary>
    public class StoryboardStartAction : TriggerAction<Image>
    {
        /// <summary>
        /// Storyboard to execute on action invoke.
        /// </summary>
        public static readonly DependencyProperty StoryboardProperty =
            DependencyProperty.Register("Storyboard", typeof(Storyboard), typeof(StoryboardStartAction), new PropertyMetadata(default(Storyboard)));

        /// <summary>
        /// Gets or sets the storyboard.
        /// </summary>
        public Storyboard Storyboard
        {
            get
            {
                return (Storyboard)GetValue(StoryboardProperty);
            }

            set
            {
                SetValue(StoryboardProperty, value);
            }
        }

        /// <summary>
        /// Invokes the action.
        /// </summary>
        /// <param name="parameter">The parameter to the action. If the Action does not require a parameter, the parameter may be set to a null reference.</param>
        protected override void Invoke(object parameter)
        {
            this.Storyboard.Begin();
        }
    }
}