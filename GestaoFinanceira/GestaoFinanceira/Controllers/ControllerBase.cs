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
        protected readonly ApplicationDbContext db;
        private bool canDispose;
        public ControllerBase() : this(new ApplicationDbContext())
        {
            canDispose = true;
        }
        public ControllerBase(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void Dispose()
        {
            if (canDispose && db != null)
            {
                db.Dispose();
            }

        }
    }
}
