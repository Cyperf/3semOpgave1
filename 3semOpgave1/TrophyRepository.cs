using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _3semOpgave1
{
    public class TrophyRepository
    {
        private List<Trophy> _list;
        private int _nextId = 1;

        public TrophyRepository()
        {
            _list = new List<Trophy>();

        }
        public IEnumerable<Trophy> Get(int? year = null, string? competition = null)
        {
            IEnumerable<Trophy> result = new List<Trophy>(_list);
            if (year != null)
            {
                result = result.Where(t => t.Year == year);
            }

            if(competition != null)
            {
                result = result.Where(_ => _.Competition == competition);
            }

            return result;
        }

        public Trophy? GetById(int id)
        {
            return _list.FirstOrDefault(t => t.Id == id);
        }

        public Trophy Add(Trophy trophy)
        {
            trophy.ValidateAll();
            trophy.Id = _nextId++;
            _list.Add(trophy);
            return trophy;
        }

        public Trophy? Remove(int id)
        {
            Trophy trophy = GetById(id);
            if (trophy == null)
            {
                return null;
            }

            _list.Remove(trophy);
            return trophy;
        }

        public Trophy? Update(int id, Trophy trophy)
        {
            trophy.ValidateAll();

            Trophy oldTrophy = GetById(id);

            if (oldTrophy == null)
            {
                return null;
            }
            oldTrophy.Competition = trophy.Competition;
            oldTrophy.Year = trophy.Year;
            return oldTrophy;

        }
    }
}
