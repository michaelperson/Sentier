using Sentier.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace Sentier.Models.Concretes
{
    public abstract class Plante : IFrancais, IAnglais, INeerlandais, ILocalisable
    {

        public abstract string Nom { get; set; }
        public abstract string Description { get; set; }

        #region IFrancais
        string IFrancais.Nom
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

        string IFrancais.Description
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

        #region IAnglais
        string IAnglais.Nom
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

        string IAnglais.Description
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

        #region INeerlandais
        string INeerlandais.Nom
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

        string INeerlandais.Description
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
    }
}
