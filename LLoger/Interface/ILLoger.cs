using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLoger.Interface
{
    public interface ILLoger
    {
        void LogInformation(dynamic log);
        void LogWarning(dynamic log);
        void LogError(dynamic log);
    }
}
