using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Library.Mail
{
    public class Constants
    {
        /*
         * POP3, IMAP - Ler mensagens de e-amail
         * SMTP - Enviar e-mail
         */

        //Autenticação - Gmail
        public readonly static string Usuario = "jjbazaga@gmail.com";
        public readonly static string Senha = "@jjbazaga170153";

        //Servidor SMTP
        public readonly static string ServidorSMTP = "smtp.gmail.com";
        public readonly static int PortaSMTP = 587;
    }
}
