using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Outro.Models;
using TCC.Data;

namespace Outro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Conexao conexao = new Conexao();

            if (conexao.AbrirConexao())
            {
                ViewBag.Mensagem =
                    "Conectado ao MySQL com sucesso!";
            }
            else
            {
                ViewBag.Mensagem =
                    "Erro ao conectar.";
            }

            conexao.FecharConexao();

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Dispositivos()
        {
            return View();
        }

        public ActionResult Analise()
        {
            return View();
        }

        public ActionResult Contato()
        {
            return View();
        }
    }
}
