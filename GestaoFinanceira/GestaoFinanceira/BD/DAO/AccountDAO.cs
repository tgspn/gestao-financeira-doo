using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.BD.DAO
{
    public class AccountDAO : DAOBase<Account>
    {
        public AccountDAO(IConnection<Account> connection) : base(connection)
        {

        }

        public override bool Delete(int id)
        {
            return connection.Delete(id);
        }

        public override IEnumerable<Account> Get()
        {
            return connection.Select();
        }

        public override Account Insert(Account accountBank)
        {
            var id = connection.Insert(accountBank);
            accountBank.Id = id;
            return accountBank;
        }

        public override Account Update(Account accountBank)
        {
            connection.Update(accountBank);
            return accountBank;
        }

        protected override string GetTableName()
        {
            return "Account";
        }
    }
}
