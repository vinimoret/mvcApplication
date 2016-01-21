using System.Data.Entity.ModelConfiguration;
using VM.CursoMvc.Domain.Entities;

namespace VM.CursoMvc.Infra.Data.EntityConfig
{
    public class EnderecoConfiguration: EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            HasKey(e => e.EnderecoId);

            Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(150);

            Property(e => e.Numero)
                .IsRequired()
                .HasMaxLength(100);

            Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(50);

            Property(e => e.CEP)
                .IsRequired()
                .HasMaxLength(8);

            Property(e => e.Complemento)
                .IsRequired()
                .HasMaxLength(100);

            // or HasOptional to be optional
            HasRequired(e => e.Cliente)
                .WithMany(c => c.Enderecos)
                .HasForeignKey(e => e.ClienteId);

            ToTable("Enderecos");
        }    
    }
}