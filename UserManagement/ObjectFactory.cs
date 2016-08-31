using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using UserManagement.Entities;

namespace UserManagement
{
    public class ObjectFactory
    {
        static public IUser GetInstanceIUser()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType(typeof(IUser), typeof(UserOpearions));
            IUser obj = container.Resolve<IUser>();
            return obj;
        }
    }
}
