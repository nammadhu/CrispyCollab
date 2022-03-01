﻿using Infrastructure.Identity.Entities;
using Microsoft.Extensions.Configuration;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity.Services
{
    public class SubscriptionPlanManager
    {
        private readonly IdentificationDbContext identificationDbContext;
        private readonly SubscriptionService subscriptionService;
        public SubscriptionPlanManager(IdentificationDbContext identificationDbContext)
        {
            this.identificationDbContext = identificationDbContext;
            this.subscriptionService = new SubscriptionService();
        }
        public async Task CreateSubscription(SubscriptionPlan subscriptionPlan)
        {
            identificationDbContext.SubscriptionPlans.Add(subscriptionPlan);
            await identificationDbContext.SaveChangesAsync();
        }
        public Task<SubscriptionPlan> FindById(Guid id)
        {
            return identificationDbContext.SubscriptionPlans.FindAsync(id).AsTask();
        }
    }
}
