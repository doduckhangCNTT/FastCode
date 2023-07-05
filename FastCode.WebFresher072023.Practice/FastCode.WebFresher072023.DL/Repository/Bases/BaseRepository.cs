using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCode.WebFresher072023.DL.Repository.Bases
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
    {
        #region Field
        private readonly string _connectionString; // biến kết nối db
        #endregion

        #region Constructor
        /// <summary>
        /// - Hàm khởi tạo thực hiện cung cấp chuỗi kết nối db
        /// </summary>
        /// <param name="configuration"></param>
        /// CreatedBy: DDKhang (23/5/2023)
        public BaseRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection") ?? "";
        }
        #endregion

        /// <summary>
        /// - Thực hiện mở kết nối đến database
        /// </summary>
        /// <returns>DbConnection</returns>
        /// CreatedBy: DDKhang (23/5/2023)
        public virtual async Task<DbConnection> GetOpenConnectionAsync()
        {
            var connection = new MySqlConnection(_connectionString);
            await connection.OpenAsync();
            return connection;
        }
    }
}
