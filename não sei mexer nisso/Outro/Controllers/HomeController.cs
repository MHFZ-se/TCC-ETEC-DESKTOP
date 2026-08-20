using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Outro.Models;
using TCC.Data;
using MySql.Data.MySqlClient;

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

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            Conexao conexao = new Conexao();

            if (conexao.AbrirConexao())
            {
                string sql =
                    "SELECT * FROM usuarios " +
                    "WHERE email = @email AND senha = @senha";

                MySqlCommand cmd =
                    new MySqlCommand(sql, conexao.conectar);

                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader reader =
                    cmd.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close();
                    conexao.FecharConexao();

                    return RedirectToAction("Dashboard");
                }

                reader.Close();
                conexao.FecharConexao();
            }

            ViewBag.Erro = "Email ou senha inválidos.";

            return View();
        }

        // Abre a pagina
        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }
        // Recebe os dados do formulario
        [HttpPost]
        public IActionResult Cadastro(Usuario usuario)
        {
            Conexao conexao = new Conexao();

            if (conexao.AbrirConexao())
            {
                string sql =
                    "INSERT INTO usuarios(nome,serie,telefone,email,senha) " +
                    "VALUES(@nome,@serie,@telefone,@email,@senha)";

                MySqlCommand cmd =
                    new MySqlCommand(sql, conexao.conectar);

                cmd.Parameters.AddWithValue(
                    "@nome",
                    usuario.Nome);

                cmd.Parameters.AddWithValue(
                    "@serie",
                    usuario.Serie);

                cmd.Parameters.AddWithValue(
                    "@telefone",
                    usuario.Telefone);

                cmd.Parameters.AddWithValue(
                    "@email",
                    usuario.Email);

                cmd.Parameters.AddWithValue(
                    "@senha",
                    usuario.Senha);

                cmd.ExecuteNonQuery();

                conexao.FecharConexao();
            }

            return RedirectToAction("Login");
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
