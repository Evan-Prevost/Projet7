using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet7
{
    internal class Map
    {
        char[,] _map; // OU char[][]

        void Init()
        {
            _map = new char[256,256];

            _map.GetLength(2);
        }

    }
}
