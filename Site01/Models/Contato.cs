﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Site01.Models
{
    public class Contato
    {
        [Required(ErrorMessage = "O campo 'Nome' é obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo 'Nome' deve conter no máximo 50 carcteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo 'E-mail' é obrigatório")]
        [MaxLength(100, ErrorMessage = "O campo 'E-mail' deve conter no máximo 100 carcteres")]
        [EmailAddress(ErrorMessage = "O campo 'E-mail' é inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo 'Assunto' é obrigatório")]
        [MaxLength(70, ErrorMessage = "O campo 'Assunto' deve conter no máximo 70 carcteres")]
        public string Assunto { get; set; }
        [Required(ErrorMessage = "O campo 'Mensagem' é obrigatório")]
        [MaxLength(2000, ErrorMessage = "O campo 'Mensagem' deve conter no máximo 2000 carcteres")]
        public string Mensagem { get; set; }
    }
}