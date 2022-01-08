using System;
using System.Collections.Generic;

#nullable disable

namespace amanatApi.Models
{
    public partial class SYS_EXPORT_SCHEMA_05
    {
        public int? PROCESS_ORDER { get; set; }
        public int? DUPLICATE { get; set; }
        public int? DUMP_FILEID { get; set; }
        public int? DUMP_POSITION { get; set; }
        public int? DUMP_LENGTH { get; set; }
        public int? DUMP_ORIG_LENGTH { get; set; }
        public int? DUMP_ALLOCATION { get; set; }
        public int? COMPLETED_ROWS { get; set; }
        public int? ERROR_COUNT { get; set; }
        public int? ELAPSED_TIME { get; set; }
        public string OBJECT_TYPE_PATH { get; set; }
        public int? OBJECT_PATH_SEQNO { get; set; }
        public string OBJECT_TYPE { get; set; }
        public string IN_PROGRESS { get; set; }
        public string OBJECT_NAME { get; set; }
        public string OBJECT_LONG_NAME { get; set; }
        public string OBJECT_SCHEMA { get; set; }
        public string ORIGINAL_OBJECT_SCHEMA { get; set; }
        public string ORIGINAL_OBJECT_NAME { get; set; }
        public string PARTITION_NAME { get; set; }
        public string SUBPARTITION_NAME { get; set; }
        public int? DATAOBJ_NUM { get; set; }
        public int? FLAGS { get; set; }
        public int? PROPERTY { get; set; }
        public int? TRIGFLAG { get; set; }
        public int? CREATION_LEVEL { get; set; }
        public DateTime? COMPLETION_TIME { get; set; }
        public string OBJECT_TABLESPACE { get; set; }
        public int? SIZE_ESTIMATE { get; set; }
        public int? OBJECT_ROW { get; set; }
        public string PROCESSING_STATE { get; set; }
        public string PROCESSING_STATUS { get; set; }
        public int? BASE_PROCESS_ORDER { get; set; }
        public string BASE_OBJECT_TYPE { get; set; }
        public string BASE_OBJECT_NAME { get; set; }
        public string BASE_OBJECT_SCHEMA { get; set; }
        public int? ANCESTOR_PROCESS_ORDER { get; set; }
        public int? DOMAIN_PROCESS_ORDER { get; set; }
        public int? PARALLELIZATION { get; set; }
        public int? UNLOAD_METHOD { get; set; }
        public int? LOAD_METHOD { get; set; }
        public int? GRANULES { get; set; }
        public int? SCN { get; set; }
        public string GRANTOR { get; set; }
        public string XML_CLOB { get; set; }
        public int? PARENT_PROCESS_ORDER { get; set; }
        public string NAME { get; set; }
        public string VALUE_T { get; set; }
        public int? VALUE_N { get; set; }
        public int? IS_DEFAULT { get; set; }
        public int? FILE_TYPE { get; set; }
        public string USER_DIRECTORY { get; set; }
        public string USER_FILE_NAME { get; set; }
        public string FILE_NAME { get; set; }
        public int? EXTEND_SIZE { get; set; }
        public int? FILE_MAX_SIZE { get; set; }
        public string PROCESS_NAME { get; set; }
        public DateTime? LAST_UPDATE { get; set; }
        public string WORK_ITEM { get; set; }
        public int? OBJECT_NUMBER { get; set; }
        public int? COMPLETED_BYTES { get; set; }
        public int? TOTAL_BYTES { get; set; }
        public int? METADATA_IO { get; set; }
        public int? DATA_IO { get; set; }
        public int? CUMULATIVE_TIME { get; set; }
        public int? PACKET_NUMBER { get; set; }
        public int? INSTANCE_ID { get; set; }
        public string OLD_VALUE { get; set; }
        public int? SEED { get; set; }
        public int? LAST_FILE { get; set; }
        public string USER_NAME { get; set; }
        public string OPERATION { get; set; }
        public string JOB_MODE { get; set; }
        public int? QUEUE_TABNUM { get; set; }
        public string CONTROL_QUEUE { get; set; }
        public string STATUS_QUEUE { get; set; }
        public string REMOTE_LINK { get; set; }
        public int? VERSION { get; set; }
        public string JOB_VERSION { get; set; }
        public string DB_VERSION { get; set; }
        public string TIMEZONE { get; set; }
        public string STATE { get; set; }
        public int? PHASE { get; set; }
        public byte[] GUID { get; set; }
        public DateTime? START_TIME { get; set; }
        public int? BLOCK_SIZE { get; set; }
        public int? METADATA_BUFFER_SIZE { get; set; }
        public int? DATA_BUFFER_SIZE { get; set; }
        public int? DEGREE { get; set; }
        public string PLATFORM { get; set; }
        public int? ABORT_STEP { get; set; }
        public string INSTANCE { get; set; }
        public int? CLUSTER_OK { get; set; }
        public string SERVICE_NAME { get; set; }
        public string OBJECT_INT_OID { get; set; }
    }
}
