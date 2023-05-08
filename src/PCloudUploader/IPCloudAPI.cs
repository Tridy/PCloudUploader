using Refit;

namespace PCloudUploader
{
    [Headers("User-Agent: MyApiClient")]
    public interface IPCloudApi
    {
        [Get("/userinfo?getauth=1&logout=1&username={username}&password={password}")]
        Task<AuthResult> GetUserInfoAsync(string username, string password);

        [Post("/listfolder?auth={authToken}&folderid={folderId}")]
        Task<ListFolderResult> ListFoldersAsync(string authToken, string folderId);

        [Post("/uploadfile?auth={authToken}&folderid={folderId}")]
        Task<UploadResult> UploadFileAsync(string authToken, long folderId, [Body] MultipartFormDataContent content);

        [Post("/getfilepublink?auth={authToken}&fileid={fileId}")]
        Task<PubLinkResult> GetFilePubLink(string authToken, long fileId);
    }
}