﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bully.Helper
{
    public class DeviceInfo
    {
        protected static DeviceInfo _instance;
        double width;
        double height;

        static DeviceInfo()
        {
            _instance = new DeviceInfo();
        }
        protected DeviceInfo()
        {
        }

        public static bool IsOrientationPortrait()
        {
            return _instance.height > _instance.width;
        }

        public static void SetSize(double width, double height)
        {
            _instance.width = width;
            _instance.height = height;
        }
    }
}
