// Copyright 2021, Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Ads.Common.Lib;

using System;
using System.Collections.Generic;
using System.Reflection;

namespace Google.Api.Ads.AdManager.Lib
{
    /// <summary>
    /// Lists all the services available through this library.
    /// </summary>
    public partial class AdManagerService : AdsService
    {
        /// <summary>
        /// All the services available in v202208.
        /// </summary>
        public class v202208
        {
            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/ActivityGroupService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature ActivityGroupService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/ActivityService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature ActivityService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/AdjustmentRuleService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature AdjustmentService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/AdRuleService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature AdRuleService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/AudienceSegmentService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature AudienceSegmentService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/CdnConfigurationService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature CdnConfigurationService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/CmsMetadataService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature CmsMetadataService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/ContactService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature ContactService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/CompanyService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature CompanyService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/ContentBundleService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature ContentBundleService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/ContentService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature ContentService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/CreativeService">
            /// this page </a> for details.
            /// </summary>
            public static readonly ServiceSignature CreativeService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/CreativeReviewService">
            /// this page </a> for details.
            /// </summary>
            public static readonly ServiceSignature CreativeReviewService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/CreativeSetService">
            /// this page </a> for details.
            /// </summary>
            public static readonly ServiceSignature CreativeSetService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/CreativeTemplateService">
            /// this page </a> for details.
            /// </summary>
            public static readonly ServiceSignature CreativeTemplateService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/CreativeWrapperService">
            /// this page </a> for details.
            /// </summary>
            public static readonly ServiceSignature CreativeWrapperService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/CustomFieldService">
            /// this page </a> for details.
            /// </summary>
            public static readonly ServiceSignature CustomFieldService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/CustomTargetingService">
            /// this page </a> for details.
            /// </summary>
            public static readonly ServiceSignature CustomTargetingService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/DaiAuthenticationKeyService">
            /// this page </a> for details.
            /// </summary>
            public static readonly ServiceSignature DaiAuthenticationKeyService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/DaiEncodingProfileService">
            /// this page </a> for details.
            /// </summary>
            public static readonly ServiceSignature DaiEncodingProfileService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/ForecastService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature ForecastService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/InventoryService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature InventoryService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/LabelService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature LabelService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/LineItemTemplateService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature LineItemTemplateService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/LineItemService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature LineItemService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/LineItemCreativeAssociationService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature LineItemCreativeAssociationService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/LiveStreamEventService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature LiveStreamEventService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/MobileApplicationService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature MobileApplicationService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/NativeStyleService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature NativeStyleService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/NetworkService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature NetworkService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/OrderService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature OrderService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/PlacementService">
            /// this page </a> for details.
            /// </summary>
            public static readonly ServiceSignature PlacementService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/ProposalService">
            /// this page </a> for details.
            /// </summary>
            public static readonly ServiceSignature ProposalService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/ProposalLineItemService">
            /// this page </a> for details.
            /// </summary>
            public static readonly ServiceSignature ProposalLineItemService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/PublisherQueryLanguageService">
            /// this page </a> for details.
            /// </summary>
            public static readonly ServiceSignature PublisherQueryLanguageService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/ReportService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature ReportService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/SiteService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature SiteService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/StreamActivityMonitorService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature StreamActivityMonitorService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/SuggestedAdUnitService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature SuggestedAdUnitService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/TargetingPresetService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature TargetingPresetService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/TeamService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature TeamService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/UserService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature UserService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/UserTeamAssociationService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature UserTeamAssociationService;

            /// <summary>
            /// See <a href="https://developers.google.com/doubleclick-publishers/docs/reference/v202208/YieldGroupService">
            /// this page</a> for details.
            /// </summary>
            public static readonly ServiceSignature YieldGroupService;

            /// <summary>
            /// Factory type for v202208 services.
            /// </summary>
            public static readonly Type factoryType = typeof(AdManagerServiceFactory);

            /// <summary>
            /// Static constructor to initialize the service constants.
            /// </summary>
            static v202208()
            {
                ActivityGroupService =
                    AdManagerService.MakeServiceSignature("v202208", "ActivityGroupService");
                ActivityService =
                    AdManagerService.MakeServiceSignature("v202208", "ActivityService");
                AdjustmentService =
                    AdManagerService.MakeServiceSignature("v202208", "AdjustmentService");
                AdRuleService = AdManagerService.MakeServiceSignature("v202208", "AdRuleService");
                AudienceSegmentService =
                    AdManagerService.MakeServiceSignature("v202208", "AudienceSegmentService");
                CdnConfigurationService =
                    AdManagerService.MakeServiceSignature("v202208", "CdnConfigurationService");
                CmsMetadataService =
                    AdManagerService.MakeServiceSignature("v202208", "CmsMetadataService");
                CompanyService = AdManagerService.MakeServiceSignature("v202208", "CompanyService");
                ContactService = AdManagerService.MakeServiceSignature("v202208", "ContactService");
                ContentBundleService =
                    AdManagerService.MakeServiceSignature("v202208", "ContentBundleService");
                ContentService = AdManagerService.MakeServiceSignature("v202208", "ContentService");
                CreativeService =
                    AdManagerService.MakeServiceSignature("v202208", "CreativeService");
                CreativeReviewService =
                    AdManagerService.MakeServiceSignature("v202208", "CreativeReviewService");
                CreativeSetService =
                    AdManagerService.MakeServiceSignature("v202208", "CreativeSetService");
                CreativeTemplateService =
                    AdManagerService.MakeServiceSignature("v202208", "CreativeTemplateService");
                CreativeWrapperService =
                    AdManagerService.MakeServiceSignature("v202208", "CreativeWrapperService");
                CustomTargetingService =
                    AdManagerService.MakeServiceSignature("v202208", "CustomTargetingService");
                CustomFieldService =
                    AdManagerService.MakeServiceSignature("v202208", "CustomFieldService");
                DaiAuthenticationKeyService =
                    AdManagerService.MakeServiceSignature("v202208", "DaiAuthenticationKeyService");
                DaiEncodingProfileService =
                    AdManagerService.MakeServiceSignature("v202208", "DaiEncodingProfileService");
                ForecastService =
                    AdManagerService.MakeServiceSignature("v202208", "ForecastService");
                InventoryService =
                    AdManagerService.MakeServiceSignature("v202208", "InventoryService");
                LabelService = AdManagerService.MakeServiceSignature("v202208", "LabelService");
                LineItemTemplateService =
                    AdManagerService.MakeServiceSignature("v202208", "LineItemTemplateService");
                LineItemService =
                    AdManagerService.MakeServiceSignature("v202208", "LineItemService");
                LineItemCreativeAssociationService =
                    AdManagerService.MakeServiceSignature("v202208",
                        "LineItemCreativeAssociationService");
                LiveStreamEventService =
                    AdManagerService.MakeServiceSignature("v202208", "LiveStreamEventService");
                MobileApplicationService =
                    AdManagerService.MakeServiceSignature("v202208", "MobileApplicationService");
                NativeStyleService =
                    AdManagerService.MakeServiceSignature("v202208", "NativeStyleService");
                NetworkService = AdManagerService.MakeServiceSignature("v202208", "NetworkService");
                OrderService = AdManagerService.MakeServiceSignature("v202208", "OrderService");
                PlacementService =
                    AdManagerService.MakeServiceSignature("v202208", "PlacementService");
                ProposalService =
                    AdManagerService.MakeServiceSignature("v202208", "ProposalService");
                ProposalLineItemService =
                    AdManagerService.MakeServiceSignature("v202208", "ProposalLineItemService");
                PublisherQueryLanguageService =
                    AdManagerService.MakeServiceSignature("v202208",
                        "PublisherQueryLanguageService");
                ReportService = AdManagerService.MakeServiceSignature("v202208", "ReportService");
                SiteService = AdManagerService.MakeServiceSignature("v202208", "SiteService");
                StreamActivityMonitorService =
                    AdManagerService.MakeServiceSignature("v202208", "StreamActivityMonitorService");
                SuggestedAdUnitService =
                    AdManagerService.MakeServiceSignature("v202208", "SuggestedAdUnitService");
                TargetingPresetService = AdManagerService.MakeServiceSignature("v202208", "TargetingPresetService");
                TeamService = AdManagerService.MakeServiceSignature("v202208", "TeamService");
                UserService = AdManagerService.MakeServiceSignature("v202208", "UserService");
                UserTeamAssociationService =
                    AdManagerService.MakeServiceSignature("v202208", "UserTeamAssociationService");
                YieldGroupService = AdManagerService.MakeServiceSignature("v202208", "YieldGroupService");
            }
        }
    }
}
