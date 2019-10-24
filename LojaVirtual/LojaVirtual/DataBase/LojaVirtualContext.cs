﻿using LojaVirtual.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.DataBase
{
    public class LojaVirtualContext : DbContext
    {

        public LojaVirtualContext(DbContextOptions<LojaVirtualContext> options) : base(options)
        {

        }


        public DbSet<Cliente> Clientes { get; set; }  //criando o Dbset, para falar pro entity criar a tabela cliente no banco de dados
    }
}
