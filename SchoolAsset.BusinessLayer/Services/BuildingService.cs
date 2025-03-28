﻿using SchoolAsset.BusinessLayer.ViewModels;
using SchoolAsset.DataLayer.IRepository;
using SchoolAsset.DataLayer.Models;

namespace SchoolAsset.BusinessLayer.Services
{
    public class BuildingService
    {
        private readonly IUnitOfWork _unitOfWork;
        public BuildingService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Building>> GetBuildingAll()
        {
            var products = await _unitOfWork.Buildings.GetAllAsync();
            return products.ToList();
        }

        public async Task<Building?> GetBuildingById(int id)
        {
            return await _unitOfWork.Buildings.GetByIdAsync(b => b.BuildingId == id);
        }

        public async Task<bool> AddBuilding(BuildingDTO buildingDTO)
        {
            var building = new Building
            {
                BuildingName = buildingDTO.BuildingName,
                Location = buildingDTO.Location,
                Status = buildingDTO.Status,
                Building_Date = DateTime.Now
            };
            await _unitOfWork.Buildings.AddAsync(building);
            int result = await _unitOfWork.CompleteAsync();
            return result > 0;
        }

        public async Task<bool> UpdateBuilding(int id, BuildingDTO buildingDTO)
        {
            var building = _unitOfWork.Buildings.GetByIdAsync(b => b.BuildingId == id).Result;
            if (building == null)
            {
                return false;
            }
            building.BuildingName = buildingDTO.BuildingName;
            building.Location = buildingDTO.Location;
            building.Status = buildingDTO.Status;
            int result = await _unitOfWork.CompleteAsync();
            return result > 0;
        }

        public async Task<bool> DeleteBuilding(int id)
        {
            var building = await _unitOfWork.Buildings.GetByIdAsync(b => b.BuildingId == id);
            if (building == null)
            {
                return false;
            }
            _unitOfWork.Buildings.Remove(building);
            int result = await _unitOfWork.CompleteAsync();
            return result > 0;
        }
    }
}
