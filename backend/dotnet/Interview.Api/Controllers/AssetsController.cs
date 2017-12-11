using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interview.Data;
using Interview.Data.DTO;
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
    [HttpGet("")]
    public async Task<IActionResult> GetAsync()
    {
      return Ok(await _dbContext.Assets.ToListAsync<Asset>());
    }

    /// <summary>
    /// Get an asset by assetId
    /// </summary>
    /// <param name="assetId"></param>
    /// <returns></returns>
    [HttpGet("{assetId}")]
    public async Task<IActionResult> GetAsync(int assetId)
    {
      var asset = await _dbContext.Assets.FirstOrDefaultAsync(x => x.Id == assetId);
      if (asset == null)
      {
        return BadRequest();
      }
      return Ok(asset);
    }

    /// <summary>
    /// Create an asset
    /// </summary>
    /// <param name="newAsset"></param>
    /// <returns></returns>
    [HttpPut("")]
    public async Task<IActionResult> CreateAsync([FromBody] AssetDTO newAsset)
    {
      if (await _dbContext.Assets.AnyAsync(x => x.Id == newAsset.Id))
      {
        return BadRequest();
      }
      _dbContext.Assets.Add(new Asset()
      {
        Name = newAsset.Name,
        CreatedBy = new Guid()
      });

      _dbContext.SaveChanges();
      return Ok(newAsset);
    }

    /// <summary>
    /// Delete an asset
    /// </summary>
    /// <param name="assetId"></param>
    /// <returns></returns>
    [HttpDelete("{assetId}")]
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
