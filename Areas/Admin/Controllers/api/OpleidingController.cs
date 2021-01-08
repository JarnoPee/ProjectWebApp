using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Data;
using ProjectWebApp.Data.UnitOfWork;
using ProjectWebApp.Models;

namespace ProjectWebApp.Areas.Admin.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpleidingController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public OpleidingController(ApplicationDbContext context, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Opleiding
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Opleiding>>> GetOpleidingen()
        {
            return await _unitOfWork.OpleidingRepository.GetAll().ToListAsync();
        }

        // GET: api/Bestelling/lijst
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("lijst")]
        public async Task<ActionResult<IEnumerable<Opleiding>>> GetBestellingenlijst()
        {
            return await _unitOfWork.OpleidingRepository.GetAll().Include(o => o.Algemeenheden).Include(o => o.Categorie).Include(o => o.Federatie).Include(o => o.Niveau).Include(o => o.Omschrijving).Include(o => o.Slot).Include(o => o.Voorwaarden).ToListAsync();
        }
        // GET: api/Opleiding/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Opleiding>> GetOpleiding(int id)
        {
            var opleiding = await _unitOfWork.OpleidingRepository.GetById(id);

            if (opleiding == null)
            {
                return NotFound();
            }

            return opleiding;
        }

        // PUT: api/Opleiding/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOpleiding(int id, Opleiding opleiding)
        {
            if (id != opleiding.Id)
            {
                return BadRequest();
            }

            _unitOfWork.OpleidingRepository.Update(opleiding);
            await _unitOfWork.Save();

            return NoContent();
        }

        // POST: api/Opleiding
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Opleiding>> PostOpleiding(Opleiding opleiding)
        {
            _unitOfWork.OpleidingRepository.Create(opleiding);
            await _unitOfWork.Save(); 

            return CreatedAtAction("GetOpleiding", new { id = opleiding.Id }, opleiding);
        }

        // DELETE: api/Opleiding/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Opleiding>> DeleteOpleiding(int id)
        {
            var opleiding = await _unitOfWork.OpleidingRepository.GetById(id);
            if (opleiding == null)
            {
                return NotFound();
            }

            _unitOfWork.OpleidingRepository.Delete(opleiding);
            await _unitOfWork.Save();

            return opleiding;
        }

    }
}
