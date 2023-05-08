using Microsoft.Extensions.Configuration;

using Xunit;

namespace PCloudUploader.Test
{
    public class PCloudUploaderTests
    {
        private Settings _testSettings;

        public PCloudUploaderTests()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddJsonFile("test.settings.json", optional: false)
                .AddJsonFile("test.settings.local.json", optional: true)
                .Build();

            _testSettings = new();

            configuration.GetSection("Test").Bind(_testSettings);
        }

        [Fact]
        public async Task CanShareAFile()
        {
            var client = await PCloudClient.FromUserAndPassword(_testSettings.User, _testSettings.Password);
            FolderItem[] folderItems = await client.ListFoldersAsync();
            long folderId = folderItems.Single(f => f.IsFolder && f.Name == _testSettings.PCloudFolder).FolderId;
            long uploadedFileId = await client.UploadFileAsync(_testSettings.LocalFileToUpload, folderId);
            string pubLink = await client.GetFilePublicLinkAsync(uploadedFileId);
            Assert.NotNull(pubLink);
        }
    }
}