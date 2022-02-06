using System.Linq;
using System.Collections.Generic;
using System.Collections;
namespace Biblioteca.Models
{
    public class UsuarioService
    {
        public void Inserir(Usuario user)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {

                bc.Usuarios.Add(user);
                bc.SaveChanges();
            }
        }
        public void Atualizar(Usuario user)
        {

            using (BibliotecaContext bc = new BibliotecaContext())
            {

                Usuario usr = bc.Usuarios.Find(user.Id);

                usr.Login = user.Login;
                usr.Nome = user.Nome;
                usr.Senha = user.Senha;
                usr.Tipo = user.Tipo;

                bc.SaveChanges();

            }

        }
        public void Excluir(int id)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Remove(bc.Usuarios.Find(id));
                bc.SaveChanges();
            }
        }
        public Usuario Listar(int id)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {

                return bc.Usuarios.Find(id);
            }
        }
        public List<Usuario> Listar()
        {
               using (BibliotecaContext bc = new BibliotecaContext())
            {

                return bc.Usuarios.ToList();
            }
        }
    }
}