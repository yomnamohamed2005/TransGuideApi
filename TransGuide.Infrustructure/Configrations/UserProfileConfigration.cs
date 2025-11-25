using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransGuide.Data.Entities.ApplicationEntities;
using TransGuide.Data.Entities.Identity;

namespace TransGuide.Infrustructure.Configrations
{
	public class UserProfileConfigration : IEntityTypeConfiguration<UserProfile>
	{
	
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<UserProfile> builder)
		{
			builder.HasKey(ts => ts.Id);
			builder.Property(ts => ts.UserName).IsRequired().HasMaxLength(100);
		}
	}
}
