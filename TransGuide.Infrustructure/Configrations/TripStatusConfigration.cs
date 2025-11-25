using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransGuide.Data.Entities.ApplicationEntities;

namespace TransGuide.Infrustructure.Configrations
{
	public class TripStatusConfigration : IEntityTypeConfiguration<TripStatus>
	{
		public void Configure(EntityTypeBuilder<TripStatus> builder)
		{
			builder.HasKey(ts => ts.Id);
			builder.Property(ts => ts.Name).IsRequired().HasMaxLength(100);

		}
	}
}
