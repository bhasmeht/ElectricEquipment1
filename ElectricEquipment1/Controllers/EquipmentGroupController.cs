using ElectronicEquipment.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ElectronicEquipment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    public class EquipmentGroupController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public readonly UserContext _context;
        public EquipmentGroupController(IConfiguration configuration, UserContext context)
        {
            _configuration = configuration;
            _context = context;
        }
        [HttpGet("getEquipmentCategoryByGroupId/{id}")]
        public IActionResult GetequipmentGroupbyId(int id)
        {
            var equipmentCategoryList = _context.EquipmentGroups.Where(u => u.EquipmentCategoryId == id)
                .Select(a => new { a.EquipmentGroupId, a.EquipmentGroupName });
            return Ok(equipmentCategoryList);
        }

        [HttpPost("addEquipmentGroup")]
        public IActionResult Add(EquipmentGroup equipmentGroup)
        {
            if (_context.EquipmentGroups.Where(u => u.EquipmentGroupName == equipmentGroup.EquipmentGroupName).FirstOrDefault() != null)
            {
                return Ok("Exist");
            }
            _context.EquipmentGroups.Add(equipmentGroup);
            _context.SaveChanges();
            return Ok("Success");
        }

        [HttpPut("updateEquipmentGroup")]
        public IActionResult UpdateEquipmentCategory(EquipmentGroup equipmentGroup)
        {
            var equipmentGroups = _context.EquipmentGroups.Where(u => u.EquipmentGroupId == equipmentGroup.EquipmentGroupId).FirstOrDefault();
            if (equipmentGroups == null)
            {
                return Ok("NotAvailable");
            }
            equipmentGroups.EquipmentGroupName = equipmentGroup.EquipmentGroupName;
            equipmentGroups.EquipmentCategoryId = equipmentGroup.EquipmentCategoryId;
            _context.Update(equipmentGroups);
            _context.SaveChanges();
            return Ok("Success");
        }

        [HttpDelete("deleteEquipmentGroup/{id}")]
        public IActionResult DeleteEquipmentGroup(int id)
        {
            var equipmentGroups = _context.EquipmentGroups.Where(u => u.EquipmentGroupId == id).FirstOrDefault();
            if (equipmentGroups == null)
            {
                return Ok("NotAvailable");
            }
            _context.EquipmentGroups.Remove(equipmentGroups);
            _context.SaveChanges();
            return Ok("Success");
        }
    }
}
