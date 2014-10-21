using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace BookMe.DAL
{
    public class BlogDbInitializer : DropCreateDatabaseAlways<BlogDataContext>
    {
        protected override void Seed(BlogDataContext context)
        {
            var users = new List<User> { 
             new User(){FirstName="francis",LastName="tchatchoua",JoinDate=DateTime.Today,LastLogin=DateTime.Today},
             new User(){FirstName="nounou",LastName="carine",JoinDate=DateTime.Today,LastLogin=DateTime.Today},
            new User(){FirstName="didier",LastName="njiki",JoinDate=DateTime.Today,LastLogin=DateTime.Today},
            new User(){FirstName="joanna",LastName="kamila",JoinDate=DateTime.Today,LastLogin=DateTime.Today},
            new User(){FirstName="mary",LastName="mbianga",JoinDate=DateTime.Today,LastLogin=DateTime.Today}
            };

            context.Users.AddRange(users);
           
            base.Seed(context);
        }
    }
}
