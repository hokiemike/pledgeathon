using System;
using System.Data.Entity;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PledgeAThon.DataLayer.Context;
using PledgeAThon.DataLayer.Repository;
using PledgeAThon.DataLayer.UnitOfWork;
using PledgeAThon.Models.Domain;

namespace PledgeAThon1.Tests.Models
{
    [TestClass]
    public class GroupTest
    {

        private IRepository<ParticipantGroup,int> _groupRepo;

        [TestInitialize]
        public void Init()
        {
            try
            {
                var ctx = new PaTContext();
                Database.SetInitializer(new TestPledgeAThonDBInitializer());
                ctx.Database.Initialize(true);
                _groupRepo = new ParticipantGroupRepository(ctx);

            }
            catch (Exception e)
            {
                
                throw;
            }
        }


        [TestMethod]
        public void TestSaveGroup()
        {
            var grp = new ParticipantGroup {Name = "3rd Grade - A NEW GROUP", Description = "A NEW GROUP FOR THE TEST - DELETE ME"};
            _groupRepo.Insert(grp);
            _groupRepo.Flush();

        }

        [TestMethod]
        public void TestLoadAllGroups()
        {
            var groups = _groupRepo.GetAll();
            foreach (var participantGroup in groups)
            {
                Debug.WriteLine(participantGroup.Name);
            }
        }
    }
}
