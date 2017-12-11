using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interview.Data;
using Interview.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Interview.Api.Controllers
{
  [Route("api/[controller]")]
  [DisableCors]
  public class AssetsController : Controller
  {
    private InterviewDbContext _dbContext;

    public AssetsController(InterviewDbContext dbContext)
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
      return Ok(await _dbContext.Assets.ToListAsync<Asset>());
    }

    /// <summary>
    /// Get an asset by assetId
    /// </summary>
    /// <param name="assetId"></param>
    /// <returns></returns>
    [HttpGet("get/{assetId}")]
    public async Task<IActionResult> GetAsync(int assetId)
    {
      if (await _dbContext.Assets.AnyAsync(x => x.Id == assetId))
      {
        return BadRequest();
      }
      var valToRemove = await _dbContext.Assets.FirstOrDefaultAsync(x => x.Id == assetId);
      _dbContext.Assets.Remove(valToRemove);
      await _dbContext.SaveChangesAsync();
      return Ok(valToRemove);
    }

    /// <summary>
    /// Create an asset
    /// </summary>
    /// <param name="newAsset"></param>
    /// <returns></returns>
    [HttpPut("create")]
    public async Task<IActionResult> CreateAsync([FromBody] Asset newAsset)
    {
      if (await _dbContext.Assets.AnyAsync(x => x.Id == newAsset.Id))
      {
        return BadRequest();
      }
      _dbContext.Assets.Add(newAsset);
      _dbContext.SaveChanges();
      return Ok(newAsset);
    }

    /// <summary>
    /// Delete an asset
    /// </summary>
    /// <param name="assetId"></param>
    /// <returns></returns>
    [HttpDelete("delete/{assetId}")]
    public async Task<IActionResult> DeleteAsync(int assetId)
    { 
      if (await _dbContext.Assets.AnyAsync(x => x.Id == assetId))
      {
        return BadRequest();
      }
      var valToRemove = await _dbContext.Assets.FirstOrDefaultAsync(x => x.Id == assetId);
      _dbContext.Assets.Remove(valToRemove);
      await _dbContext.SaveChangesAsync();
      return Ok(valToRemove);
    }
  }
}