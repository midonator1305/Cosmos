﻿using System;
using System.Collections.Generic;
using System.Text;
using Cosmos.HAL;

namespace Cosmos.System {
    static public class Boot {
        // [BootEntry(40)]
        static public void Init() {
            // Temp
            HAL.Boot.Init();
        }
    }
}
