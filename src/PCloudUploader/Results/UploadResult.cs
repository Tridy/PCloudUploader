namespace PCloudUploader
{
    public class UploadResult
    {
        public int result { get; set; }
        public Metadata[] metadata { get; set; }
        public Checksum[] checksums { get; set; }
        public long[] fileids { get; set; }

        public class Metadata
        {
            public string name { get; set; }
            public string created { get; set; }
            public bool thumb { get; set; }
            public string modified { get; set; }
            public bool isfolder { get; set; }
            public long fileid { get; set; }
            public long hash { get; set; }
            public int comments { get; set; }
            public string path { get; set; }
            public int category { get; set; }
            public string id { get; set; }
            public bool isshared { get; set; }
            public bool ismine { get; set; }
            public int size { get; set; }
            public long parentfolderid { get; set; }
            public string contenttype { get; set; }
            public string icon { get; set; }
        }

        public class Checksum
        {
            public string sha1 { get; set; }
            public string md5 { get; set; }
        }
    }
}