using System.Collections.Generic;
using System.Threading.Tasks;
using BlogPessoal.src.modelos;

namespace BlogPessoal.src.repositorios
{  
    /// <summary>
    /// <para>Resumo: Responsavel por representar ações de CRUD de usuario</para>
    /// <para>Criado por: Ana Paula Rivera Brufato</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 01/06/2022</para>
    /// </summary>
    public interface IUsuario
    {
        Task<List<Usuario>> PegarTodosUsuariosAsync();
        Task<Usuario> PegarUsuarioPeloIdAsync(int id);
        Task<List<Usuario>> PegarUsuariosPeloNomeAsync(string nome);
        Task<Usuario> PegarUsuarioPeloEmailAsync(string email);
        Task NovoUsuarioAsync(Usuario usuario);
        Task AtualizarUsuarioAsync(Usuario usuario);
        Task DeletarUsuarioAsync(int id);  
    }
}
