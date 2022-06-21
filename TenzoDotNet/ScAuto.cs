using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Controller;

namespace TenzoDotNet
{
    [Guid("6A4A82F8-B1B5-4675-ACCA-2A2A75B1EE96")]
    internal interface IScAuto
    {
        [DispId(1)]
        //4. описываем методы которые можно будет вызывать из вне
        double GetWeight(short port, short address);
    }

    [Guid("E217010E-52EB-497E-B2CB-B91B0A595131"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IMyEvents
    {
    }
    [Guid("65B81FDE-A691-4A20-8FDF-BB8FD2885F88"), ClassInterface(ClassInterfaceType.None), ComSourceInterfaces(typeof(IMyEvents))]
    public class ScAuto : IScAuto
    {
        public double GetWeight(short port, short address)
        {
            var sa = new Controller.ScAuto();
            return sa.GetWeight(port, address);
        }

    }

    
}
