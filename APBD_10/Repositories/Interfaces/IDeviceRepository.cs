namespace APBD_10.Repositories;

public interface IDeviceRepository
{
    Task<Device?> GetByIdAsync(int id);
    Task<IEnumerable<Device>> GetAllAsync();
    Task<Device> AddAsync(Device device);
    Task Update(Device device);
    Task DeleteAsync(int id);
    Task<bool> ExistsAsync(int id);
    Task<DeviceType?> GetDeviceTypeByNameAsync(string name);
    Task<DeviceEmployee?> GetCurrentAssignmentAsync(int deviceId);
}