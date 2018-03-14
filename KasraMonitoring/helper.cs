using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace KasraMonitoring
{
    public static class helper
    {
        public static string safeGetString(this SqlDataReader reader, int colIndex, string def = "")
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            return def;

        }
    }
}
