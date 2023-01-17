﻿// Project site: https://github.com/iluvadev/PocketBaseClient-csharp
//
// Issues: https://github.com/iluvadev/PocketBaseClient-csharp/issues
// License (MIT): https://github.com/iluvadev/PocketBaseClient-csharp/blob/main/LICENSE
//
// Copyright (c) 2022, iluvadev, and released under MIT License.
//
// pocketbase-csharp-sdk project: https://github.com/PRCV1/pocketbase-csharp-sdk 
// pocketbase project: https://github.com/pocketbase/pocketbase

using pocketbase_csharp_sdk.Models.Collection;
using PocketBaseClient.CodeGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketBaseClient.CodeGenerator.Generation
{
    internal class FieldInfoFileOne : FieldInfoFile
    {

        /// <inheritdoc />
        public override string TypeName => TypeFileName;

        /// <inheritdoc />
        public override string FilterType => "FieldFilterText";

        /// <inheritdoc />
        public override string InitialValueForProperty => $"new {TypeName}(this)";


        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="itemInfo"></param>
        /// <param name="schemaField"></param>
        /// <param name="options"></param>
        public FieldInfoFileOne(ItemInfo itemInfo, SchemaFieldModel schemaField, PocketBaseFieldOptionsFile options) : base(itemInfo, schemaField, options) { }

        /// <inheritdoc />
        protected override List<string> GetLinesForPropertyDecorators()
        {
            var list = base.GetLinesForPropertyDecorators();

            list.Add($"[JsonConverter(typeof(FileConverter<{TypeFileName}>))]");

            return list;
        }

    }
}
