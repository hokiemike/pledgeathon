using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using PledgeAThon.DataLayer.Context;
using PledgeAThon.DataLayer.UnitOfWork;
using PledgeAThon.Models.Domain;

namespace PledgeAThon.DataLayer.Repository
{
    public class ParticipantGroupRepository : IRepository<ParticipantGroup,int>
    {

        private readonly PaTContext _context;

        public ParticipantGroupRepository(PaTContext aContext)
        {
            _context = aContext;
        }


        public void Flush()
        {
            _context.SaveChanges();
        }

        public void Insert(ParticipantGroup entity) 
        {
            _context.Groups.Add(entity);
        }

        public void Update(ParticipantGroup entity)
        {
            _context.Groups.Attach(entity);
        }

        public void Delete(ParticipantGroup entity)
        {
            _context.Groups.Remove(entity);
        }

        public IList<ParticipantGroup> GetAll()
        {
            return _context.Groups.ToList();
        }

        public ParticipantGroup GetById(int id)
        {
            return _context.Groups.Find(id);;
        }

       
    }
}
