using System.Threading.Tasks;
using BlogPessoal.src.modelos;

namespace BlogPessoal.src.servicos
{
    /// <summary>
    /// <para>Resumo: Interface Responsavel por representar ações de autenticação</para>
    /// <para>Criado por: Ana Paula Rivera Brufato</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 01/06/2022</para>
    /// </summary>
    public interface IAutenticacao
    {
        string CodificarSenha(string senha);
        Task CriarUsuarioSemDuplicarAsync(Usuario usuario);
        string GerarToken(Usuario usuario);
    }
}
