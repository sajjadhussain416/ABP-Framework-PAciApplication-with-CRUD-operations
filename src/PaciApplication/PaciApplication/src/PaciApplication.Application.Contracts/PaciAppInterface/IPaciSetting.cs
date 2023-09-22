using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaciApplication.PaciAppInterface
{
    public interface IPaciSetting
    {
        Task<PacciSettingDTO> CreateAsync(PacciSettingDTO input);

        Task<PacciSettingDTO> GetAsync(Guid id);

        Task<PacciSettingDTO> UpdateAsync(Guid id, PacciSettingDTO input);

        Task DeleteAsync(Guid id);
    }
}
