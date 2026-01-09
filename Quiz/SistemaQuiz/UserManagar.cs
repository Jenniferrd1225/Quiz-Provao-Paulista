using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SistemaQuiz
{
    public static class UserManager
    {
        private static string arquivoUsuarios = "usuarios.txt";
        private static List<Usuario> usuariosCadastrados = new List<Usuario>();

        static UserManager()
        {
            CarregarUsuarios();
        }

        public static List<Usuario> UsuariosCadastrados 
        { 
            get { return usuariosCadastrados; } 
        }

        public static void AdicionarUsuario(Usuario usuario)
        {
            usuariosCadastrados.Add(usuario);
            SalvarUsuarioNoArquivo(usuario);
        }

        public static bool VerificarLogin(string nomeUsuario, string senha)
        {
            foreach (Usuario usuario in usuariosCadastrados)
            {
                if (usuario.NomeUsuario == nomeUsuario && usuario.Senha == senha)
                {
                    return true;
                }
            }

            return VerificarLoginNoArquivo(nomeUsuario, senha);
        }

        public static bool UsuarioExiste(string nomeUsuario)
        {
            foreach (Usuario usuario in usuariosCadastrados)
            {
                if (usuario.NomeUsuario == nomeUsuario)
                {
                    return true;
                }
            }
            return false;
        }

        public static void AtualizarPontuacaoUsuario(string nomeUsuario, string tipoPontuacao, int pontos)
        {
            foreach (Usuario usuario in usuariosCadastrados)
            {
                if (usuario.NomeUsuario == nomeUsuario)
                {
                    switch (tipoPontuacao)
                    {
                        case "GE": usuario.PontosGE += pontos; break;
                        case "RG": usuario.PontosRG += pontos; break;
                        case "BI": usuario.PontosBI += pontos; break;
                        case "RB": usuario.PontosRB += pontos; break;
                        case "FI": usuario.PontosFI += pontos; break;
                        case "RF": usuario.PontosRF += pontos; break;
                        case "QU": usuario.PontosQU += pontos; break;
                        case "RQ": usuario.PontosRQ += pontos; break;
                        case "HI": usuario.PontosHI += pontos; break;
                        case "RH": usuario.PontosRH += pontos; break;
                        case "IN": usuario.PontosIN += pontos; break;
                        case "MT": usuario.PontosMT += pontos; break;
                        case "RM": usuario.PontosRM += pontos; break;
                        case "PT": usuario.PontosPT += pontos; break;
                        case "RP": usuario.PontosRP += pontos; break;
                    }
                    
                    SalvarTodosUsuarios();
                    break;
                }
            }
        }

        private static void CarregarUsuarios()
        {
            if (File.Exists(arquivoUsuarios))
            {
                try
                {
                    usuariosCadastrados.Clear();
                    foreach (string linha in File.ReadAllLines(arquivoUsuarios))
                    {
                        string[] dados = linha.Split(';');
                        
                        if (dados.Length >= 3)
                        {
                            if (dados.Length >= 19)
                            {
                                // CORREÇÃO: Declaração separada para cada variável
                                int pGE, pRG, pBI, pRB, pFI, pRF, pQU, pRQ, pHI, pRH, pIN, pMT, pRM, pPT, pRP;
                                
                                int pontosGE = int.TryParse(dados[3], out pGE) ? pGE : 0;
                                int pontosRG = int.TryParse(dados[4], out pRG) ? pRG : 0;
                                int pontosBI = int.TryParse(dados[5], out pBI) ? pBI : 0;
                                int pontosRB = int.TryParse(dados[6], out pRB) ? pRB : 0;
                                int pontosFI = int.TryParse(dados[7], out pFI) ? pFI : 0;
                                int pontosRF = int.TryParse(dados[8], out pRF) ? pRF : 0;
                                int pontosQU = int.TryParse(dados[9], out pQU) ? pQU : 0;
                                int pontosRQ = int.TryParse(dados[10], out pRQ) ? pRQ : 0;
                                int pontosHI = int.TryParse(dados[11], out pHI) ? pHI : 0;
                                int pontosRH = int.TryParse(dados[12], out pRH) ? pRH : 0;
                                int pontosIN = int.TryParse(dados[13], out pIN) ? pIN : 0;
                                int pontosMT = int.TryParse(dados[14], out pMT) ? pMT : 0;
                                int pontosRM = int.TryParse(dados[15], out pRM) ? pRM : 0;
                                int pontosPT = int.TryParse(dados[16], out pPT) ? pPT : 0;
                                int pontosRP = int.TryParse(dados[17], out pRP) ? pRP : 0;
                                
                                Usuario usuario = new Usuario(
                                    dados[0], dados[0], dados[1], dados[2],
                                    pontosGE, pontosRG, pontosBI, pontosRB,
                                    pontosFI, pontosRF, pontosQU, pontosRQ,
                                    pontosHI, pontosRH, pontosIN,
                                    pontosMT, pontosRM, pontosPT, pontosRP
                                );
                                usuariosCadastrados.Add(usuario);
                            }
                            else
                            {
                                Usuario usuario = new Usuario(dados[0], dados[0], dados[1], dados[2]);
                                usuariosCadastrados.Add(usuario);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao carregar usuários: " + ex.Message);
                }
            }
        }

        private static bool VerificarLoginNoArquivo(string nomeUsuario, string senha)
        {
            if (File.Exists(arquivoUsuarios))
            {
                foreach (string linha in File.ReadAllLines(arquivoUsuarios))
                {
                    string[] dados = linha.Split(';');
                    if (dados.Length >= 3 && dados[0] == nomeUsuario && dados[1] == senha)
                    {
                        Usuario usuario = new Usuario(dados[0], dados[0], dados[1], dados[2]);
                        if (!UsuarioExiste(nomeUsuario))
                        {
                            usuariosCadastrados.Add(usuario);
                        }
                        return true;
                    }
                }
            }
            return false;
        }

        private static void SalvarUsuarioNoArquivo(Usuario usuario)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(arquivoUsuarios))
                {
                    sw.WriteLine(
                        usuario.NomeUsuario + ";" + 
                        usuario.Senha + ";" + 
                        usuario.Email + ";" +
                        usuario.PontosGE.ToString() + ";" +
                        usuario.PontosRG.ToString() + ";" +
                        usuario.PontosBI.ToString() + ";" +
                        usuario.PontosRB.ToString() + ";" +
                        usuario.PontosFI.ToString() + ";" +
                        usuario.PontosRF.ToString() + ";" +
                        usuario.PontosQU.ToString() + ";" +
                        usuario.PontosRQ.ToString() + ";" +
                        usuario.PontosHI.ToString() + ";" +
                        usuario.PontosRH.ToString() + ";" +
                        usuario.PontosIN.ToString() + ";" +
                        usuario.PontosMT.ToString() + ";" +
                        usuario.PontosRM.ToString() + ";" +
                        usuario.PontosPT.ToString() + ";" +
                        usuario.PontosRP.ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar usuário: " + ex.Message);
            }
        }

        private static void SalvarTodosUsuarios()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(arquivoUsuarios))
                {
                    foreach (Usuario usuario in usuariosCadastrados)
                    {
                        sw.WriteLine(
                            usuario.NomeUsuario + ";" + 
                            usuario.Senha + ";" + 
                            usuario.Email + ";" +
                            usuario.PontosGE.ToString() + ";" +
                            usuario.PontosRG.ToString() + ";" +
                            usuario.PontosBI.ToString() + ";" +
                            usuario.PontosRB.ToString() + ";" +
                            usuario.PontosFI.ToString() + ";" +
                            usuario.PontosRF.ToString() + ";" +
                            usuario.PontosQU.ToString() + ";" +
                            usuario.PontosRQ.ToString() + ";" +
                            usuario.PontosHI.ToString() + ";" +
                            usuario.PontosRH.ToString() + ";" +
                            usuario.PontosIN.ToString() + ";" +
                            usuario.PontosMT.ToString() + ";" +
                            usuario.PontosRM.ToString() + ";" +
                            usuario.PontosPT.ToString() + ";" +
                            usuario.PontosRP.ToString()
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar usuários: " + ex.Message);
            }
        }
    }

    public class Usuario
    {
        public string NomeCompleto { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        
        public int PontosGE { get; set; }
        public int PontosRG { get; set; }
        public int PontosBI { get; set; }
        public int PontosRB { get; set; }
        public int PontosFI { get; set; }
        public int PontosRF { get; set; }
        public int PontosQU { get; set; }
        public int PontosRQ { get; set; }
        public int PontosHI { get; set; }
        public int PontosRH { get; set; }
        public int PontosIN { get; set; }
        public int PontosMT { get; set; }
        public int PontosRM { get; set; }
        public int PontosPT { get; set; }
        public int PontosRP { get; set; }
        
        public int PontuacaoTotal 
        { 
            get 
            { 
                return PontosGE + PontosRG + PontosBI + PontosRB + 
                       PontosFI + PontosRF + PontosQU + PontosRQ + 
                       PontosHI + PontosRH + PontosIN + 
                       PontosMT + PontosRM + PontosPT + PontosRP; 
            }
        }

        public Usuario(string nomeCompleto, string nomeUsuario, string senha, string email)
        {
            NomeCompleto = nomeCompleto;
            NomeUsuario = nomeUsuario;
            Senha = senha;
            Email = email;
            
            PontosGE = 0; PontosRG = 0;
            PontosBI = 0; PontosRB = 0;
            PontosFI = 0; PontosRF = 0;
            PontosQU = 0; PontosRQ = 0;
            PontosHI = 0; PontosRH = 0;
            PontosIN = 0;
            PontosMT = 0; PontosRM = 0;
            PontosPT = 0; PontosRP = 0;
        }
        
        public Usuario(string nomeCompleto, string nomeUsuario, string senha, string email, 
                       int pontosGE, int pontosRG, int pontosBI, int pontosRB,
                       int pontosFI, int pontosRF, int pontosQU, int pontosRQ,
                       int pontosHI, int pontosRH, int pontosIN,
                       int pontosMT, int pontosRM, int pontosPT, int pontosRP)
        {
            NomeCompleto = nomeCompleto;
            NomeUsuario = nomeUsuario;
            Senha = senha;
            Email = email;
            
            PontosGE = pontosGE; PontosRG = pontosRG;
            PontosBI = pontosBI; PontosRB = pontosRB;
            PontosFI = pontosFI; PontosRF = pontosRF;
            PontosQU = pontosQU; PontosRQ = pontosRQ;
            PontosHI = pontosHI; PontosRH = pontosRH;
            PontosIN = pontosIN;
            PontosMT = pontosMT; PontosRM = pontosRM;
            PontosPT = pontosPT; PontosRP = pontosRP;
        }
    }
}