using SVRepository.Entities;

namespace SVRepository.Interfaces
{
    public interface IProductoRepository
    {
        Task<List<Producto>> Listar(string buscar = "");
        Task<string> Crear(Producto objeto);
        Task<string> Editar(Producto objeto);
    }
}
