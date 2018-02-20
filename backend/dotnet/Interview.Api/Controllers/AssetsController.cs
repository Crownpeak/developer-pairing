using System;
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
  [Route("api/assets")]
  [DisableCors]
  public class AssetsController : Controller
  {
    private readonly InterviewDbContext _dbContext;

    public AssetsController(InterviewDbContext dbContext)
    {
      _dbContext = dbContext;
    }


    /// <summary>
    /// Return all assets in a system localhost:8080/api/assets
    /// </summary>
    /// <returns></returns>
    [HttpGet("")]
    public async Task<IActionResult> GetAsync()
    {
      return Ok(await _dbContext.Assets.Where(x => x.IsDeleted == false).ToListAsync<Asset>());
    }

    /// <summary>
    /// Return all assets in a system localhost:8080/api/assets
    /// </summary>
    /// <returns></returns>
    [HttpGet("deleted")]
    public async Task<IActionResult> GetDeletedAsync()
    {
      return Ok(await _dbContext.Assets.Where(x => x.IsDeleted == true).ToListAsync<Asset>());
    }

    /// <summary>
    /// Get an asset by assetId localhost:8080/api/assets/1
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
    [HttpPost("")]
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
    /// Create an asset
    /// </summary>
    /// <param name="newAsset"></param>
    /// <returns></returns>
    [HttpPut("")]
    public async Task<IActionResult> UpdateAsync([FromBody] AssetDTO asset)
    {
      if (!await _dbContext.Assets.AnyAsync(x => x.Id == asset.Id))
      {
        return BadRequest();
      }

      var valToUpdate = _dbContext.Assets.First(x => x.Id == asset.Id);
      valToUpdate.Name = asset.Name;
      valToUpdate.IsDeleted = asset.IsDeleted;

      _dbContext.Assets.Update(valToUpdate);
      _dbContext.SaveChanges();
      return Ok(valToUpdate);
    }

    /// <summary>
    /// Delete an asset
    /// </summary>
    /// <param name="assetId"></param>
    /// <returns></returns>
    [HttpDelete("{assetId}")]
    public async Task<IActionResult> DeleteAsync(int assetId)
    {
      if (!await _dbContext.Assets.AnyAsync(x => x.Id == assetId))
      {
        return BadRequest();
      }
      var valToRemove = await _dbContext.Assets.FirstOrDefaultAsync(x => x.Id == assetId);
      valToRemove.IsDeleted = true;
      _dbContext.Assets.Update(valToRemove);
      await _dbContext.SaveChangesAsync();
      return Ok(valToRemove);
    }

    /// <summary>
    /// Delete an asset
    /// </summary>
    /// <param name="assetId"></param>
    /// <returns></returns>
    [HttpDelete("force/{assetId}")]
    public async Task<IActionResult> ForceDeleteAsync(int assetId)
    {
      if (!await _dbContext.Assets.AnyAsync(x => x.Id == assetId))
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
