using System;
using System.Data;
using System.Data.SqlClient;

namespace SmayDbEditor.DataAccessLayer.Repository
{
    public class BaseRepository
    {
        protected readonly IDbConnection _wmsConnection;

        private readonly string _smayDbConnString = System.Configuration.ConfigurationManager.ConnectionStrings["LocalSmayDB"].ConnectionString;

        private IDbConnection _smayDbConnection;
        private IDbConnection _wmsSmayDbConnection;
        public BaseRepository(IDbConnection connection)
        {
            _wmsConnection = connection;
        }

        protected IDbConnection GetSmayDbConnection()
        {
            if (_smayDbConnection == null)
            {
                _smayDbConnection = new SqlConnection(_smayDbConnString);
            }
            return _smayDbConnection;
        }
    }
}
