using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTable.Data;

namespace TimeTable.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : Controller
    {
        private readonly ProjectRepository projectRepository;

        public ProjectController(ProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }


        //GET: api/Project/Projects
        [HttpGet("Projects")]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjects()
        {
            return await this.projectRepository.GetAll();
        }

        //POST: api/Project/Projects
        [HttpPost("Projects")]
        public async Task<IActionResult> PostProject(Project project)
        {
            await this.projectRepository.Add(project);
            return CreatedAtAction("PostProject", new { id = project.ProjectId }, project);
        }

    }
}
