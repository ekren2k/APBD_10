using Microsoft.AspNetCore.Mvc;

namespace APBD_10.Controllers;

[Route("api/devices")]
public class DevicesCotroller : ControllerBase
{
    public DevicesCotroller()
    {
        
    }

    [HttpGet]
    public async Task<IActionResult> GetDevicesAsync()
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> AddDeviceAsync([FromBody] Device device)
    {
        return Ok();
    }
}