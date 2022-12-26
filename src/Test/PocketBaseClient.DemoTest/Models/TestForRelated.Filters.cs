
// This file was generated automatically for the PocketBase Application demo-test (https://orm-csharp-test.pockethost.io)
//    See CodeGenerationSummary.txt for more details
//
// PocketBaseClient-csharp project: https://github.com/iluvadev/PocketBaseClient-csharp
// Issues: https://github.com/iluvadev/PocketBaseClient-csharp/issues
// License (MIT): https://github.com/iluvadev/PocketBaseClient-csharp/blob/main/LICENSE
//
// pocketbase-csharp-sdk project: https://github.com/PRCV1/pocketbase-csharp-sdk 
// pocketbase project: https://github.com/pocketbase/pocketbase

using PocketBaseClient.Orm.Filters;
using System.Net.Mail;

namespace PocketBaseClient.DemoTest.Models
{
    public partial class TestForRelated 
    {
        public class Filters : ItemBaseFilters
        {

            /// <summary>Makes a Filter to Query data over the 'number_unique' field</summary>
            public FilterQuery NumberUnique(OperatorNumeric op, int value) => FilterQuery.Create("number_unique", op, value);
            /// <summary>Makes a Filter to Query data over the 'number_nonempty' field</summary>
            public FilterQuery NumberNonempty(OperatorNumeric op, int value) => FilterQuery.Create("number_nonempty", op, value);
            /// <summary>Makes a Filter to Query data over the 'number_nonempty_unique' field</summary>
            public FilterQuery NumberNonemptyUnique(OperatorNumeric op, int value) => FilterQuery.Create("number_nonempty_unique", op, value);

        }
    }
}
