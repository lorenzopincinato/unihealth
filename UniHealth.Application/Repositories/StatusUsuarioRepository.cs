﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniHealth.Application.Models;

namespace UniHealth.Application.Repositories
{
    public class StatusUsuarioRepository : IStatusUsuarioRepository
    {
        protected DbUniHealthContext _dbContext;

        public StatusUsuarioRepository(DbUniHealthContext dataContext)
        {
            _dbContext = dataContext;
        }

        public List<StatusUsuario> GetAll()
        {
            return _dbContext.StatusUsuarios.ToList();
        }

        public StatusUsuario GetStatusUsuarioByEstadoAsync(string estado)
        {
            return _dbContext.StatusUsuarios.FirstOrDefault(x => x.Estado == estado);
        }
    }
}
