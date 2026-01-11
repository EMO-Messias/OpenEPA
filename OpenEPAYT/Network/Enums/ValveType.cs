using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEPAYT.Network.Enums
{
    public enum ValveType
    {
        PRV, // (válvula redutora de pressão) Pressão, m (psi)
        PSV, // (Válvula Sustentadora de Pressão) Pressão, m (psi)
        PBV, // (Válvula de perda de carga fixa) Pressão, m (psi)
        FCV, // (válvula reguladora de vazão) Vazão (unidades de vazão)
        TCV, //  (válvula de controle de perda de carga) Coeficiente de perda de carga singular
        GPV // (válvula genérica) ID da curva de perda de carga.
    }
}
