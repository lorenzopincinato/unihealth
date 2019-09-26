﻿using System.Threading.Tasks;
using UniHealth.Application.Models;

namespace UniHealth.Application.Repositories
{
    public interface IStatusUsuarioRepository
    {
        StatusUsuario GetStatusUsuarioByEstadoAsync(string estado);
    }
}
