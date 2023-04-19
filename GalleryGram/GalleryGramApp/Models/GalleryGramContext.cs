using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace GalleryGram.Models 
{
  public class GalleryGramContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Picture> Pictures { get; set; }
    public DbSet<Likes> Likes { get; set; }
    public DbSet<DbOrder> DbOrders { get; set; }

    public GalleryGramContext(DbContextOptions options) : base(options) { } 

    protected override void OnModelCreating(ModelBuilder builder)
    {
      PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();  
      
      // Guid user1GID = Guid.NewGuid();
      // string user1ID = user1GID.ToString();
      ApplicationUser user1 = new ApplicationUser();
        // user1.Id = user1ID;
        user1.UserName = "david@gmail.com";
        user1.NormalizedUserName = user1.UserName.ToUpper();
        // user1.Email = "david@gmail.com";
        user1.PasswordHash = passwordHasher.HashPassword(user1, "1!qQwe"); 
      // Guid user2GID = Guid.NewGuid();
      // string user2ID = user1GID.ToString();
      ApplicationUser user2 = new ApplicationUser();
        // user2.Id = user2ID;
        user2.UserName = "robert@gmail.com";
        user2.NormalizedUserName = user2.UserName.ToUpper();
        // user2.Email = "robert@gmail.com";
        user2.PasswordHash = passwordHasher.HashPassword(user2, "1!qQwe"); 
      // Guid user3GID = Guid.NewGuid();
      // string user3ID = user1GID.ToString();
      ApplicationUser user3 = new ApplicationUser();
        // user3.Id = user3ID;
        user3.UserName = "lucas@gmail.com";
        user3.NormalizedUserName = user3.UserName.ToUpper();
        // user3.Email = "lucas@gmail.com";
        user3.PasswordHash = passwordHasher.HashPassword(user3, "1!qQwe"); 

      List<ApplicationUser> users = new List<ApplicationUser>{ user1, user2, user3 };

      builder.Entity<ApplicationUser>()
        .HasData(users);

      Picture pic1 = new Picture();
        pic1.picture_id = 1;
        pic1.user_id = user1.Id;
        pic1.fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/vscode/vscode-original.svg";
      Picture pic2 = new Picture();
        pic2.picture_id = 2;
        pic2.user_id = user1.Id;
        pic2.fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/npm/npm-original-wordmark.svg";
      Picture pic3 = new Picture();
        pic3.picture_id = 3;
        pic3.user_id = user1.Id;
        pic3.fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/msdos/msdos-original.svg";

      Picture pic4 = new Picture();
        pic4.picture_id = 4;
        pic4.user_id = user2.Id;
        pic4.fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/markdown/markdown-original.svg";
      Picture pic5 = new Picture();
        pic5.picture_id = 5;
        pic5.user_id = user2.Id;
        pic5.fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/linkedin/linkedin-original.svg";
      Picture pic6 = new Picture();
        pic6.picture_id = 6;
        pic6.user_id = user2.Id;
        pic6.fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/jquery/jquery-original.svg";
      
      Picture pic7 = new Picture();
        pic7.picture_id = 7;
        pic7.user_id = user3.Id;
        pic7.fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/jest/jest-plain.svg";
      Picture pic8 = new Picture();
        pic8.picture_id = 8;
        pic8.user_id = user3.Id;
        pic8.fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/html5/html5-original.svg";
      Picture pic9 = new Picture();
        pic9.picture_id = 9;
        pic9.user_id = user3.Id;
        pic9.fileName = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/github/github-original.svg";

      List<Picture> pictures = new List<Picture> { pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9 };

      builder.Entity<Picture>()
        .HasData(pictures);
      
      base.OnModelCreating(builder);
    }
  }
}