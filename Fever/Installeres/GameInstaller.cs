using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;
using SiraUtil;

namespace Fever.Installeres
{
    public class GameInstaller : Installer
    {
        public override void InstallBindings()
        {
            this.Container.BindInterfacesAndSelfTo<FeverController>().FromNewComponentOnNewGameObject().AsSingle();
        }
    }
}
