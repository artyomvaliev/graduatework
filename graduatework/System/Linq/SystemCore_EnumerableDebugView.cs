using System.Data.SqlClient;

namespace System.Linq
{
    internal class SystemCore_EnumerableDebugView
    {
        private SqlParameterCollection parameters;

        public SystemCore_EnumerableDebugView(SqlParameterCollection parameters)
        {
            this.parameters = parameters;
        }
    }
}