﻿using System;
using System.Collections.Generic;
using System.Text;
using Voat.Common;
using Voat.Common.Configuration;
using Voat.Configuration;

namespace Voat.Configuration
{
    public class VoatSettings : UpdatableConfigurationSettings<VoatSettings>, IVoatSettings
    {
        private T GetValue<T>(string key, T defaultIfMissing)
        {
            //if (configValues.ContainsKey(key))
            //{
            //    var value = (T)configValues[key];
            //    //I'm NOT liking where this is going. And I forgot exactly what situation I originally wrote this for. As Fuzzy and Dan say, "It's a future person problem."
            //    if (typeof(T) == typeof(bool) || typeof(T) == typeof(int) || !value.IsDefault())
            //    {
            //        return value;
            //    }
            //}
            return defaultIfMissing;
        }

        #region AppSettings Accessors

        public bool IsVoatBranded
        {
            get
            {
                return SiteName.Equals("Voat", System.StringComparison.OrdinalIgnoreCase);
            }
        }

        public bool AdsEnabled { get; set; } = false;

        public bool ApiKeyCreationEnabled { get; set; } = false;

        public bool CaptchaEnabled { get; set; } = true;

        public bool ChatEnabled { get; set; } = false;

        public int DailyCommentPostingQuota { get; set; } = 20;

        public int DailyCommentPostingQuotaForNegativeScore { get; set; } = 10;

        public int DailyCrossPostingQuota { get; set; } = 2;

        public int DailyGlobalPostingQuota { get; set; } = 5;

        public int DailyPostingQuotaForNegativeScore { get; set; } = 3;

        public int DailyPostingQuotaPerSub { get; set; } = 10;

        public int DailyVotingQuota { get; set; } = 100;

        public int DailyVotingQuotaScaledMinimum { get; set; } = 10;
        //dailyVotingQuotaScaledMinimum

        public string DestinationPathAvatars { get; set; } = "~/Storage/Avatars";

        public string DestinationPathThumbs { get; set; } = "~/Storage/Thumbs";

        public string EmailAddress { get; set; } = "noreply@voat.co";

        public string EmailServiceKey { get; set; } = "";

        public bool ForceHTTPS { get; set; } = true;
        public string FooterText { get; set; } = "";

        public int HourlyCommentPostingQuota { get; set; } = 10;

        public int HourlyGlobalPostingQuota { get; set; } = 3;

        public int HourlyPostingQuotaPerSub { get; set; } = 3;

        public bool LegacyApiEnabled { get; set; } = false;

        public int MaxAllowedAccountsFromSingleIP { get; set; } = 100;

        public int MaximumOwnedSets { get; set; } = 10;

        public int MaximumOwnedSubs { get; set; } = 10;

        public int MaximumSetSubverseCount { get; set; } = 50;

        public int MinimumAccountAgeInDaysForSubverseCreation { get; set; } = 30;
        public int MinimumCommentPointsForSendingMessages { get; set; } = 10;

        public int MinimumCommentPointsForSubverseCreation { get; set; } = 10;

        public int MinimumSubmissionPointsForSubverseCreation { get; set; } = 10;
        public int MinimumCommentPointsForCaptchaMessaging { get; set; } = 100;
        public int MinimumCommentPointsForCaptchaSubmission { get; set; } = 25;
        public int MinimumCommentPointsForSendingChatMessages { get; set; } = 100;

        public Origin Origin { get; set; } = Origin.Unknown;
        public string RecaptchaPrivateKey { get; set; } = "";

        public string RecaptchaPublicKey { get; set; } = "";
        /// <summary>
        /// Will redirect incoming requests that don't match the site domain to the value specified in siteDomain
        /// </summary>
        public bool RedirectToSiteDomain { get; set; } = true;

        public bool RegistrationEnabled { get; set; } = true;
        public bool SearchEnabled { get; set; } = true;
        public bool SetsEnabled { get; set; } = true;
        public bool SetCreationEnabled { get; set; } = true;
        public bool SignalrEnabled { get; set; } = false;

        public string SiteDescription { get; set; } = "A community platform where you can have your say. No censorship.";

        public string SiteDomain { get; set; } = "voat.co";
        public string ContentDeliveryDomain { get; set; } = "cdn.voat.co";

        public string SiteKeywords { get; set; } = "voat, voat.co, vote, submit, comment";

        public string SiteLogo { get; set; } = "/images/voat-logo.png";

        public string SiteName { get; set; } = "Voat";

        public string SiteSlogan { get; set; } = "Voat - have your say";
        public int SubverseUpdateTimeLockInHours { get; set; } = 48;

        public bool UseContentDeliveryNetwork { get; set; } = false;
        public RuntimeStateSetting RuntimeState { get; set; } = RuntimeStateSetting.Enabled;

        public bool ThumbnailsEnabled { get; set; } = true;

        public bool AllowUnicodeInTitles { get; set; } = false;
        public int MinumumTitleLength { get; set; } = 10;

        #endregion AppSettings Accessors

    }
}
