using System.Text.Json.Serialization;

namespace PCloudUploader
{
    public class AuthResult
    {
        [JsonPropertyName("cryptosetup")]
        public bool CryptoSetup { get; set; }

        [JsonPropertyName("plan")]
        public int Plan { get; set; }

        [JsonPropertyName("cryptosubscription")]
        public bool CryptoSubscription { get; set; }

        [JsonPropertyName("publiclinkquota")]
        public long PublicLinkQuota { get; set; }

        [JsonPropertyName("userid")]
        public int UserId { get; set; }

        [JsonPropertyName("result")]
        public int Result { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("trashrevretentiondays")]
        public int TrashRevRetentionDays { get; set; }

        [JsonPropertyName("auth")]
        public string Auth { get; set; }

        [JsonPropertyName("emailverified")]
        public bool EmailVerified { get; set; }

        [JsonPropertyName("usedpublinkbranding")]
        public bool UsedPublinkBranding { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("agreedwithpp")]
        public bool AgreedWithPP { get; set; }

        [JsonPropertyName("haspassword")]
        public bool HasPassword { get; set; }

        [JsonPropertyName("quota")]
        public long Quota { get; set; }

        [JsonPropertyName("cryptolifetime")]
        public bool CryptoLifetime { get; set; }

        [JsonPropertyName("premium")]
        public bool Premium { get; set; }

        [JsonPropertyName("premiumlifetime")]
        public bool PremiumLifetime { get; set; }

        [JsonPropertyName("business")]
        public bool Business { get; set; }

        [JsonPropertyName("usedquota")]
        public long UsedQuota { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("haspaidrelocation")]
        public bool HasPaidRelocation { get; set; }

        [JsonPropertyName("freequota")]
        public long FreeQuota { get; set; }

        [JsonPropertyName("registered")]
        public string Registered { get; set; }

        [JsonPropertyName("journey")]
        public JourneySteps Journey { get; set; }

        public class JourneySteps
        {
            [JsonPropertyName("steps")]
            public Steps Steps { get; set; }
        }

        public class Steps
        {
            [JsonPropertyName("verifymail")]
            public bool VerifyMail { get; set; }

            [JsonPropertyName("uploadfile")]
            public bool UploadFile { get; set; }

            [JsonPropertyName("autoupload")]
            public bool AutoUpload { get; set; }

            [JsonPropertyName("downloadapp")]
            public bool DownloadApp { get; set; }

            [JsonPropertyName("downloaddrive")]
            public bool DownloadDrive { get; set; }

            [JsonPropertyName("sentinvitation")]
            public bool SentInvitation { get; set; }
        }
    }
}