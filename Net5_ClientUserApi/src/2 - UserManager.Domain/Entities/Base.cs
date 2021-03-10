using System.Collections.Generic;

namespace UserManager.Domain.Entities
{
    public abstract class Base
    {
        public long Id { get; set; }

        internal List<string> _errors;
        //como internal é a lista de erros interna, o metodo public readOnly nos possibilita usa-lá e nao modificala
        public IReadOnlyCollection<string> Errors => _errors;

        public abstract bool Validate();
                
    }
}