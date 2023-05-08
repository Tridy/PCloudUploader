using System.Diagnostics;

namespace PCloudUploader
{
    public class ListFolderResult
    {
        public int result { get; set; }
        public Metadata metadata { get; set; }

        public class Metadata
        {
            public string path { get; set; }
            public string name { get; set; }
            public string created { get; set; }
            public bool ismine { get; set; }
            public bool thumb { get; set; }
            public string modified { get; set; }
            public string id { get; set; }
            public bool isshared { get; set; }
            public string icon { get; set; }
            public bool isfolder { get; set; }
            public int folderid { get; set; }
            public Content[] contents { get; set; }
        }

        [DebuggerDisplay("{name}")]
        public class Content
        {
            public string path { get; set; }
            public string name { get; set; }
            public string created { get; set; }
            public bool ismine { get; set; }
            public bool thumb { get; set; }
            public string modified { get; set; }
            public int comments { get; set; }
            public string id { get; set; }
            public bool isshared { get; set; }
            public string icon { get; set; }
            public bool isfolder { get; set; }
            public int parentfolderid { get; set; }
            public long folderid { get; set; }
            public bool cancreate { get; set; }
            public bool canread { get; set; }
            public int userid { get; set; }
            public bool ismount { get; set; }
            public bool candelete { get; set; }
            public bool canmodify { get; set; }
            public long fileid { get; set; }
            public long hash { get; set; }
            public int category { get; set; }
            public int size { get; set; }
            public string contenttype { get; set; }
        }
    }
}