using Microsoft.AspNetCore.Mvc;
using velocitaApi.models;

namespace velocitaApi.Interfaces
{
    public interface ICarOptionRepository
    {
        public Task<IActionResult> AddCarOption(CarOption carOption);
        public Task<IActionResult> DeleteCarOption(CarOption carOption);
        public Task<bool> CheckIFExist(int carId, int optionId);
        public Task<CarOption> FindCarOption(int carId, int optionId);
        public Task<IEnumerable<CarOptionCustom>> FindByCarId(int carId);
    }
}