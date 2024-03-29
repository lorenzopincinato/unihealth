﻿using System.Collections.Generic;
using System.Linq;
using UniHealth.Application.Models;

namespace UniHealth.Application.Repositories
{
    public class PerfilUsuarioRepository : IPerfilUsuarioRepository
    {
        protected DbUniHealthContext _dbContext;

        public PerfilUsuarioRepository(DbUniHealthContext dataContext)
        {
            _dbContext = dataContext;
        }

        public List<PerfilUsuario> GetAll()
        {
            return _dbContext.PerfilUsuarios.ToList();
        }

        public PerfilUsuario GetPerfilUsuarioByTipoAsync(string tipo)
        {
            return _dbContext.PerfilUsuarios.FirstOrDefault(x => x.Tipo == tipo);
        }
    }
}
