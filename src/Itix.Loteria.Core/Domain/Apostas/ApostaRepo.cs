﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Itix.Loteria.Core.Domain.Apostas
{
    public interface IApostaRepo
    {
        void Insert(Aposta aposta);

        Aposta ByIdAposta(int idAposta);
    }

    public class ApostaRepo: IApostaRepo
    {
        List<Aposta> apostas = new List<Aposta>();

        public List<Aposta> GetTodos()
        {
            return apostas;
        }
        
        public void Insert(Aposta aposta)
        {
            apostas.Add(aposta);
        }

        public Aposta ByIdAposta(int idAposta)
        {
            return apostas
                .SingleOrDefault(x => x.IdAposta == idAposta);
        }

        //public List<Aposta> ByIdJogo(int idJogo)
        //{
        //    return apostas
        //        .SingleOrDefault(x => x.IdAposta == idAposta);
        //}



	
    }
}
