using APBD_10.DTOs;

namespace APBD_10;

public interface IDeviceService
{
    Task<IEnumerable<DeviceListDto>> GetAllDevicesAsync();
    Task<DeviceDetailDto?> GetDeviceByIdAsync(int id);
    Task<DeviceCreateOrUpdateDto> CreateDeviceAsync(DeviceCreateOrUpdateDto dto);
    Task UpdateDeviceAsync(int id, DeviceCreateOrUpdateDto dto);
    Task DeleteDeviceAsync(int id);
}