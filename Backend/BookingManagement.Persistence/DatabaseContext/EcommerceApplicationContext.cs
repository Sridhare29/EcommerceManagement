using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Ecommerce.Management.Domain.Models;

public partial class EcommerceApplicationContext : DbContext
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;
    public EcommerceApplicationContext(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("EcommerceConnection");
    }
    public IDbConnection CreateConnection()
        => new SqlConnection(_connectionString);


}
