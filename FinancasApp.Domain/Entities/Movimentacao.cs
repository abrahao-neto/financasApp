﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Domain.Entities
{
    public class Movimentacao
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public DateTime? Data { get; set; }
        public decimal? Valor { get; set; }
        public string? Descricao { get; set; }
        public TipoMovimentacao Tipo { get; set; }
        public Guid CategoriaId { get; set; }
        public Guid UsuarioId { get; set; }

        #region Relacionamentos

        public Categoria? Categoria { get; set; }
        public Usuario? Usuario { get; set; }

        #endregion
    }

    public enum TipoMovimentacao
    {
        Receita = 1,
        Despesa = 2
    }
}
