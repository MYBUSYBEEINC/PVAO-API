using PVAO.ApplicationCore.DTOs;
using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PVAO.ApplicationCore.Services
{
    public class SettingsService : ISettingsService
    {
        private readonly ISettingsRepository _repository;

        public SettingsService(ISettingsRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<Settings> Get()
        {
            return _repository.Get();
        }

        public async Task<Settings> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<Settings> Add(SettingsDTO settingsDTO)
        {
            var settings = new Settings()
            {
                FromEmail = settingsDTO.FromEmail,
                FromName = settingsDTO.FromName,
                ServerName = settingsDTO.ServerName,
                SMTPPort = settingsDTO.SMTPPort,
                Username = settingsDTO.Username,
                Password = settingsDTO.Password,
                EnableSSL = settingsDTO.EnableSSL,
                MaxSignOnAttempts = settingsDTO.MaxSignOnAttempts,
                ExpiresIn = settingsDTO.ExpiresIn,
                MinPasswordLength = settingsDTO.MinPasswordLength,
                MinSpecialCharacters = settingsDTO.MinSpecialCharacters,
                EnforcePasswordHistory = settingsDTO.EnforcePasswordHistory,
                CreatedBy = settingsDTO.CreatedBy,
                DateCreated = settingsDTO.DateCreated
            };

            try
            {
                return await _repository.Add(settings);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Settings> Update(SettingsDTO settingsDTO)
        {
            var settings = _repository.GetById(settingsDTO.Id).Result;

            settings.FromEmail = settingsDTO.FromEmail;
            settings.FromName = settingsDTO.FromName;
            settings.ServerName = settingsDTO.ServerName;
            settings.SMTPPort = settingsDTO.SMTPPort;
            settings.Username = settingsDTO.Username;
            settings.Password = settingsDTO.Password;
            settings.EnableSSL = settingsDTO.EnableSSL;
            settings.MaxSignOnAttempts = settingsDTO.MaxSignOnAttempts;
            settings.ExpiresIn = settingsDTO.ExpiresIn;
            settings.MinPasswordLength = settingsDTO.MinPasswordLength;
            settings.MinSpecialCharacters = settingsDTO.MinSpecialCharacters;
            settings.EnforcePasswordHistory = settingsDTO.EnforcePasswordHistory;
            settings.UpdatedBy = settings.UpdatedBy;
            settings.DateUpdated = settings.DateUpdated;

            return await _repository.Update(settings);
        }
    }
}
