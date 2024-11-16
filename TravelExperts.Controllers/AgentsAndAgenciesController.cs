namespace TravelExperts.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using TravelExperts.Models.Models;

    public class AgentsAndAgenciesControllers
    {
        private readonly TravelExpertsContext _context;

        public AgentsAndAgenciesControllers(TravelExpertsContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Queries DB and returns Agents in a List
        /// </summary>
        /// <returns></returns>
        public List<Agency> GetAgencies()
        {
            return _context.Agencies.ToList();
        }

        public List<Agent> GetAgents()
        {
            return _context.Agents.ToList();
        }
    }
}
