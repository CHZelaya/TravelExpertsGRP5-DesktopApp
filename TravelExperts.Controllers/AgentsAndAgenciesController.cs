namespace TravelExperts.Controllers
{
    using Microsoft.EntityFrameworkCore;
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
        /// Queries DB and returns Agents/Agencies in a List
        /// </summary>
        /// <returns></returns>
        public List<Agency> GetAgencies()
        {
            using (var context = new TravelExpertsContext())
            {
                return _context.Agencies.ToList();
            }
        }

        public List<Agent> GetActiveAgents()
        {
            //return _context.Agents.Where(agent => agent.AgentStatus).ToList();
            using (var context = new TravelExpertsContext())
            {
                return _context.Agents.Where(agent => agent.AgentStatus).ToList();
            }
        }

        // CREATE Operations

        public void AddAgency(Agency agency)
        {
            if (agency == null)
            {
                throw new ArgumentNullException(nameof(agency), "Agency Cannot be Null");
            }

            _context.Agencies.Add(agency);

            _context.SaveChanges();
        }

        public void AddAgent(Agent agent) 
        {
            if (agent == null)
            {
                throw new ArgumentNullException(nameof(agent), "Agent cannot be null!");
            }

            try
            {
                _context.Agents.Add(agent);
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                // Logging the exception
                throw new Exception("An error occured while adding the agent to the database", ex);
            }
            catch (Exception ex) 
            {   //Handling other exceptions
                throw new Exception("An unexpected error occured", ex);
            }

        }

        public void UpdateAgent(Agent agent)
        {
            if (agent == null)
            {
                throw new ArgumentNullException(nameof(agent), "Agent cannot be null!");
            }

            try
            {
                // Find the existing agent in the database
                var existingAgent = _context.Agents.Find(agent.AgentId); // Assuming AgentId is the primary key

                if (existingAgent == null)
                {
                    throw new InvalidOperationException("Agent not found in the database.");
                }

                // Update the properties of the existing agent
                existingAgent.AgtFirstName = agent.AgtFirstName;
                existingAgent.AgtMiddleInitial = agent.AgtMiddleInitial;
                existingAgent.AgtLastName = agent.AgtLastName;
                existingAgent.AgtBusPhone = agent.AgtBusPhone;
                existingAgent.AgtEmail= agent.AgtEmail;
                existingAgent.AgtPosition= agent.AgtPosition;
                existingAgent.AgentStatus = agent.AgentStatus; // Assuming this is a bit field

                // Save changes to the database
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                // Logging the exception
                throw new Exception("An error occurred while updating the agent in the database", ex);
            }
            catch (Exception ex)
            {
                // Handling other exceptions
                throw new Exception("An unexpected error occurred", ex);
            }
        }


    }
}
