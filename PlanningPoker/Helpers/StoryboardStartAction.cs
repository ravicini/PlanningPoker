// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StoryboardStartAction.cs">
//     Copyright (c) Marco Ravicini. All rights reserved.  
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
// 
namespace PlanningPoker.Helpers
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Interactivity;
    using System.Windows.Media.Animation;

    public class StoryboardStartAction : TriggerAction<Image> 
    {
        public static readonly DependencyProperty StoryboardProperty =
            DependencyProperty.Register("Storyboard", typeof(Storyboard), typeof(StoryboardStartAction), new PropertyMetadata(default(Storyboard)));

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

        protected override void Invoke(object parameter)
        {
            this.Storyboard.Begin();
        }
    }
}