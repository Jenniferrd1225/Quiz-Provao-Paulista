/*
 * Created by SharpDevelop.
 * User: hatsu
 * Date: 02/10/2025
 * Time: 10:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SistemaQuiz
{
    public static class UsuarioSessao
    {
        public static string NomeUsuario { get; private set; }
        public static bool EstaLogado { get; private set; }

        static UsuarioSessao()
        {
            NomeUsuario = "";
            EstaLogado = false;
        }

        public static void Login(string nomeUsuario)
        {
            NomeUsuario = nomeUsuario;
            EstaLogado = true;
        }

        public static void Logout()
        {
            NomeUsuario = "";
            EstaLogado = false;
        }

        public static string ObterUsuarioLogado()
        {
            return EstaLogado ? NomeUsuario : "Visitante";
        }
    }
}