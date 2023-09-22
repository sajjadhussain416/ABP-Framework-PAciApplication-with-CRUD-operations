using PaciApplication.PaciAppInterface;
using PACIModel.Models;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;
namespace PaciApplication.PaciServices
{
    public class PaciSettingService : ApplicationService, IPaciSetting
    {
        private readonly IRepository<PaciSettings, Guid> _paciSettingRepository;
        public PaciSettingService(IRepository<PaciSettings, Guid> paciSettingRepository)
        {
            _paciSettingRepository = paciSettingRepository;
        }
      public async Task<PacciSettingDTO> GetAsync(Guid id)
        {
            return ObjectMapper.Map<PaciSettings, PacciSettingDTO>(await _paciSettingRepository.GetAsync(id));
        }

        public async Task<PacciSettingDTO> CreateAsync(PacciSettingDTO input)
        {
            var entity = ObjectMapper.Map<PacciSettingDTO, PaciSettings>(input);
            entity = await _paciSettingRepository.InsertAsync(entity);

            return ObjectMapper.Map<PaciSettings, PacciSettingDTO>(entity);
        }

        public async Task<PacciSettingDTO> UpdateAsync(Guid id, PacciSettingDTO input)
        {
            var entity = await _paciSettingRepository.GetAsync(id);

            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(PaciSettings), id);
            }

            ObjectMapper.Map(input, entity);

            entity = await _paciSettingRepository.UpdateAsync(entity);

            return ObjectMapper.Map<PaciSettings, PacciSettingDTO>(entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _paciSettingRepository.DeleteAsync(id);
        }
    }
}
