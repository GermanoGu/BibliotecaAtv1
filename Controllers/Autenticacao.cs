using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;
using System.Collections.Generic;
using System.Linq;



namespace Biblioteca.Controllers
{
    public class Autenticacao
    {
        public static void CheckLogin(Controller controller)
        {
            if (string.IsNullOrEmpty(controller.HttpContext.Session.GetString("Login")))
            {
                controller.Request.HttpContext.Response.Redirect("/Home/Login");
            }
        }
        public static bool verifyLogin(string login, string senha, Controller controller)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                AdmExist(bc);
                senha = Criptografo.TextoCriptografado(senha);

                IQueryable<Usuario> UserFind = bc.Usuarios.Where(u => u.Login == login && u.Senha == senha);
                List<Usuario> ListUserFind = UserFind.ToList();

                if (ListUserFind.Count == 0)
                {
                    return false;

                }
                else
                {
                    controller.HttpContext.Session.SetString("Login", ListUserFind[0].Login);
                    controller.HttpContext.Session.SetString("Nome", ListUserFind[0].Nome);
                    controller.HttpContext.Session.SetInt32("Tipo", ListUserFind[0].Tipo);
                    return true;
                }
            }
        }
        public static void AdmExist(BibliotecaContext bc)
        {
            IQueryable<Usuario> UserFind = bc.Usuarios.Where(u => u.Login == "admin");

            if (UserFind.ToList().Count == 0)
            {
                Usuario admin = new Usuario();
                admin.Login = "admin";
                admin.Senha = Criptografo.TextoCriptografado("123");
                admin.Tipo = Usuario.ADMIN;
                admin.Nome = "administrador";

                bc.Usuarios.Add(admin);
                bc.SaveChanges();
            }
        }
        public static void admTrue(Controller controller)
        {
            if (!(controller.HttpContext.Session.GetInt32("Tipo") == Usuario.ADMIN))
            {
                controller.Request.HttpContext.Response.Redirect("/Usuario/NeedAdmin");
            }
        }
    }
}