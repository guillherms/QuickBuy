
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Repositorios
{
    public class Clientes
    {
        public Clientes()
        {
            var usuarioRepositorio = new UsuarioRepositorio();
            var usuario = new Usuario();
            usuarioRepositorio.Adicionar(usuario);
        }
    }
}
