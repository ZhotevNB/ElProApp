﻿using ElProApp.Web.Models.JobDone;

namespace ElProApp.Services.Data.Interfaces
{
    public interface IJobDoneService
    {
        Task<string> AddAsync(JobDoneInputModel model);

        Task<JobDoneViewModel> GetByIdAsync(string id);

        Task<JobDoneEditInputModel> EditByIdAsync(string id);

        Task<bool> EditByModelAsync(JobDoneEditInputModel model);

        Task<IEnumerable<JobDoneViewModel>> GetAllAsync();
        Task<bool> SoftDeleteAsync(string id);
    }
}