﻿//using Microsoft.EntityFrameworkCore;
//using Repository;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TestOurShop
//{
//    public class DatabaseFixture:IDisposable
//    {
//        public AdeNetManageContext Context { get; private set; }

//        public DatabaseFixture()
//        {
//            var options = new DbContextOptionsBuilder<AdeNetManageContext>()
//                .UseSqlServer("Server=srv2\\pupils;Database=Test328268628;Trusted_Connection=True;TrustServerCertificate=True")
//                .Options;
//            Context = new AdeNetManageContext(options);
//            Context.Database.EnsureCreated();

//        }
//        public void Dispose()
//        {
//            Context.Database.EnsureDeleted();
//            Context.Dispose();
//        }
//    }
//}
