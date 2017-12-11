using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interview.Data;
using Interview.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Interview.Api.Controllers
{
  [Route("api/[controller]")]
  public class AssetsFieldsController : Controller
  {
    private InterviewDbContext _dbContext;

    public AssetsFieldsController(InterviewDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    
    /// <summary>
    /// Return all assets in a system
    /// </summary>
    /// <returns></returns>
    [Route("getall")]
    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
      return Ok(await _dbContext.AssetFields.ToListAsync<AssetFields>());
    }

    /// <summary>
    /// Get an asset by assetId
    /// </summary>
    /// <param name="assetFieldId"></param>
    /// <returns></returns>
    [HttpGet("get/{assetId}")]
    public async Task<IActionResult> GetAsync(int assetFieldId)
    {
      if (await _dbContext.AssetFields.AnyAsync(x => x.Id == assetFieldId))
      {
        return BadRequest();
      }
      var valToRemove = await _dbContext.AssetFields.FirstOrDefaultAsync(x => x.Id == assetFieldId);
      _dbContext.AssetFields.Remove(valToRemove);
      await _dbContext.SaveChangesAsync();
      return Ok(valToRemove);
    }

    /// <summary>
    /// Create an asset
    /// </summary>
    /// <param name="newAssetField"></param>
    /// <returns></returns>
    [HttpPut("create")]
    public async Task<IActionResult> CreateAsync([FromBody] AssetFields newAssetField)
    {
      if (await _dbContext.AssetFields.AnyAsync(x => x.Id == newAssetField.Id))
      {
        return BadRequest();
      }
      _dbContext.AssetFields.Add(newAssetField);
      _dbContext.SaveChanges();
      return Ok(newAssetField);
    }

    /// <summary>
    /// Delete an asset
    /// </summary>
    /// <param name="assetFieldId"></param>
    /// <returns></returns>
    [HttpDelete("delete/{assetId}")]
    public async Task<IActionResult> DeleteAsync(int assetFieldId)
    { 
      if (await _dbContext.AssetFields.AnyAsync(x => x.Id == assetFieldId))
      {
        return BadRequest();
      }
      var valToRemove = await _dbContext.AssetFields.FirstOrDefaultAsync(x => x.Id == assetFieldId);
      _dbContext.AssetFields.Remove(valToRemove);
      await _dbContext.SaveChangesAsync();
      return Ok(valToRemove);
    }
  }
}