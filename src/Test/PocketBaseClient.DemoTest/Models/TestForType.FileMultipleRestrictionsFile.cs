
// This file was generated automatically for the PocketBase Application demo-test (https://orm-csharp-test.pockethost.io)
//    See CodeGenerationSummary.txt for more details
//
// PocketBaseClient-csharp project: https://github.com/iluvadev/PocketBaseClient-csharp
// Issues: https://github.com/iluvadev/PocketBaseClient-csharp/issues
// License (MIT): https://github.com/iluvadev/PocketBaseClient-csharp/blob/main/LICENSE
//
// pocketbase-csharp-sdk project: https://github.com/PRCV1/pocketbase-csharp-sdk 
// pocketbase project: https://github.com/pocketbase/pocketbase

using PocketBaseClient.Orm;

namespace PocketBaseClient.DemoTest.Models
{
    public partial class TestForType
    {
        public class FileMultipleRestrictionsFile : FieldFileBase
        {

            /// <inheritdoc />
            public override long? MaxSize => 5242880;

            public FileMultipleRestrictionsFile() : base("file_multiple_restrictions", owner: null) { }

            public FileMultipleRestrictionsFile(TestForType? testForType) : base("file_multiple_restrictions", testForType) { }

            #region Thumbs
            public async Task<Stream> GetThumb100x100fAsync() => await GetStreamAsync("100x100f");
            public Stream GetThumb100x100f() => GetThumb100x100fAsync().Result;

            #endregion Thumbs
        }
    }
}
