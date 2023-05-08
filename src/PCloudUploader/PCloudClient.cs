using System.Net.Http.Headers;

using Refit;

namespace PCloudUploader
{
    public partial class PCloudClient
    {
        private readonly IPCloudApi _client;
        private readonly string _authToken;

        public string AuthToken
        {
            get
            {
                return this._authToken;
            }
        }

        public static async Task<PCloudClient> FromUserAndPassword(string username, string password)
        {
            IPCloudApi client = RestService.For<IPCloudApi>("https://api.pcloud.com");

            AuthResult userInfo = await client.GetUserInfoAsync(username, password);

            if (userInfo.Result != 0)
            {
                throw new Exception("Could not authenticate.");
            }

            string token = userInfo.Auth;

            return new PCloudClient(client, token);
        }

        private PCloudClient(IPCloudApi api, string authToken)
        {
            this._client = api;
            this._authToken = authToken;
        }

        public async Task<long> UploadFileAsync(string filePath, long toFolderId)
        {
            MultipartFormDataContent content = GetFileDataContent(filePath);
            UploadResult uploadResult = await _client.UploadFileAsync(_authToken, toFolderId, content).ConfigureAwait(false);
            long uploadedFileId = uploadResult.FileIds[0];
            return uploadedFileId;
        }

        public async Task<string> GetFilePublicLinkAsync(long fileId)
        {
            PubLinkResult publicLinkResult = await _client.GetFilePubLink(_authToken, fileId).ConfigureAwait(false);
            return publicLinkResult.link;
        }

        private static MultipartFormDataContent GetFileDataContent(string filePath)
        {
            var fileInfo = new FileInfo(filePath);
            string fileName = fileInfo.Name;

            var fileStream = new FileStream(filePath, FileMode.Open);
            var fileContent = new StreamContent(fileStream);

            fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "\"files\"",
                FileName = "\"" + fileName + "\""
            };

            var content = new MultipartFormDataContent
            {
                fileContent
            };

            return content;
        }

        public async Task<FolderItem[]> ListFoldersAsync()
        {
            ListFolderResult listResult = await _client.ListFoldersAsync(_authToken, "0").ConfigureAwait(false);
            FolderItem[] results = listResult.Meta.Contents.Select(x => new FolderItem(x.Id, x.Name, x.Path, x.IsFolder, x.FolderId)).ToArray();
            return results;
        }
    }
}