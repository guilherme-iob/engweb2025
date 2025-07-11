﻿using CursoSabado.Dominio.Framework;

namespace CursoSabado.Servicos.Framework
{
    public interface IServicoDeAplicacaoBasicoComNome<TEntidade> : IServicoBasico<TEntidade>
           where TEntidade : ObjetoComNome
    {
        IList<TEntidade> ObterPorInicioDeNome(String conteudo);
    }
}