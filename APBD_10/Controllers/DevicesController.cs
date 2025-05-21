using APBD_10.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace APBD_10.Controllers;


[ApiController]
[Route("api/devices")]
public class DevicesController : ControllerBase
{
    
    private readonly IDeviceService _deviceService;
    public DevicesController(IDeviceService deviceService)
    {
        _deviceService = deviceService;
    }

    [HttpGet]
    public async Task<IActionResult> GetDevicesAsync()
    {
        var devices = await _deviceService.GetAllDevicesAsync();
        return Ok(devices);
    }
    
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetDeviceByIdAsync(int id)
    {
        var device = await _deviceService.GetDeviceByIdAsync(id);
        if (device == null)
            return NotFound($"Device with ID {id} not found");

        return Ok(device);
    }

    [HttpPost]
    public async Task<IActionResult> AddDeviceAsync([FromBody] DeviceCreateOrUpdateDto device)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        try
        {
            var createdDevice = await _deviceService.CreateDeviceAsync(device);
            return Created(string.Empty, createdDevice);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateDeviceAsync(int id, [FromBody] DeviceCreateOrUpdateDto dto)
    {
        try
        {
            await _deviceService.UpdateDeviceAsync(id, dto);
            return NoContent();
        }
        catch (KeyNotFoundException e)
        {
            return NotFound(e.Message);
        }
        catch (ArgumentException e)
        {
            return BadRequest(e.Message);
        }
    }
    
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteDeviceAsync(int id)
    {
        try
        {
            await _deviceService.DeleteDeviceAsync(id);
            return NoContent();
        }
        catch (KeyNotFoundException e)
        {
            return NotFound(e.Message);
        }
    }
}