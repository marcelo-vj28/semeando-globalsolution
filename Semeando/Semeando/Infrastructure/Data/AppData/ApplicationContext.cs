using Microsoft.EntityFrameworkCore;
using Semeando.Domain.Entities;
using System;

namespace Semeando.Infrastructure.Data.AppData
{
    public class ApplicationContext : DbContext
    {
        // Definição dos DbSets para cada entidade
        public DbSet<UsuarioEntity> Usuarios { get; set; }
        public DbSet<LevelEntity> Levels { get; set; }
        public DbSet<PerguntaEntity> Perguntas { get; set; }
        public DbSet<OpcaoEntity> Opcoes { get; set; }
        public DbSet<RespostaEntity> Respostas { get; set; }

        // Construtor padrão
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        // Método para configurar o modelo de dados
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração da tabela de Usuário
            modelBuilder.Entity<UsuarioEntity>(entity =>
            {
                entity.ToTable("tb_Usuario");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id_usuario");
                entity.Property(e => e.Nome).HasColumnName("nome_usuario").IsRequired();
                entity.Property(e => e.Email).HasColumnName("email").IsRequired();
                entity.Property(e => e.Ranking).HasColumnName("ranking");
                entity.Property(e => e.Streak).HasColumnName("streak");
                entity.Property(e => e.Bio).HasColumnName("bio");
            });

            // Configuração da tabela de Level
            modelBuilder.Entity<LevelEntity>(entity =>
            {
                entity.ToTable("tb_Level");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id_level");
                entity.Property(e => e.Titulo).HasColumnName("titulo").IsRequired();
                entity.Property(e => e.Descricao).HasColumnName("descricao");
                entity.Property(e => e.Dificuldade).HasColumnName("dificuldade");
            });

            // Configuração da tabela de Pergunta
            modelBuilder.Entity<PerguntaEntity>(entity =>
            {
                entity.ToTable("tb_Pergunta");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id_pergunta");
                entity.Property(e => e.LevelId).HasColumnName("id_level");
                entity.Property(e => e.Texto).HasColumnName("texto").IsRequired();
                entity.Property(e => e.TipoPergunta).HasColumnName("tipo_pergunta");

                // Relacionamento com Level
                entity.HasOne(p => p.Level)
                    .WithMany(l => l.Perguntas)
                    .HasForeignKey(p => p.LevelId)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            // Configuração da tabela de Opção
            modelBuilder.Entity<OpcaoEntity>(entity =>
            {
                entity.ToTable("tb_Opcao");
                entity.HasKey(e => new { e.PerguntaId, e.Id });
                entity.Property(e => e.Id).HasColumnName("id_opcao");
                entity.Property(e => e.PerguntaId).HasColumnName("id_pergunta");
                entity.Property(e => e.Texto).HasColumnName("texto");
                entity.Property(e => e.OpCorreta).HasColumnName("op_correta");

                // Relacionamento com Pergunta
                entity.HasOne(o => o.Pergunta)
                    .WithMany(p => p.Opcoes)
                    .HasForeignKey(o => o.PerguntaId);
            });

            // Configuração da tabela de Resposta
            modelBuilder.Entity<RespostaEntity>(entity =>
            {
                entity.ToTable("tb_Resposta");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id_resposta");
                entity.Property(e => e.UsuarioId).HasColumnName("id_usuario");
                entity.Property(e => e.PerguntaId).HasColumnName("id_pergunta");
                entity.Property(e => e.OpcaoEscolhida).HasColumnName("op_escolhida");

                // Relacionamento com Usuário
                entity.HasOne(r => r.Usuario)
                    .WithMany(u => u.Respostas)
                    .HasForeignKey(r => r.UsuarioId);

                // Relacionamento com Pergunta
                entity.HasOne(r => r.Pergunta)
                    .WithMany(p => p.Respostas)
                    .HasForeignKey(r => r.PerguntaId);

                // Relacionamento com Opção
                entity.HasOne(r => r.Opcao)
                    .WithMany()
                    .HasForeignKey(r => new { r.PerguntaId, r.OpcaoEscolhida });
            });
        }

        // Método opcional para configurações adicionais
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configurações adicionais de banco de dados podem ser feitas aqui
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseOracle("SuaStringDeConexao");
            }
        }
    }
}
