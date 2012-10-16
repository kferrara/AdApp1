using System.Collections.Generic;
using System.Data.Entity;
using AdApp1.Models;

namespace AdApp1
{
    public class EntitiesContextInitializer : DropCreateDatabaseIfModelChanges<AdApp1Db> 
    {
        protected override void Seed(AdApp1Db context)     
        {         
            var regionTypes = new List<RegionType>
                                  {
                                      new RegionType { Name = "North East" },
                                      new RegionType { Name = "Mid Atlantic" },
                                      new RegionType { Name = "South East" },
                                      new RegionType { Name = "West" }
                                  };
      
            foreach (var r in regionTypes)
            {
                context.RegionTypes.Add(r);
            }         
            
            var emailTypes = new List<EmailType>
                                  {
                                      new EmailType { Name = "Home" },
                                      new EmailType { Name = "Work" }
                                  };
       
            foreach (var e in emailTypes)
            {
                context.EmailTypes.Add(e);
            }

            var contactTypes = new List<ContactType>
                                  {
                                      new ContactType { Name = "Personal" },
                                      new ContactType { Name = "Business" }
                                  };
        
            foreach (var c in contactTypes)
            {
                context.ContactTypes.Add(c);
            }

            var businesses = new List<Business>
                                  {
                                      new Business { Name = "Acme Ltd", Information = "A products company"},
                                      new Business { Name = "Ace Hardware", Information = "A hardware company" },
                                      new Business { Name = "Duracell", Information = "A battery company" }
                                  };
        
            foreach (var b in businesses)
            {
                context.Businesses.Add(b);
            }

            var roles = new List<RoleType>
                                  {
                                      new RoleType { Name = "Customer" },
                                      new RoleType { Name = "Business Owner"},
                                      new RoleType { Name = "Administrator"}
                                  };

            var categories = new List<Category>
                                  {
                                      new Category { Name = "Autos" },
                                      new Category { Name = "Contractors"},
                                      new Category { Name= "Shopping"},
                                      new Category { Name = "Personal Care"},
                                      new Category { Name = "Restaurants"},
                                      new Category { Name = "Home & Garden"}
                                  };

            foreach (var c in categories)
            {
                context.Categories.Add(c);
            } 
            
            context.SaveChanges();     
        } 
    }
}