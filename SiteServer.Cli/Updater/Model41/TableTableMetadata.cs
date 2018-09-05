﻿using System.Collections.Generic;
using Newtonsoft.Json;
using SiteServer.CMS.Core;
using SiteServer.CMS.Model;
using SiteServer.Plugin;

namespace SiteServer.Cli.Updater.Model41
{
    public partial class TableTableMetadata
    {
        [JsonProperty("tableMetadataID")]
        public long TableMetadataId { get; set; }

        [JsonProperty("auxiliaryTableENName")]
        public string AuxiliaryTableEnName { get; set; }

        [JsonProperty("attributeName")]
        public string AttributeName { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("dataLength")]
        public long DataLength { get; set; }

        [JsonProperty("canBeNull")]
        public string CanBeNull { get; set; }

        [JsonProperty("dbDefaultValue")]
        public string DbDefaultValue { get; set; }

        [JsonProperty("taxis")]
        public long Taxis { get; set; }

        [JsonProperty("isSystem")]
        public string IsSystem { get; set; }
    }

    public partial class TableTableMetadata
    {
        public const string OldTableName = "TableMetadata";

        public static ConvertInfo Converter => new ConvertInfo
        {
            NewTableName = NewTableName,
            NewColumns = NewColumns,
            ConvertKeyDict = ConvertKeyDict
        };

        private static readonly string NewTableName = DataProvider.TableMetadataDao.TableName;

        private static readonly List<TableColumn> NewColumns = DataProvider.TableMetadataDao.TableColumns;

        private static readonly Dictionary<string, string> ConvertKeyDict =
            new Dictionary<string, string>
            {
                {nameof(TableMetadataInfo.Id), nameof(TableMetadataId)},
                {nameof(TableMetadataInfo.TableName), nameof(AuxiliaryTableEnName)}
            };
    }
}
