﻿using ApiApp.Dto;
using ApiApp.Mapper;
using LogicaAplicacion.UseCases.Interfaces;
using LogicaNegocio.Entidades;
using LogicaNegocio.Excepciones;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private ICreate<Match> _ucCreateMatch;
        private IRead<NationalTeam> _ucReadNationalTeam;


        public MatchController(
                ICreate<Match> ucCreateMatch,
                IRead<NationalTeam> ucReadNationalTeam
            )
        {
            _ucCreateMatch = ucCreateMatch;
            _ucReadNationalTeam = ucReadNationalTeam;
        }

        [HttpPost]
        public IActionResult Create(MatchDto mDto)
        {
            if(mDto == null)
            {
                return BadRequest("Data didn't send.");
            }
            try
            {
                Match m = MatchMapper.ToMatch(mDto);
                m.Home = _ucReadNationalTeam.FindById(mDto.HomeId);
                m.Away = _ucReadNationalTeam.FindById(mDto.AwayId);
                _ucCreateMatch.Create(m);
                return Ok(mDto);
            }
            catch (DomainException e)
            {
                return BadRequest(e.Message);
            }
            catch(Exception)
            {
                return StatusCode(500, "Something was wrong, try again later.");
            }
        }
    }
}