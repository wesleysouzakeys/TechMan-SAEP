﻿using Microsoft.EntityFrameworkCore;
using SAEP_Treino_Final.Models;

namespace SAEP_Treino_Final.Contexts
{
    public class SAEPContext : DbContext
    {
        public SAEPContext(DbContextOptions<SAEPContext> options)
                    : base(options)
        {
        }

        public DbSet<Perfis> Perfis { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Equipamentos> Equipamentos { get; set; }
        public DbSet<Comentarios> Comentarios { get; set; }
    }
}
