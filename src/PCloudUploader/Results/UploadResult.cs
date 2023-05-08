using System.Text.Json.Serialization;

namespace PCloudUploader
{
    public class UploadResult
    {
        [JsonPropertyName("result")]
        public int Result { get; set; }

        [JsonPropertyName("metadata")]
        public Metadata[] Meta { get; set; }

        [JsonPropertyName("checksums")]
        public Checksum[] Checksums { get; set; }

        [JsonPropertyName("fileids")]
        public long[] FileIds { get; set; }

        public class Metadata
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("created")]
            public string Created { get; set; }

            [JsonPropertyName("thumb")]
            public bool Thumb { get; set; }

            [JsonPropertyName("modified")]
            public string Modified { get; set; }

            [JsonPropertyName("isfolder")]
            public bool IsFolder { get; set; }

            [JsonPropertyName("fileid")]
            public long FileId { get; set; }

            [JsonPropertyName("hash")]
            public long Hash { get; set; }

            [JsonPropertyName("comments")]
            public int Comments { get; set; }

            [JsonPropertyName("path")]
            public string Path { get; set; }

            [JsonPropertyName("category")]
            public int Category { get; set; }

            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("isshared")]
            public bool IsShared { get; set; }

            [JsonPropertyName("ismine")]
            public bool IsMine { get; set; }

            [JsonPropertyName("size")]
            public int Size { get; set; }

            [JsonPropertyName("parentfolderid")]
            public long ParentFolderId { get; set; }

            [JsonPropertyName("contenttype")]
            public string ContentType { get; set; }

            [JsonPropertyName("icon")]
            public string Icon { get; set; }
        }

        public class Checksum
        {
            [JsonPropertyName("sha1")]
            public string Sha1 { get; set; }

            [JsonPropertyName("md5")]
            public string Md5 { get; set; }
        }
    }
}