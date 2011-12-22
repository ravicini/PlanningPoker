// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Bootstrapper.cs">
//   Copyright (c) Marco Ravicini. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace PlanningPoker.Application
{
    using System;
    using System.Collections.Generic;

    using Caliburn.Micro;

    using PlanningPoker.ViewModels;
    using PlanningPoker.Views;

    /// <summary>
    /// application bootstrapper
    /// </summary>
    public class Bootstrapper : PhoneBootstrapper
    {
        private PhoneContainer container;

        /// <summary>
        /// By default, we are configured to use MEF
        /// </summary>
        protected override void Configure()
        {
            this.container = new PhoneContainer(RootFrame);

            this.container.RegisterPhoneServices();

            this.container.Singleton<SelectCardView>();
            this.container.Singleton<SelectCardViewModel>();
            this.container.PerRequest<CardView>();
            this.container.PerRequest<CardViewModel>();
        }

        /// <summary>
        /// Override this to provide an IoC specific implementation.
        /// </summary>
        /// <param name="service">The service to locate.</param>
        /// <param name="key">The key to locate.</param>
        /// <returns>
        /// The located service.
        /// </returns>
        protected override object GetInstance(Type service, string key)
        {
            return this.container.GetInstance(service, key);
        }

        /// <summary>
        /// Override this to provide an IoC specific implementation
        /// </summary>
        /// <param name="service">The service to locate.</param>
        /// <returns>
        /// The located services.
        /// </returns>
        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return this.container.GetAllInstances(service);
        }

        /// <summary>
        /// Override this to provide an IoC specific implementation.
        /// </summary>
        /// <param name="instance">The instance to perform injection on.</param>
        protected override void BuildUp(object instance)
        {
            this.container.BuildUp(instance);
        }
    }
}
