namespace PCloudUploader
{
    public class AuthResult
    {
        public bool cryptosetup { get; set; }
        public int plan { get; set; }
        public bool cryptosubscription { get; set; }
        public long publiclinkquota { get; set; }
        public int userid { get; set; }
        public int result { get; set; }
        public string email { get; set; }
        public int trashrevretentiondays { get; set; }
        public string auth { get; set; }
        public bool emailverified { get; set; }
        public bool usedpublinkbranding { get; set; }
        public string currency { get; set; }
        public bool agreedwithpp { get; set; }
        public bool haspassword { get; set; }
        public long quota { get; set; }
        public bool cryptolifetime { get; set; }
        public bool premium { get; set; }
        public bool premiumlifetime { get; set; }
        public bool business { get; set; }
        public long usedquota { get; set; }
        public string language { get; set; }
        public bool haspaidrelocation { get; set; }
        public long freequota { get; set; }
        public string registered { get; set; }
        public Journey journey { get; set; }

        public class Journey
        {
            public Steps steps { get; set; }
        }

        public class Steps
        {
            public bool verifymail { get; set; }
            public bool uploadfile { get; set; }
            public bool autoupload { get; set; }
            public bool downloadapp { get; set; }
            public bool downloaddrive { get; set; }
            public bool sentinvitation { get; set; }
        }
    }
}