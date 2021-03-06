﻿using InstaSharper.Classes.Models;
using InstaSharper.ResponseWrappers;

namespace InstaSharper.Converters
{
    internal class ConvertersFabric
    {
        internal static IObjectConverter<InstaUser, InstaUserResponse> GetUserConverter(InstaUserResponse instaresponse)
        {
            return new InstaUsersConverter {SourceObject = instaresponse};
        }

        public static IObjectConverter<InstaMedia, InstaMediaItemResponse> GetSingleMediaConverter(
            InstaMediaItemResponse responseMedia)
        {
            return new InstaMediaConverter {SourceObject = responseMedia};
        }

        internal static IObjectConverter<InstaFeed, InstaFeedResponse> GetFeedConverter(
            InstaFeedResponse feedResponse)
        {
            return new InstaFeedConverter {SourceObject = feedResponse};
        }

        public static IObjectConverter<InstaMediaList, InstaMediaListResponse> GetMediaListConverter(
            InstaMediaListResponse mediaResponse)
        {
            return new InstaMediaListConverter {SourceObject = mediaResponse};
        }

        public static IObjectConverter<InstaCaption, InstaCaptionResponse> GetCaptionConverter(
            InstaCaptionResponse captionResponse)
        {
            return new InstaCaptionConverter {SourceObject = captionResponse};
        }

        public static IObjectConverter<InstaFriendshipStatus, InstaFriendshipStatusResponse>
            GetFriendShipStatusConverter(InstaFriendshipStatusResponse friendshipStatusResponse)
        {
            return new InstaFriendshipStatusConverter {SourceObject = friendshipStatusResponse};
        }

        public static IObjectConverter<InstaStory, InstaStoryResponse> GetSingleStoryConverter(
            InstaStoryResponse storyResponse)
        {
            return new InstaStoryConverter {SourceObject = storyResponse};
        }

        public static IObjectConverter<InstaUserTag, InstaUserTagResponse> GetUserTagConverter(InstaUserTagResponse tag)
        {
            return new InstaUserTagConverter {SourceObject = tag};
        }

        public static IObjectConverter<InstaDirectInboxContainer, InstaDirectInboxContainerResponse>
            GetDirectInboxConverter(InstaDirectInboxContainerResponse inbox)
        {
            return new InstaDirectInboxConverter {SourceObject = inbox};
        }

        public static IObjectConverter<InstaDirectInboxThread, InstaDirectInboxThreadResponse> GetDirectThreadConverter(
            InstaDirectInboxThreadResponse thread)
        {
            return new InstaDirectThreadConverter {SourceObject = thread};
        }

        public static IObjectConverter<InstaDirectInboxItem, InstaDirectInboxItemResponse> GetDirectThreadItemConverter(
            InstaDirectInboxItemResponse threadItem)
        {
            return new InstaDirectThreadItemConverter {SourceObject = threadItem};
        }

        public static IObjectConverter<InstaDirectInboxSubscription, InstaDirectInboxSubscriptionResponse>
            GetDirectSubscriptionConverter(InstaDirectInboxSubscriptionResponse subscription)
        {
            return new InstaDirectInboxSubscriptionConverter {SourceObject = subscription};
        }

        public static IObjectConverter<InstaRecentActivityFeed, InstaRecentActivityFeedResponse>
            GetSingleRecentActivityConverter(InstaRecentActivityFeedResponse feedResponse)
        {
            return new InstaRecentActivityConverter {SourceObject = feedResponse};
        }

        public static IObjectConverter<InstaRecipients, InstaRecipientsResponse> GetRecipientsConverter(
            InstaRecipientsResponse recipients)
        {
            return new InstaRecipientsConverter {SourceObject = recipients};
        }
    }
}