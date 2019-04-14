using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHW
{
    public interface IMessage
    {
        void ToStartMessage(string mess);
        void GoToStartMessage(string message);
    }
}
