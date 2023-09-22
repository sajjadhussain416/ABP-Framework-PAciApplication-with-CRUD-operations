using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaciApplication.PaciAppInterface
{
    public interface IPaciiApplication
    {
        Task<PaciiAPPlicationDTO> CreateAsync(PaciiAPPlicationDTO input);

        Task<PaciiAPPlicationDTO> GetAsync(Guid id);

        Task<PaciiAPPlicationDTO> UpdateAsync(Guid id, PaciiAPPlicationDTO input);

        Task DeleteAsync(Guid id);


    }
}
