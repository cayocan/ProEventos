using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using ProEventos.Domain;
using ProEventos.Persistence.Contextos;
using ProEventos.Persistence.Contratos;

namespace ProEventos.Persistence
{
    public class PalestratePersist: IPalestrantePersist
    {
        private readonly ProEventosContext _context;

        public PalestratePersist(ProEventosContext context)
        {
            _context = context;
        }
        
        public async Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes.Include(pl => pl.RedesSociais);

            if (includeEventos)
            {
                query = query
                    .Include(pl => pl.PalestranteEventos)
                    .ThenInclude(ple => ple.Evento);
            }

            query = query
                .AsNoTracking()
                .OrderBy(pl => pl.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante[]> GetAllPalestrantesByNameAsync(string nome, bool includeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes.Include(pl => pl.RedesSociais);

            if (includeEventos)
            {
                query = query
                    .Include(pl => pl.PalestranteEventos)
                    .ThenInclude(ple => ple.Evento);
            }

            query = query
                .AsNoTracking()
                .OrderBy(pl => pl.Id)
                .Where(pl => pl.Nome.ToLower().Contains(nome.ToLower()));

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool includeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes.Include(pl => pl.RedesSociais);

            if (includeEventos)
            {
                query = query.Include(pl => pl.PalestranteEventos)
                    .ThenInclude(ple => ple.Evento);
            }

            query = query
                .AsNoTracking()
                .OrderBy(pl => pl.Id)
                .Where(pl => pl.Id == palestranteId);

            return await query.FirstOrDefaultAsync();
        }

        public Task<Palestrante[]> GetAllPalestrantesByEventoIdAsync(int eventoId, bool includeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes.Include(pl => pl.RedesSociais);

            if (includeEventos)
            {
                query = query.Include(pl => pl.PalestranteEventos)
                    .ThenInclude(ple => ple.Evento);
            }

            query = query
                .AsNoTracking()
                .OrderBy(pl => pl.Id)
                .Where(ple => ple.PalestranteEventos
                .Any(pls => pls.EventoId == eventoId));

            return query.ToArrayAsync();
        }
    }
}