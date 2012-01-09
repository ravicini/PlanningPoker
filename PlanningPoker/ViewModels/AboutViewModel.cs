// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AboutViewModel.cs">
//     Copyright (c) Marco Ravicini. All rights reserved.  
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace PlanningPoker.ViewModels
{
    using System;

    using Microsoft.Phone.Tasks;

    /// <summary>
    /// View model for about page
    /// </summary>
    public class AboutViewModel
    {
        private readonly WebBrowserTask webBrowserTask;

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutViewModel"/> class.
        /// </summary>
        /// <param name="webBrowserTask">The web browser task.</param>
        public AboutViewModel(WebBrowserTask webBrowserTask)
        {
            this.webBrowserTask = webBrowserTask;
        }

        /// <summary>
        /// Opens the bbv homepage.
        /// </summary>
        public void OpenHomepage()
        {
            this.webBrowserTask.Uri = new Uri("http://www.bbv.ch", UriKind.Absolute);
            this.webBrowserTask.Show();
        }
    }
}