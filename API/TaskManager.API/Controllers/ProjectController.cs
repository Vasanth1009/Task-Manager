﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManager.API.Common.Helpers;
using TaskManager.API.DTOs;
using TaskManager.API.Services.Interfaces;

namespace TaskManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : BaseController
    {
        private readonly IProjectService _service;

        public ProjectController(IProjectService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjectResponse>>> Get()
        {
            var projects = await _service.GetProjectsAsync(Guid.Parse("FB7A0BD1-10C1-4608-AA4C-E83959B3F2FB"));
            return Ok(projects);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectResponse>> Get(Guid id)
        {
            var project = await _service.GetProjectAsync(id);
            return Ok(project);
        }
        [HttpPost]
        public async Task<ActionResult<ProjectResponse>> Post(ProjectRequest projectRequest)
        {
            var project = await _service.AddProjectAsync(projectRequest, CurrentUser.Id);
            return Ok(project);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ProjectResponse>> Put(Guid id, ProjectRequest projectRequest)
        {
            var project = await _service.UpdateProjectAsync(id, projectRequest);
            return Ok(project);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<BaseResponse>> Delete(Guid id)
        {
            var project = await _service.RemoveProjectAsync(id);
            return Ok(project);
        }

        [Route("Collapse")]
        [HttpPut]
        public async Task<ActionResult<ProjectResponse>> CollapseProject(Guid id, int Collapsed)
        {
            var project = await _service.CollapseProjectAsync(id, Collapsed);
            return Ok(project);
        }
    }
}
