using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Utils
{
    class Validator
    {
        public static bool isCreateNewGamaInitialSettingsValid(int width, int height, int bombs)
        {
            if ((height * width) > bombs) return true;
            return false;
        }
    }
}
