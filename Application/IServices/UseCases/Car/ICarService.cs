﻿using System;
using System.Collections.Generic;
using System;
using Application.DTOs.Car;

namespace Application.IServices.UseCases
{
    public interface ICarService
    {
        Task<GetCarDTO> CreateCarAsync(CreateCarDTO dto);
        Task UpdateCarAsync(UpdateCarDTO dto);
        Task DeleteCarAsync(int id);
        Task<IEnumerable<GetCarDTO>> GetAllCarsAsync();
        Task<GetCarDTO> GetCarByIdAsync(int id);
        Task<IEnumerable<GetCarDTO>> GetCarsByCategoryAsync(int categoryId);
        Task<IEnumerable<GetCarDTO>> GetAvailableCarsAsync(DateTime startDate, DateTime endDate);
        

    }
}
