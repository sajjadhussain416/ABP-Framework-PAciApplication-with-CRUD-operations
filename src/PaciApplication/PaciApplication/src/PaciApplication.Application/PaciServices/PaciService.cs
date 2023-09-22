using PaciApplication.PaciAppInterface;
using PACIModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace PaciApplication.PaciServices
{
    public class PaciService: PaciApplicationAppService, IPaciiApplication
    {

        private readonly IRepository<PaciAplication, Guid>
       _productRepository;
     
        public PaciService(
        IRepository<PaciAplication, Guid> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<PaciiAPPlicationDTO> CreateAsync(PaciiAPPlicationDTO input)
        {
            input.ApplicationGuidId = Guid.NewGuid().ToString();
            var entity = ObjectMapper.Map<PaciiAPPlicationDTO, PaciAplication>(input);
            entity = await _productRepository.InsertAsync(entity);
  
            return ObjectMapper.Map<PaciAplication, PaciiAPPlicationDTO>(entity);
        }

        public async Task<PaciiAPPlicationDTO> GetAsync(Guid id)
        {
            var entity = await _productRepository.GetAsync(id);

          
            return ObjectMapper.Map<PaciAplication, PaciiAPPlicationDTO>(entity);
        }


        public async Task<PaciiAPPlicationDTO> UpdateAsync(Guid id, PaciiAPPlicationDTO input)
        {
            var entity = await _productRepository.GetAsync(id);

            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(PaciAplication), id);
            }

            ObjectMapper.Map(input, entity);

            entity = await _productRepository.UpdateAsync(entity);

            return ObjectMapper.Map<PaciAplication, PaciiAPPlicationDTO>(entity);
        }
        public async Task DeleteAsync(Guid id)
        {
          
            await _productRepository.DeleteAsync(id);
        }

    }
}
