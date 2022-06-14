using System;
using Microsoft.EntityFrameworkCore;


namespace dotnet_app.Context
{
	public partial class DotnetAppContext : DbContext
    { 

		public DotnetAppContext(DbContextOptions<DotnetAppContext> options)
            : base(options)
        {
        }

    }
}

