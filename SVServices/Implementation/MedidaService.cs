using SVRepository.Entities;
using SVRepository.Implementation;
using SVRepository.Interfaces;
using SVServices.Interfaces;

namespace SVServices.Implementation
{
    public class MedidaService : IMedidaService
    {
        private readonly IMedidaRepository _medidaRepository;
        public MedidaService(IMedidaRepository medidaRepository)
        {
            _medidaRepository = medidaRepository;
        }


        async Task<List<Medida>> IMedidaService.Listar()
        {
            return await _medidaRepository.Listar();
        }
    }
}
