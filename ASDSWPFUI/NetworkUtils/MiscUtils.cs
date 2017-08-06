using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtils
{
    public static class MiscUtils
    {
        public enum OperationType
        {
            Add,
            Mult,
            ConstFlow,
            StochFlow,
            ConstPattern,
            ApTiFi,
            CaTiFi
        };
    }
}
