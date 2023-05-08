using System.Diagnostics;
using System.Text.Json.Serialization;

namespace PCloudUploader
{
    public class ListFolderResult
    {
        [JsonPropertyName("result")]
        public int Result { get; set; }

        [JsonPropertyName("metadata")]
        public Metadata Meta { get; set; }

        public class Metadata
        {
            [JsonPropertyName("path")]
            public string Path { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("created")]
            public string Created { get; set; }

            [JsonPropertyName("ismine")]
            public bool IsMine { get; set; }

            [JsonPropertyName("thumb")]
            public bool Thumb { get; set; }

            [JsonPropertyName("modified")]
            public string Modified { get; set; }

            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("isshared")]
            public bool IsShared { get; set; }

            [JsonPropertyName("icon")]
            public string Icon { get; set; }

            [JsonPropertyName("isfolder")]
            public bool IsFolder { get; set; }

            [JsonPropertyName("folderid")]
            public int FolderId { get; set; }

            [JsonPropertyName("contents")]
            public Content[] Contents { get; set; }
        }

        [DebuggerDisplay("{Name}")]
        public class Content
        {
            [JsonPropertyName("path")]
            public string Path { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("created")]
            public string Created { get; set; }

            [JsonPropertyName("ismine")]
            public bool IsMine { get; set; }

            [JsonPropertyName("thumb")]
            public bool Thumb { get; set; }

            [JsonPropertyName("modified")]
            public string Modified { get; set; }

            [JsonPropertyName("comments")]
            public int Comments { get; set; }

            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("isshared")]
            public bool IsShared { get; set; }

            [JsonPropertyName("icon")]
            public string Icon { get; set; }

            [JsonPropertyName("isfolder")]
            public bool IsFolder { get; set; }

            [JsonPropertyName("parentfolderid")]
            public int ParentFolderId { get; set; }

            [JsonPropertyName("folderid")]
            public long FolderId { get; set; }

            [JsonPropertyName("cancreate")]
            public bool CanCreate { get; set; }

            [JsonPropertyName("canread")]
            public bool CanRead { get; set; }

            [JsonPropertyName("userid")]
            public int UserId { get; set; }

            [JsonPropertyName("ismount")]
            public bool IsMount { get; set; }

            [JsonPropertyName("candelete")]
            public bool CanDelete { get; set; }

            [JsonPropertyName("canmodify")]
            public bool CanModify { get; set; }

            [JsonPropertyName("fileid")]
            public long FileId { get; set; }

            [JsonPropertyName("hash")]
            public long Hash { get; set; }

            [JsonPropertyName("category")]
            public int Category { get; set; }

            [JsonPropertyName("size")]
            public int Size { get; set; }

            [JsonPropertyName("contenttype")]
            public string ContentType { get; set; }
        }
    }
}