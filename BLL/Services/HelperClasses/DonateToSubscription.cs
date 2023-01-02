﻿using BLL.Services.Interfaces;

namespace BLL.Services.HelperClasses
{
    public class DonateToSubscription : ISubscriptionService
    {
        IDonateService _donate;
        public DonateToSubscription(IDonateService donate)
        {
            _donate = donate;
        }

        public float Pay(int value)
        {
            return _donate.GiveADonate(value);
        }
    }
}