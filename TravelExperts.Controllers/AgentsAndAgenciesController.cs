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

        public AgentsAndAgenciesControllers()
        {
        }


        /// <summary>
        /// Queries DB and returns Agents/Agencies in a List
        /// </summary>
        /// <returns></returns>
        public List<Agency> GetActiveAgencies()
        {
            using (var context = new TravelExpertsContext())
            {
                return _context.Agencies.Where(agencies => agencies.AgencyStatus).ToList();
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

        public void UpdateAgency(Agency agency)
        {
            if (agency == null)
            {
                throw new ArgumentNullException(nameof(agency), "Agency cannot be null!");
            }
            try
            {
                var existingAgency = _context.Agencies.Find(agency.AgencyId);

                if ( existingAgency == null)
                {
                    throw new InvalidOperationException("Agency ID cannot be found in the database");
                }

                //Update the properties of the existing Agency
                existingAgency.AgncyAddress = agency.AgncyAddress;
                existingAgency.AgncyCity = agency.AgncyCity;
                existingAgency.AgncyProv = agency.AgncyProv;
                existingAgency.AgncyPostal = agency.AgncyPostal;
                existingAgency.AgncyCountry = agency.AgncyCountry;
                existingAgency.AgncyPhone = agency.AgncyPhone;
                existingAgency.AgncyFax = agency.AgncyFax;

                _context.Agencies.Update(agency);
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("An error occured while trying to modify the existing agency");
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occured", ex);
            }

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
                var existingAgent = _context.Agents.Find(agent.AgentId); 

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
                existingAgent.AgentStatus = agent.AgentStatus; 

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

        public void DeleteAgent(Agent agent)
        {
            if (agent == null)
            {
                throw new ArgumentNullException(nameof(agent), "Agent cannot be null");
            }
            try
            {
                var existingAgent = _context.Agents.Find(agent.AgentId);
                if (existingAgent == null)
                {
                    throw new InvalidOperationException("Agent not found in the database.");
                }

                existingAgent.AgentStatus = agent.AgentStatus;

                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("An error occured while deleting the agent from the database", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occured", ex);
            }
        }

        public void DeleteAgency(Agency agency)
        {
            if (agency == null)
            {
                throw new ArgumentNullException(nameof(agency), "Agency cannot be null");
            }
            try
            {
                var existingAgency = _context.Agencies.Find(agency.AgencyId);
                if (existingAgency == null)
                {
                    throw new InvalidOperationException("Agency not found in the database.");
                }

                existingAgency.AgencyStatus = agency.AgencyStatus;

                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("An error occured while deleting the agency from the database", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occured", ex);
            }

        }

    }
}
