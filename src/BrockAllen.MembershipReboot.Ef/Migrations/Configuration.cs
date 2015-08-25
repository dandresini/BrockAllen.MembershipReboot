namespace BrockAllen.MembershipReboot.Ef.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class Configuration : DbMigrationsConfiguration<BrockAllen.MembershipReboot.Ef.DefaultMembershipRebootDatabase>
    {

         public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

         protected override void Seed(DefaultMembershipRebootDatabase context)
         {
             base.Seed(context);
         }
    }
}
