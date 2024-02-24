﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public Guid PerfilId { get; set; }

        #region Relacionamentos

        public Perfil? Perfil { get; set; }
        public List<Movimentacao>? Movimentacoes { get; set; }

        #endregion
    }
}
