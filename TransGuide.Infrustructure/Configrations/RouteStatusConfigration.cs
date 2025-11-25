using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransGuide.Data.Entities.ApplicationEtities;

namespace TransGuide.Infrustructure.Configrations
{
	public class RouteStatusConfigration : IEntityTypeConfiguration<RouteStatus>
	{
		public void Configure(EntityTypeBuilder<RouteStatus> builder)
		{
			builder.HasKey(rs => rs.Id);
			builder.Property(rs => rs.Name).IsRequired().HasMaxLength(100);
		}
	}
}
