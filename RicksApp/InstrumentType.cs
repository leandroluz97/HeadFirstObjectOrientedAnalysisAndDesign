using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RicksApp
{
    public enum InstrumentType
    {
        [DefaultValue("Guitar")]
        GUITAR,
        [DefaultValue("Banjo")]
        BANJO,
        [DefaultValue("Dobro")]
        DOBRO,
        [DefaultValue("Fiddle")]
        FIDDLE,
        [DefaultValue("Mandolin")]
        MANDOLIN
    }
}
