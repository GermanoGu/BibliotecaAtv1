using Biblioteca.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;

namespace Biblioteca.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult ListaUsuarios()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.admTrue(this);
            List<Usuario> listagem = new UsuarioService().Listar();
            return View(listagem);
        }

        public IActionResult AtualizaUser(int id)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.admTrue(this);
            Usuario usr = new UsuarioService().Listar(id);
            return View(usr);

        }

        [HttpPost]
        public IActionResult AtualizaUser(Usuario AtualizaUsr)
        {
           
            UsuarioService usr = new UsuarioService();
            usr.Atualizar(AtualizaUsr);
            return RedirectToAction("ListaUsuarios");
        }
        public IActionResult InserirUser()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.admTrue(this);
            return View();
        }

        [HttpPost]
        public IActionResult InserirUser(Usuario newUser)
        {
            UsuarioService usr = new UsuarioService();
            usr.Inserir(newUser);
            return RedirectToAction("ListaUsuarios");
        }
        public IActionResult ExcluirUser(int id)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.admTrue(this);
            UsuarioService usr = new UsuarioService();
            usr.Excluir(id);
            return RedirectToAction("ListaUsuarios");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult NeedAdmin()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }
    }

}