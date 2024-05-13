﻿using DevGardenAPI.Managers;
using log4net;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace DevGardenAPI.Controllers
{
    /// <summary>
    /// Contrôleur de l'application DevGarden pour la partie Issue.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class IssueController : ControllerBase
    {
        /// <summary>
        /// Obtient ou définit le gestionnaire de log.
        /// </summary>
        protected ILog Logger { get; set; }

        /// <summary>
        /// Obtient le manager du service utilisé.
        /// </summary>
        public ExternalServiceManager ExternalServiceManager { get; } =
            new ExternalServiceManager();

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="IssueController"/>.
        /// </summary>
        public IssueController()
        {
            Logger = LogManager.GetLogger(typeof(IssueController));
        }

        [HttpGet("GetAllIssues")]
        public async Task<List<Issue>> GetAllIssues(string owner, string repository, string platform)
        {
            return await ExternalServiceManager.GetController(platform).GetAllIssues(
                owner,
                repository
            );
        }
    }
}
