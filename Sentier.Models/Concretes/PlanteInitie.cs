using Sentier.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentier.Models.Concretes
{
    public class PlanteInitie : Plante
    {
        private string _nomLatin;
        private readonly Evertu[] _vertus;
        public PlanteInitie()
        {
            _vertus = new Evertu[3];
        }
        #region Override
        public override string Nom
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string Description
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }


        #endregion

        public Evertu[] Vertus
        {
            get
            {
                return _vertus;
            }
        }

        public string NomLatin
        {
            get
            {
                return _nomLatin;
            }

            set
            {
                _nomLatin = value;
            }
        }
    }
}
