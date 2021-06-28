using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sentier.Models.Interfaces
{
    public interface ILocalisable
    {
        Coordinates Coordonnees { get; set; }
    }
}