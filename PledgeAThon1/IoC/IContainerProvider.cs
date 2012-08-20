using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace PledgeAThon1.IoC
{
    public interface IContainerProvider
    {
        IUnityContainer Container { get; }
    }
}
