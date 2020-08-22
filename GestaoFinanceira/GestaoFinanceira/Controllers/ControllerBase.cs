using GestaoFinanceira.BD.Conections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Controllers
{
    abstract class ControllerBase : IDisposable
    {
        private readonly ApplicationDbContext db;
        private bool canDispose;
        public ControllerBase() : this(new ApplicationDbContext())
        {
            canDispose = true;
        }
        public ControllerBase(ApplicationDbContext db)
        {
            this.db = db;
        }
        public ApplicationDbContext Context { get=>db;  }
        public void Dispose()
        {
            if (canDispose && Context != null)
            {
                Context.Dispose();
            }

        }
    }
}
