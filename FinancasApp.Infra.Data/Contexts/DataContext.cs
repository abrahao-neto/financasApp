using FinancasApp.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //adicionar a connectionstring do banco de dados
            //optionsBuilder.UseSqlServer(@"Data Source=NETO\SQLEXPRESS;Initial Catalog=BDFinancasApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            optionsBuilder.UseSqlServer(@"Data Source=SQL5110.site4now.net;Initial Catalog=db_aa1ac5_bdfinancasapp;User Id=db_aa1ac5_bdfinancasapp_admin;Password=Yeshua@2023");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //adicionar cada classe de mapeamento
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new PerfilMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new MovimentacaoMap());
        }
    }
}
